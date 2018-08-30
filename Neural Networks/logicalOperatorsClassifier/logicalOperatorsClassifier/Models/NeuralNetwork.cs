using System;
using System.Linq;
using System.Drawing;

namespace logicalOperatorsClassifier.Models
{
    class NeuralNetwork
    {
        // FIELDS
        double learningRate;
        double activation;
        ActivationFunction aFunc;
        int inputAmount;
        int outputAmount;
        int[] hiddenLayerAmount; // array consist of amount of neuron in each layer
        int[] neuronPerLayer;
        Matrix[] weights;
        Vector[] biases;
        // PROPERTIES / GETS / SET
        public void SetLearningRate(double lr) => this.learningRate = lr;
        public void SetActivation(double activation) => this.activation = activation;
        public void SetActivationFunction(ActivationFunction aFunc) => this.aFunc = aFunc;
        // CONSTRUCORS
        public NeuralNetwork(ActivationFunction activationFunction, int inputAmount, int[] hiddenAmount, int outputAmount, double learningRate, double activation)
        {
            this.aFunc = activationFunction;
            this.inputAmount = inputAmount;
            this.hiddenLayerAmount = hiddenAmount;
            this.outputAmount = outputAmount;
            this.learningRate = learningRate;
            this.activation = activation;
            this.biases = new Vector[hiddenAmount.Length + 1];// all hiden and INPUT have bias neuron
            // create additional array for easier way to fill matrix and track of algorithms
            // 2 stands for input and output layer
            this.neuronPerLayer = new int[2 + hiddenAmount.Length];
            neuronPerLayer[0] = inputAmount ;
            neuronPerLayer[neuronPerLayer.Length - 1] = outputAmount;
            for(int i = 1; i < neuronPerLayer.Length - 1; ++ i)// coppy all hidden
            {
                neuronPerLayer[i] = hiddenAmount[i - 1];
                // biases
                biases[i - 1] = new Vector(rows: hiddenAmount[i - 1], fillValue: 1);
            }
            biases[biases.Length - 1] = new Vector(rows: outputAmount, fillValue: 1);

            this.weights = new Matrix[neuronPerLayer.Length - 1];
            for(int i = 0; i < weights.Length; ++i)
            {
                // so we have fully connected neural network
                // ROWS = amount of neurons in next layer
                // COLS = amount of neurons in this layer 
                // firstly weight of connections are random
                weights[i] = new Matrix(rows: neuronPerLayer[i + 1], cols: neuronPerLayer[i]).randomize();
            }
        }
        // METHODS
        public void Randomize()
        {
            for (int i = 0; i < biases.Length; ++i)
            {
                biases[i].Fill(1);
            }
            
            for (int i = 0; i < weights.Length; ++i)
            {
                weights[i].randomize();
            }
        }
        
        public double[] Guess(double[] input)
        {
            if (input.Length != inputAmount) throw new ArgumentException("Wrong amount of inputs");

            return FeedForward(input).Last().ToArray();
        }
        private Vector[] FeedForward(double[] input)
        {
            Vector[] inputForNextLayer = new Vector[neuronPerLayer.Length];
            inputForNextLayer[0] = new Vector(input);

            for (int i = 0; i < weights.Length; ++i)
            {
                inputForNextLayer[i + 1] = (weights[i] * inputForNextLayer[i] + biases[i]).TransformEach(aFunc.Func);
            }

            return inputForNextLayer;
        }
        public void Train(double[] input, double[] target)
        {
            // inputs vector for backpropagination
            Vector[] inputForNextLayer = FeedForward(input);
            // calc error
            double[] result = inputForNextLayer[inputForNextLayer.Length - 1].ToArray();
            double[] error = new double[result.Length];

            Vector[] errorsVector = new Vector[neuronPerLayer.Length - 1];
            // output error
            for (int i = 0; i < result.Length; ++i)
            {
                error[i] = target[i] - result[i];
            }
            errorsVector[errorsVector.Length - 1] = new Vector(error);
            // errors
            for (int i = errorsVector.Length - 2; i >= 0; --i)
            {
                errorsVector[i] = Matrix.Transpose(weights[i + 1]) * errorsVector[i + 1];
            }

            // BACK PROPOGATION
            Vector gradientVector = inputForNextLayer[inputForNextLayer.Length - 1].TransformEach(aFunc.Deriv);
            for (int i = weights.Length - 1; i >= 0; --i)
            {
                // neuron in input to output layer
                Vector changes = learningRate * errorsVector[i] * gradientVector;
                biases[i] += changes;
                weights[i] += changes * Vector.Transpose(inputForNextLayer[i]);

                // new value
                gradientVector = inputForNextLayer[i].TransformEach(aFunc.Deriv);
            }
        }
        
