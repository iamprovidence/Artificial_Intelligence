using digitRecognizer.Models;
using digitRecognizer.Models.Controls;

using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace digitRecognizer
{
	public partial class MainForm : Form
	{
		// FIELDS
		MnistDataReader dataReader;
		NeuralNetwork network;

		NumberControl[] numbers;

		// CONSTRUCTORS
		public MainForm()
		{
			InitializeComponent();
			InitializeOutputControls();
			
			dataReader = new MnistDataReader(@"Data\mnist_train.csv");
			network = new NeuralNetwork();

			byte[] colorCodes = dataReader.GetNumber(250).Values;
			drawingGrid.Draw(colorCodes);
		}

		private void InitializeOutputControls()
		{
			int outputAmount = 10;

			numbers = new NumberControl[outputAmount];
			for (int i = 0; i < outputAmount; ++i)
			{
				numbers[i] = new NumberControl()
				{
					BackColor = Color.White,
					Name = "numberControl" + i.ToString(),
					Size = new Size(109, 29),
					TabIndex = i + 10,
					Margin = new Padding(0),

					Number = i,
					Value = 0,
				};
				numbers[i].ControlChanged += (o, e) => (o as NumberControl)?.Refresh();
			}

			numberFlp.Controls.AddRange(numbers);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			numberFlp.Controls.Clear();
		}

		private void UpdateInterface(bool isEnabled)
		{
			drawingGrid.Enabled = isEnabled;

			clearBtn.Enabled = isEnabled;
			trainBtn.Enabled = isEnabled;
			guessBtn.Enabled = isEnabled;
		}

		// METHODS
		private void clearBtn_Click(object sender, EventArgs e)
		{
			drawingGrid.Clear();
		}

		private void guessBtn_Click(object sender, EventArgs e)
		{
			try
			{
				TryGuessNumber();
			}
			catch (Exception ex)
			{
				OnError(ex.Message);
			}
		}

		private void TryGuessNumber()
		{
			double[] input = drawingGrid.ToColorDoubleArray();

			double[] result = network.Guess(input);

			for (int i = 0; i < numbers.Length; ++i)
			{
				numbers[i].Value = Math.Round(result[i], 2);
			}
		}

		private async void trainBtn_Click(object sender, EventArgs e)
		{
			UpdateInterface(isEnabled: false);

			IEnumerable<MnistData> mnistDatas = await dataReader.ReadAsync();

			double[][] digits = mnistDatas.Select(d => d.Values.Select(Convert.ToDouble).ToArray()).ToArray();
			int[] targets = mnistDatas.Select(d => d.Number).ToArray();

			await network.TrainAsync(digits, targets);

			UpdateInterface(isEnabled: true);

			MessageBox.Show("Training finished", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
		}

		private void OnError(string error, string header = "Error")
		{
			MessageBox.Show(error, header, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
		}
	}
}
