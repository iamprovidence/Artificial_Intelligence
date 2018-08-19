using System;
using System.Linq;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Threading.Tasks;
using logicalOperatorsClassifier.Models;

namespace logicalOperatorsClassifier
{
    public partial class MainForm : Form
    {
        // FIELDS
        Random r = new Random();

        NeuralNetwork perceptron;
        int inputAmount;
        int[] hiddenAmount;
        int outputAmount;
        double learningRate;
        double activation;
        MethodInfo[] activationFunctionsArray;

        int trainingAmount;
        int resolution;
        // CONSTRUCTORS
        public MainForm()
        {
            InitializeComponent();

            activationFunctionsArray = typeof(ActivationFunctions).GetMethods().Where(m => m.IsStatic).ToArray();

            inputAmount = 2;
            hiddenAmount = new int[] { 2 };
            outputAmount = 1;
            learningRate = 0.01;
            activation = 1;

            trainingAmount = 10000;
            resolution = 15;

            setNewNeuranNetwork();

            // FORM
            inputAmountTb.Text = inputAmount.ToString();
            hiddenAmountTb.Text = string.Join(" | ", hiddenAmount);
            outputAmountTb.Text = outputAmount.ToString();
            learningRateTb.Text = learningRate.ToString();
            activationTb.Text = activation.ToString();
            trainingAmountTb.Text = trainingAmount.ToString();
            
            aFuncCb.Items.AddRange(activationFunctionsArray.Select(x => x.Name.Replace('_', ' ')).ToArray());
            aFuncCb.SelectedItem = "Relu";

        }
        private void setNewNeuranNetwork()
        {
            perceptron = new NeuralNetwork(activationFunction: new ActivationFunction(ActivationFunctions.Relu),
                inputAmount: inputAmount, hiddenAmount: hiddenAmount, outputAmount: outputAmount, learningRate: learningRate, activation: activation);
        }
        // METHODS
        private void resultPnl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.White);

            try
            {
                g.DrawString("F F", this.Font, Brushes.Black, 5, 5);
                g.DrawString("F T", this.Font, Brushes.Black, resultPnl.Width - 25, 5);
                g.DrawString("T F", this.Font, Brushes.Black, 5, resultPnl.Height - 15);
                g.DrawString("T T", this.Font, Brushes.Black, resultPnl.Width - 25, resultPnl.Height - 15);

                for (int i = 20; i < resultPnl.Width - 20; i += resolution)
                {
                    for (int j = 20; j < resultPnl.Height - 20; j += resolution)
                    {
                        double[] input = new double[] { (double)i / resultPnl.Width, (double)j / resultPnl.Height };
                        int color = (int)(Math.Abs(perceptron.Guess(input)[0] * 100)) % 255;

                        brush.Color = Color.FromArgb(0, 0, color);
                        g.FillRectangle(brush, i, j, resolution, resolution);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                g.Dispose();
                brush.Dispose();
            }      
        }

        private void neuralNetworkPnl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            try
            {
                perceptron.Show(e.Graphics, neuralNetworkPnl.Width, neuralNetworkPnl.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                e.Dispose();
            }
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            resultPnl.Invalidate();
            neuralNetworkPnl.Invalidate();
        }
        private void randBtn_Click(object sender, EventArgs e)
        {
            perceptron.Randomize();
            neuralNetworkPnl.Invalidate();
        }

        private async void andBtn_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                for (int i = 0; i < trainingAmount; ++i)
                {
                    int n1 = r.Next(2);
                    int n2 = r.Next(2);
                    int res = (n1 == 1 && n2 == 1) ? 1 : 0;
                    perceptron.Train(new double[] { n1, n2 }, new double[] { res });
                }
            });
            t.Start();
            await t.ContinueWith((Task t2)=>
                Invoke((Action)delegate { neuralNetworkPnl.Invalidate(); }
            ));           

        }

        private async void orBtn_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                for (int i = 0; i < trainingAmount; ++i)
                {
                    int n1 = r.Next(2);
                    int n2 = r.Next(2);
                    int res = (n1 == 1 || n2 == 1) ? 1 : 0;
                    perceptron.Train(new double[] { n1, n2 }, new double[] { res });
                }
            });
            t.Start();
            await t.ContinueWith((Task t2) =>
                Invoke((Action)delegate { neuralNetworkPnl.Invalidate(); }
            ));
        }
        private async void xnorBtn_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                for (int i = 0; i < trainingAmount; ++i)
                {
                    int n1 = r.Next(2);
                    int n2 = r.Next(2);
                    int res = (n1 == 1) == (n2 == 1) ? 1 : 0;
                    perceptron.Train(new double[] { n1, n2 }, new double[] { res });
                }
            });
            t.Start();
            await t.ContinueWith((Task t2) =>
                Invoke((Action)delegate { neuralNetworkPnl.Invalidate(); }
            ));
        }

        private async void xorBtn_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                for (int i = 0; i < trainingAmount; ++i)
                {
                    int n1 = r.Next(2);
                    int n2 = r.Next(2);
                    int res = (n1 == 1 ^ n2 == 1) ? 1 : 0;
                    perceptron.Train(new double[] { n1, n2 }, new double[] { res });
                }
            });
            t.Start();
            await t.ContinueWith((Task t2) =>
                Invoke((Action)delegate { neuralNetworkPnl.Invalidate(); }
            ));
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            neuralNetworkPnl.Refresh();
            resultPnl.Refresh();
        }

        private void learningRateTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                perceptron.SetLearningRate(double.Parse(learningRateTb.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void activationTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                perceptron.SetActivation(double.Parse(activationTb.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void aFuncCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aFuncCb.SelectedIndex != -1)
            {
                perceptron.SetActivationFunction(new ActivationFunction(activationFunctionsArray[aFuncCb.SelectedIndex].CreateDelegate(typeof(Func<double, double>)) as Func<double, double>));
            }
        }

        private void trainingAmountTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                inputAmount = int.Parse(inputAmountTb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void hiddenAmountTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                hiddenAmount = hiddenAmountTb.Text.Split('|').Select(s => int.Parse(s)).ToArray();
                setNewNeuranNetwork();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