        public void Show(Graphics g, float width, float height)
        {
            // remember neuron X Y position
            PointF[][] neuronPosition = new PointF[neuronPerLayer.Length][];
            

            // how much space each layer takes
            float layerWidth = width / neuronPerLayer.Length;
            // middle of the layer
            float halfLayerWidth = layerWidth / 2;

            int neuronIndex = 0;
            int neuronPositionIndex = 0;
            // calc position of each neurons
            for(float i = 0; i < width; i += layerWidth)
            {
                // position of neurons in one layer
                PointF[] neuronPositionInLayer = new PointF[neuronPerLayer[neuronIndex]];

                int neuronInLayerIndex = 0;
                // how much height each neuron takes per layer
                float neuronHeight = height / neuronPerLayer[neuronIndex++];
                float halfNeuronHeight = neuronHeight / 2;
                // calc position of each neuron per layer
                for (float j = 0; j < height; j += neuronHeight)
                {
                    neuronPositionInLayer[neuronInLayerIndex++] = new PointF(i + halfLayerWidth, j + halfNeuronHeight);
                }
                neuronPosition[neuronPositionIndex++] = neuronPositionInLayer;
            }

            // DRAWING
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            // draw weights
            Pen redPen = new Pen(Color.Red);// negative connections
            Pen greenPen = new Pen(Color.Green);// positive connection
            Pen weightPen;
            for (int i = 0; i < neuronPosition.Length - 1; ++i)
            {
                for(int k = 0; k < neuronPosition[i].Length; ++k)
                {
                    for(int j = 0; j < neuronPosition[i + 1].Length; ++j)
                    {
                        weightPen = weights[i][j, k] > 0 ? greenPen : redPen;
                        weightPen.Width = (float)Constrain(Math.Abs(weights[i][j, k]) * 2, 1, 5);
                        g.DrawLine(weightPen, neuronPosition[i][k], neuronPosition[i + 1][j]);
                    }
                }
            }
            redPen.Dispose();
            greenPen.Dispose();
            // draw neurons

            Pen neuronPen = new Pen(Color.Black);
            // neuron size = min(neuronHeighMin, neuronWidthMin)
            // smallest neuron height = 1/3 of the height of the neurons in the biggest layer
            float neuronHeightMin = height / (neuronPerLayer[Array.IndexOf(neuronPerLayer, neuronPerLayer.Max())] * 3);
            // smallest neuron width = 1/3 of layer width
            float neuronWidthMin = width / (neuronPerLayer.Length * 3);
            // less value of two
            float neuronSize = neuronWidthMin > neuronHeightMin ? neuronHeightMin : neuronWidthMin;

            for (int i = 0; i < neuronPosition.Length; ++i)
            {
                for(int j = 0; j < neuronPosition[i].Length; ++j)
                {
                    // position - half of size, so neurons would be in the center of theirs positions
                    g.FillEllipse(Brushes.Gray, neuronPosition[i][j].X - neuronSize / 2, neuronPosition[i][j].Y - neuronSize / 2, neuronSize, neuronSize);
                    g.DrawEllipse(neuronPen, neuronPosition[i][j].X - neuronSize / 2, neuronPosition[i][j].Y - neuronSize / 2, neuronSize, neuronSize);
                }
            }
            neuronPen.Dispose();
        }
        private double Constrain(double value, double min, double max)
        {
            if (value < min) return min;
            else if (value > max) return max;
            else return value;
        }
        
    }
}
