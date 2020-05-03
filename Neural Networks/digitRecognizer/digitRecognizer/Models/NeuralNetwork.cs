using Accord.Statistics.Kernels;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;

using System;
using System.Threading.Tasks;

namespace digitRecognizer.Models
{
	public class NeuralNetwork
	{
		MulticlassSupportVectorMachine<IKernel> ksvm;

		public double[] Guess(double[] input)
		{
			if (ksvm is null) throw new InvalidOperationException("You need to train model first");

			return ksvm.Probabilities(input);
		}

		public Task TrainAsync(double[][] input, int[] target)
		{
			var ml = new MulticlassSupportVectorLearning<IKernel>()
			{
				Learner = (param) => new SequentialMinimalOptimization<IKernel>()
				{

					Strategy = SelectionStrategy.WorstPair,
					Kernel = new Linear(constant: 1000),
				}
			};

			return Task.Run(() => ksvm = ml.Learn(input, target));
		}
	}
}
