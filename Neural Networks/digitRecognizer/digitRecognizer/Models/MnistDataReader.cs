using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace digitRecognizer.Models
{
	public class MnistDataReader
	{
		private readonly string filePath;

		public MnistDataReader(string filePath)
		{
			this.filePath = filePath;
		}

		public async Task<List<MnistData>> ReadAsync()
		{
			List<MnistData> list = new List<MnistData>(1000);

			using (StreamReader reader = File.OpenText(filePath))
			{
				for (string line = await reader.ReadLineAsync(); !reader.EndOfStream; line = await reader.ReadLineAsync())
				{
					list.Add(FromRow(line));
				}
			}

			return list;
		}

		public MnistData GetNumber(int index)
		{
			string textLine = File.ReadLines(filePath).Skip(index).First();
			return FromRow(textLine);
		}

		private MnistData FromRow(string row)
		{
			string[] rowNumbers = row.Split(',');

			return new MnistData
			{
				Number = int.Parse(rowNumbers.First()),
				Values = rowNumbers.Skip(1).Select(byte.Parse).ToArray(),
			};
		}
	}
}
