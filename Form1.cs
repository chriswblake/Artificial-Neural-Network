using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ch5_ANN
{
    public partial class Form1 : Form
    {
        //Fields
        ArtificialNeuralNetwork net = null;

        public Form1()
        {
            InitializeComponent();

            //Sample network so it looks cool
            net = new ArtificialNeuralNetwork(4, 3, 4);
            displayNetwork(net);
        }

        //Initialize
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1200;
            this.Height = 600;          
        }

        //Controls
        private void tbNodes_TextChanged(object sender, EventArgs e)
        {
            int numInputNodes = 0;
            int numHiddenNodes = 0;
            int numOutputNodes = 0;
            try
            {
                numInputNodes = Convert.ToInt32(tbInputNodes.Text);
                numHiddenNodes = Convert.ToInt32(tbHiddenNodes.Text);
                numOutputNodes = Convert.ToInt32(tbOutputNodes.Text);
            }
            catch
            {
                return;
            }

            //Create
            net = new ArtificialNeuralNetwork(numInputNodes, numHiddenNodes, numOutputNodes);

            //Show
            displayNetwork(net);
        }
        private void btnTrain_Click(object sender, EventArgs e)
        {
            //Get input parameters
            int hiddenNodeCount = 0; //only for display on MSE legend
            double learningRate = 0.2;
            int maxCycles = 100;           
            double maxAllowableError = 0.1;
            try
            {
                hiddenNodeCount = Convert.ToInt32(tbHiddenNodes.Text); //only for display on MSE legend
                maxCycles = Convert.ToInt32(tbCycles.Text);
                learningRate = Convert.ToDouble(tbLearningRate.Text);
                maxAllowableError = Convert.ToDouble(tbMaxError.Text);
                
            }catch
            {
                return;
            }

            //Clear textbox
            tbResults.Text = ""; //clears box before processing incase of error

            #region Training
            //Reset weights
            net.ResetWeights();

            //Backpropagate
            List<double> err = net.BackPropagate(TrainingData.trainingDataInputs, TrainingData.trainingDataTargets, learningRate, maxCycles, maxAllowableError);       
            #endregion

            #region Show Network and MSE Chart
            //Display graphical network
            displayNetwork(net);

            //MSE Chart
            string legendText = "N=" + hiddenNodeCount + " L=" + learningRate.ToString("F1") + " C=" + maxCycles.ToString() + " E=" + maxAllowableError.ToString();
            displayError(err, chbClearMSE.Checked, legendText);
            #endregion

            #region Display training samples
            //Process for all training data
            double[][] resultsTraining = new double[TrainingData.trainingDataInputs.Length][];
            for (int i = 0; i < TrainingData.trainingDataInputs.Length; i++)
            {
                double[] calculatedAction = net.ProcessInput(TrainingData.trainingDataInputs[i]);
                resultsTraining[i] = calculatedAction;
            }

            //Create string from results
            string resultsTrainingString = displayResults(TrainingData.trainingDataInputs, TrainingData.trainingDataTargets, resultsTraining);
            #endregion

            #region Display confirmation data
            //Process for all confirmation data
            double[][] resultsConfirmation = new double[TrainingData.confirmationDataInputs.Length][];
            for (int i = 0; i < TrainingData.confirmationDataInputs.Length; i++)
            {
                double[] calculatedAction = net.ProcessInput(TrainingData.confirmationDataInputs[i]);
                resultsConfirmation[i] = calculatedAction;
            }

            //Create string from results
            string resultsConfirmationString = displayResults(TrainingData.confirmationDataInputs, TrainingData.confirmationDataTargets, resultsConfirmation);
            #endregion

            //Combine strings and send to text box
            tbResults.Text = "----- Training Data -----" + Environment.NewLine;
            tbResults.Text += resultsTrainingString;
            tbResults.Text += Environment.NewLine;
            tbResults.Text += "Cycles:" + err.Count;

            tbResults.Text += Environment.NewLine;
            tbResults.Text += Environment.NewLine;

            tbResults.Text += "----- Confirmation Data -----"  + Environment.NewLine;
            tbResults.Text += resultsConfirmationString;
        }

        //Display
        public void displayError(List<double> err, bool clear, string legendText)
        {
            //If requested, clear the series
            List<Series> prevSeries = chartNetwork.Series.Where(s => s.Name.Contains("MSE_")).ToList();
            if (clear)
            {
                foreach (Series s in prevSeries)
                {
                    chartNetwork.Series.Remove(s);
                }
            }
            prevSeries = chartNetwork.Series.Where(s => s.Name.Contains("MSE_")).ToList();

            //Create a new series
            Series seriesMSE = new Series() {
                Name = "MSE_" + (prevSeries.Count+1).ToString(),
                ChartType = SeriesChartType.Line,
                ChartArea = "chartAreaMSE",
                LegendText = legendText
            };

            //Add points to series
            for (int i = 0; i < err.Count; i++)
            {
                int cycle = i + 1;
                string toolTip = "Cycle: " + i + Environment.NewLine + "Error: " + err[i].ToString("F3");
                seriesMSE.Points.Add(new DataPoint(cycle, err[i]) { ToolTip = toolTip });
            }

            //Add label to last point
            DataPoint lastPoint = seriesMSE.Points.Last();
            lastPoint.Label = lastPoint.YValues[0].ToString("F3");

            //Add series to chart
            chartNetwork.Series.Add(seriesMSE);
        }
        public string displayResults(double[][] inputs, double[][] targets, double[][] results)
        {
            //Collapse results into this string before sending to textbox;
            string s = "";

            //Counter for incorrect actions
            int countIncorrectActions = 0;

            //Display in results box
            s = "Health" + "\t" + "Knife" + "\t" + "Gun" + "\t" + "Enemies" + "\t" + "Target" + "\t" + "Calculated" + Environment.NewLine;
            for (int i = 0; i < results.Length; i++)
            {
                //Pick entry
                double[] inputItem = inputs[i];
                double[] targetAction = targets[i];

                //Show input
                int health = Convert.ToInt32(inputItem[0]);
                int knife = Convert.ToInt32(inputItem[1]);
                int gun = Convert.ToInt32(inputItem[2]);
                int enemies = Convert.ToInt32(inputItem[3]);
                s += health + "\t" + knife + "\t" + gun + "\t" + enemies;

                //Show target
                string targetActionString = TrainingData.outputToText(targetAction);
                s += "\t" + targetActionString;

                //Show calculation
                double[] calculatedAction = results[i];
                string calculatedActionString = TrainingData.outputToText(calculatedAction);
                s += "\t" + calculatedActionString;

                //Count if not same action
                if (calculatedActionString != targetActionString)
                    countIncorrectActions++;

                //Next line
                s += Environment.NewLine;
            }

            //Show number of incorrect actions
            s += "Incorrect actions: " + countIncorrectActions.ToString();

            //Send to text box
            return s;
            
            //string results2String = string.Join(",", Array.ConvertAll(results2, x => Math.Round(x, 3)));
        }
        public void displayNetwork(ArtificialNeuralNetwork net)
        {
            //Display Network Nodes
            Series theSeries = chartNetwork.Series["Nodes"];
            theSeries.Points.Clear();
            foreach (DataPoint p in net.getDisplayNodes())
                theSeries.Points.Add(p);

            //Display Network Connections
            theSeries = chartNetwork.Series["Connections"];
            theSeries.Points.Clear();
            foreach (DataPoint p in net.getDisplayConnections())
                theSeries.Points.Add(p);
        }
        private void tbUseNetwork_TextChanged(object sender, EventArgs e)
        {
            //Default inputs
            int health = 2;
            int knife = 1;
            int gun = 0;
            int enemies = 0;

            //Try to get inputs from form
            try {
                health = Convert.ToInt32(tbHealth.Text); if (health <= 0) throw new ArgumentException();
                knife = Convert.ToInt32(tbKnife.Text); if (knife < 0 || knife > 1) throw new ArgumentException();
                gun = Convert.ToInt32(tbGun.Text); if (gun < 0 || gun > 1) throw new ArgumentException();
                enemies = Convert.ToInt32(tbEnemies.Text); if (enemies < 0) throw new ArgumentException();
            }
            catch
            {
                //Return if any errors
                tbAction.Text = "";
                return;
            }

            //Calculate the action using the network
            double[] calcActionArray = net.ProcessInput(new double[] { health, knife, gun, enemies });
            string calcActionString = TrainingData.outputToText(calcActionArray);
            tbAction.Text = calcActionString;
        }
    }

    public class ArtificialNeuralNetwork
    {
        //Fields
        public List<Neuron> input = new List<Neuron>();
        public List<Neuron> hidden = new List<Neuron>();
        public List<Neuron> output = new List<Neuron>();
        public List<NeuronConnection> connections = new List<NeuronConnection>();

        //Constructors
        public ArtificialNeuralNetwork(int inputNodes, int hiddenNodes, int outputNodes)
        {
            Random rand = new Random();

            //Tracking ID number (not used. just for easier display and debugging)
            int id = 0;
            //Display variables
            double x = 0, y = 0, yspacing = 0, ymax = 100;

            //Create input nodes
            x = 1; y = 1; //Display Start spot
            yspacing = ymax / inputNodes;
            for (int i =0; i<inputNodes;i++)
            {
                //Increment ID
                id++;

                //Add neuron
                Neuron inputNeuron = new Neuron(id) { DisplayPoint = new DataPoint(x, y) { Label = id.ToString() } };
                input.Add(inputNeuron);

                //Next position
                y += yspacing;
            }

            //Create hidden nodes
            x = 2; y = 1; //Start spot
            yspacing = ymax / hiddenNodes;
            for (int i = 0; i < hiddenNodes; i++)
            {
                //Increment ID
                id++;

                //Add neuron
                Neuron hiddenNeuron = new Neuron(id) {
                    Bias = rand.NextDouble(),
                    DisplayPoint = new DataPoint(x, y) { Label = id.ToString() }
                };

                hidden.Add(hiddenNeuron);

                //Create connections to input layer
                foreach(Neuron inputNeuron in input)
                {
                    connections.Add(new NeuronConnection(inputNeuron, hiddenNeuron, rand.NextDouble()));
                }

                //Next position
                y += yspacing;
            }

            //Create output nodes
            x = 3; y = 1; //Start spot
            yspacing = ymax / outputNodes;
            for (int i = 0; i < outputNodes; i++)
            {
                //Increment ID
                id++;

                //Add neuron
                Neuron outputNeuron = new Neuron(id) {
                    Bias = rand.NextDouble(),
                    DisplayPoint = new DataPoint(x, y) { Label = id.ToString() }
                };
                output.Add(outputNeuron);

                //Create connections to input layer
                foreach (Neuron hiddenNeuron in hidden)
                {
                    connections.Add(new NeuronConnection(hiddenNeuron, outputNeuron, rand.NextDouble()));
                }

                //Next position
                y+=yspacing;
            }
        }

        //Method
        public double[] ProcessInput(double[] inputValues)
        {
            //Check that it has the correct number of values
            if (input.Count != inputValues.Length)
                throw new ArgumentException("The input array must be the same size as the created network.");

            //Assign values to inputs
            for (int i=0; i < input.Count; i++)
            {
                input[i].Value = inputValues[i];
            }

            //Calculate all hidden Nodes
            foreach (Neuron h in hidden)
            {
                h.calculateValueFromConnections(connections);
            }

            //Calculate all output Nodes
            foreach (Neuron o in output)
            {
                o.calculateValueFromConnections(connections);
            }

            //Compile output node values into an array
            double[] results = new double[output.Count];
            for (int i = 0; i < output.Count; i++)
            {
                results[i] = output[i].Value;
            }

            //return results
            return results;
        }
        public List<double> BackPropagate(double[][] inputValues, double[][] targetValues, double learningRate, double maxCycles, double maxAllowableError)
        {
            //For recording error vs cycle
            List<double> err = new List<double>();

            
            //Backpropagate
            for (int cycle = 1; cycle <= maxCycles; cycle++)
            {
                //Error for this cycle
                List<double> errCycle = new List<double>();

                //Loope through each training sample
                for (int i = 0; i < inputValues.Length; i++)
                {
                    double[] trainingInputSample = inputValues[i];
                    double[] trainingInputTarget = targetValues[i];
                    errCycle.Add(BackPropagate(trainingInputSample, trainingInputTarget, learningRate));
                }

                //Calculate average error for the cycle
                double errCycleMax = errCycle.Max();
                err.Add(errCycleMax);

                //If error below requirement
                if (errCycleMax < maxAllowableError)
                {
                    break;
                }
            }

            //Return Error vs cycle (index is cycle)          
            return err; 
        }
        public double BackPropagate(double[] inputValues, double[] targetValues, double learningRate)
        {
            //Check that parameters have the correct number of values
            if (input.Count != inputValues.Length)
                throw new ArgumentException("The input array must be the same size as the created network.");
            if (output.Count != targetValues.Length)
                throw new ArgumentException("The target array must be the same size as the created network.");
            
            //Calculate error at output cells
            ProcessInput(inputValues);
            for(int o=0; o<output.Count; o++)
            {
                output[o].Error = (targetValues[o] - output[o].Value) * Neuron.sigmoidDerivative(output[o].Value);
            }

            //Calculate error at hidden cells
            for (int h = 0; h < hidden.Count; h++)
            {
                //Get node
                Neuron hiddenNeuron = hidden[h];


                //Cycle throuh each output node
                hiddenNeuron.Error = 0;
                for (int o = 0; o < output.Count; o++)
                {
                    //Get node
                    Neuron outputNeuron = output[o];

                    //Get connection between output and hidden nodes
                    NeuronConnection nc = connections.Find(c => c.A == hiddenNeuron && c.B == outputNeuron);

                    //Add to error
                    hiddenNeuron.Error += outputNeuron.Error * nc.Weight;
                }

                hiddenNeuron.Error *= Neuron.sigmoidDerivative(hiddenNeuron.Value);
            }

            //Update weights of output layer
            foreach(Neuron outputNeuron in output)
            {
                foreach(Neuron hiddenNeuron in hidden)
                {
                    //get the connection
                    NeuronConnection nc = connections.Find(c => c.A == hiddenNeuron && c.B == outputNeuron);

                    //Update Weight
                    nc.Weight += learningRate * outputNeuron.Error * hiddenNeuron.Value;
                }

                //Update Bias
                outputNeuron.Bias += learningRate * outputNeuron.Error;
            }

            //Update weights of hidden layer
            foreach(Neuron hiddenNeuron in hidden)
            {
                foreach(Neuron inputNeuron in input)
                {
                    //get the connection
                    NeuronConnection nc = connections.Find(c => c.A == inputNeuron && c.B == hiddenNeuron);

                    //Update Weight
                    nc.Weight += learningRate * hiddenNeuron.Error * inputNeuron.Value;
                }

                //Update Bias
                hiddenNeuron.Bias += learningRate * hiddenNeuron.Error;
            }

            //Calculate MSE
            double err = 0;
            for (int o = 0; o < output.Count; o++)
            {
                err += Math.Pow(targetValues[o] - output[o].Value, 2);
            }
            err *= 0.5;

            //Return error
            return err;
        }
        public List<DataPoint> getDisplayNodes()
        {
            //Results list
            List<DataPoint> points = new List<DataPoint>();

            //Input nodes
            foreach (Neuron n in input)
                points.Add(n.DisplayPoint);

            //Hidden nodes
            foreach (Neuron n in hidden)
                points.Add(n.DisplayPoint);

            //Output nodes
            foreach (Neuron n in output)
                points.Add(n.DisplayPoint);

            return points;
        }
        public List<DataPoint> getDisplayConnections()
        {
            //Results list
            List<DataPoint> points = new List<DataPoint>();

            //Input Nodes
            foreach (NeuronConnection nc in connections)
            {
                DataPoint a = nc.A.DisplayPoint.Clone();
                DataPoint b = nc.B.DisplayPoint.Clone();
                a.Label = "";
                b.Label = "";

                //Create label in middle
                double xLabel = a.XValue + (b.XValue - a.XValue) * 0.5;
                double yLabel = a.YValues[0] + (b.YValues[0] - a.YValues[0]) * 0.5;
                DataPoint mid = new DataPoint(xLabel, yLabel) { Label = nc.Weight.ToString("F3"), LabelToolTip = nc.ID };

                points.Add(new DataPoint() { IsEmpty = true });
                points.Add(a);
                points.Add(mid);
                points.Add(b);
                points.Add(new DataPoint() { IsEmpty = true });
            }

            return points;
        }
        public void ResetWeights()
        {
            Random rand = new Random();
            foreach(NeuronConnection nc in connections)
            {
                nc.Weight = rand.NextDouble();
            }
        }
    }
    public class Neuron
    {
        //Fields
        int id;
        double value;
        double bias;
        double error;
        public DataPoint DisplayPoint = null;
        
        //Constructors
        public Neuron(int id)
        {
            this.id = id;
        }

        //Properties
        public int ID
        {
            get { return id; }
        }
        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public double Bias
        {
            get { return bias; }
            set { bias = value; }
        }
        public double Error
        {
            get { return error; }
            set { error = value; }
        }

        //Methods
        public void calculateValueFromConnections(List<NeuronConnection> connections)
        {
            //Sum results
            double sum = 0;
            foreach (NeuronConnection nc in connections.FindAll(nc => nc.B == this))
            {
                sum += nc.A.Value * nc.Weight;
            }

            //Store value
            this.value = ActivationFunction(sum);

        }
        public static double ActivationFunction(double value)
        {
            //Using Sigmoid activation
            // y = 1 / (1 + e^(-x))
            return 1 / (1 + Math.Exp(-value));
        }
        public static double sigmoidDerivative(double value)
        {
            return (value * (1.0 - value));
        }

        //Support
        public override string ToString()
        {
            return id.ToString() + ", " + value.ToString("F3");
        }
        
    }
    public class NeuronConnection
    {
        //Fields
        string id;
        double weight;
        Neuron a;
        Neuron b;

        //Constructor
        public NeuronConnection(Neuron a, Neuron b, double weight)
        {
            //Save details
            this.a = a;
            this.b = b;
            this.weight = weight;

            //Generate ID. Lower number is always first
            if (a.ID < b.ID)
                id = a.ID.ToString() + ":" + b.ID.ToString();
            else
                id = b.ID.ToString() + ":" + a.ID.ToString();
        }

        //Properties
        public string ID
        { get { return id; } }
        public Neuron A
        {
            get { return a; }
        }
        public Neuron B
        {
            get { return b; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //Support
        public override string ToString()
        {
            return id + " " + Weight.ToString("F3");
        }
    }

    public static class TrainingData
    {
        //Training Data
        public static double[][] trainingDataInputs = new double[][] {
                                    //  H    K    G    E 
                        new double[] { 2.0, 0.0, 0.0, 0.0 },
                        new double[] { 2.0, 0.0, 0.0, 1.0 },
                        new double[] { 2.0, 0.0, 1.0, 1.0 },
                        new double[] { 2.0, 0.0, 1.0, 2.0 },
                        new double[] { 2.0, 1.0, 0.0, 2.0 },

                        new double[] { 2.0, 1.0, 0.0, 1.0 },
                        new double[] { 1.0, 0.0, 0.0, 0.0 },
                        new double[] { 1.0, 0.0, 0.0, 1.0 },
                        new double[] { 1.0, 0.0, 1.0, 1.0 },
                        new double[] { 1.0, 0.0, 1.0, 2.0 },

                        new double[] { 1.0, 1.0, 0.0, 2.0 },
                        new double[] { 1.0, 1.0, 0.0, 1.0 },
                        new double[] { 0.0, 0.0, 0.0, 0.0 },
                        new double[] { 0.0, 0.0, 0.0, 1.0 },
                        new double[] { 0.0, 0.0, 1.0, 1.0 },

                        new double[] { 0.0, 0.0, 1.0, 2.0 },
                        new double[] { 0.0, 1.0, 0.0, 2.0 },
                        new double[] { 0.0, 1.0, 0.0, 1.0 }
        };
        public static double[][] trainingDataTargets = new double[][] {
                                     //A    R    W    H
                        new double[] {0.0, 0.0, 1.0, 0.0},
                        new double[] {0.0, 0.0, 1.0, 0.0},
                        new double[] {1.0, 0.0, 0.0, 0.0},
                        new double[] {1.0, 0.0, 0.0, 0.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},

                        new double[] {1.0, 0.0, 0.0, 0.0},
                        new double[] {0.0, 0.0, 1.0, 0.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},
                        new double[] {1.0, 0.0, 0.0, 0.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},

                        new double[] {0.0, 0.0, 0.0, 1.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},
                        new double[] {0.0, 0.0, 1.0, 0.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},

                        new double[] {0.0, 1.0, 0.0, 0.0},
                        new double[] {0.0, 1.0, 0.0, 0.0},
                        new double[] {0.0, 0.0, 0.0, 1.0}
        };

        //Confirmation Data
        public static double[][] confirmationDataInputs = new double[][] {
                                    //  H    K    G    E 
                        new double[] { 2.0, 1.0, 1.0, 1.0 },
                        new double[] { 1.0, 1.0, 1.0, 2.0 },
                        new double[] { 0.0, 0.0, 0.0, 0.0 },
                        new double[] { 0.0, 1.0, 1.0, 1.0 },
                        new double[] { 2.0, 0.0, 1.0, 3.0 },
                        new double[] { 2.0, 1.0, 0.0, 3.0 },
                        new double[] { 0.0, 1.0, 0.0, 3.0 }
        };
        public static double[][] confirmationDataTargets = new double[][] {
                                     //A    R    W    H
                        new double[] {1.0, 0.0, 0.0, 0.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},
                        new double[] {0.0, 0.0, 1.0, 0.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},
                        new double[] {0.0, 0.0, 0.0, 1.0},
                        new double[] {0.0, 1.0, 0.0, 0.0},
        };

        //Methods
        public static string outputToText(double[] output)
        {
            switch (Array.IndexOf(output, output.Max()))
            {
                case 0:
                    return "Attack";
                case 1:
                    return "Run";
                case 2:
                    return "Wander";
                case 3:
                    return "Hide";
                default:
                    return "unknown";
            }
        }
    }
}
