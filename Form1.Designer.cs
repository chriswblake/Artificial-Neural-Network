namespace Ch5_ANN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelHidden;
            System.Windows.Forms.Label labelInput;
            System.Windows.Forms.Label labelOutput;
            System.Windows.Forms.Label labelCycles;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label labelAdjust;
            System.Windows.Forms.Label labelHealth;
            System.Windows.Forms.Label labelKnife;
            System.Windows.Forms.Label labelGun;
            System.Windows.Forms.Label labelAction;
            System.Windows.Forms.Label labelEnemies;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label labMaxError;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 2D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "1,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "2,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "3,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "4,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "1,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "2,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "3,0");
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(50D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(100D, 100D);
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.chartNetwork = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panControls = new System.Windows.Forms.Panel();
            this.tablePanelUseNetwork = new System.Windows.Forms.TableLayoutPanel();
            this.tbEnemies = new System.Windows.Forms.TextBox();
            this.tbGun = new System.Windows.Forms.TextBox();
            this.tbKnife = new System.Windows.Forms.TextBox();
            this.tbAction = new System.Windows.Forms.TextBox();
            this.tbHealth = new System.Windows.Forms.TextBox();
            this.tablePanelAdjustNetwork = new System.Windows.Forms.TableLayoutPanel();
            this.tbMaxError = new System.Windows.Forms.TextBox();
            this.chbClearMSE = new System.Windows.Forms.CheckBox();
            this.tbLearningRate = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.tbOutputNodes = new System.Windows.Forms.TextBox();
            this.tbCycles = new System.Windows.Forms.TextBox();
            this.tbInputNodes = new System.Windows.Forms.TextBox();
            this.tbHiddenNodes = new System.Windows.Forms.TextBox();
            this.tbResults = new System.Windows.Forms.TextBox();
            labelHidden = new System.Windows.Forms.Label();
            labelInput = new System.Windows.Forms.Label();
            labelOutput = new System.Windows.Forms.Label();
            labelCycles = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelAdjust = new System.Windows.Forms.Label();
            labelHealth = new System.Windows.Forms.Label();
            labelKnife = new System.Windows.Forms.Label();
            labelGun = new System.Windows.Forms.Label();
            labelAction = new System.Windows.Forms.Label();
            labelEnemies = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labMaxError = new System.Windows.Forms.Label();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNetwork)).BeginInit();
            this.panControls.SuspendLayout();
            this.tablePanelUseNetwork.SuspendLayout();
            this.tablePanelAdjustNetwork.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHidden
            // 
            labelHidden.AutoSize = true;
            labelHidden.Dock = System.Windows.Forms.DockStyle.Fill;
            labelHidden.Location = new System.Drawing.Point(3, 51);
            labelHidden.Name = "labelHidden";
            labelHidden.Size = new System.Drawing.Size(75, 26);
            labelHidden.TabIndex = 1;
            labelHidden.Text = "Hidden Nodes";
            labelHidden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            labelInput.Location = new System.Drawing.Point(3, 25);
            labelInput.Name = "labelInput";
            labelInput.Size = new System.Drawing.Size(75, 26);
            labelInput.TabIndex = 4;
            labelInput.Text = "Input Nodes";
            labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            labelOutput.Location = new System.Drawing.Point(3, 77);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new System.Drawing.Size(75, 26);
            labelOutput.TabIndex = 6;
            labelOutput.Text = "Output Nodes";
            labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCycles
            // 
            labelCycles.AutoSize = true;
            labelCycles.Dock = System.Windows.Forms.DockStyle.Fill;
            labelCycles.Location = new System.Drawing.Point(3, 159);
            labelCycles.Name = "labelCycles";
            labelCycles.Size = new System.Drawing.Size(75, 26);
            labelCycles.TabIndex = 11;
            labelCycles.Text = "Max Cycles";
            labelCycles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 26);
            label1.TabIndex = 14;
            label1.Text = "Learning Rate";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAdjust
            // 
            labelAdjust.AutoSize = true;
            this.tablePanelAdjustNetwork.SetColumnSpan(labelAdjust, 2);
            labelAdjust.Dock = System.Windows.Forms.DockStyle.Fill;
            labelAdjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAdjust.Location = new System.Drawing.Point(3, 0);
            labelAdjust.Name = "labelAdjust";
            labelAdjust.Size = new System.Drawing.Size(181, 25);
            labelAdjust.TabIndex = 8;
            labelAdjust.Text = "Adjust Network";
            // 
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            labelHealth.Location = new System.Drawing.Point(3, 25);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new System.Drawing.Size(81, 26);
            labelHealth.TabIndex = 1;
            labelHealth.Text = "Health (#>0)";
            labelHealth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelKnife
            // 
            labelKnife.AutoSize = true;
            labelKnife.Dock = System.Windows.Forms.DockStyle.Fill;
            labelKnife.Location = new System.Drawing.Point(3, 51);
            labelKnife.Name = "labelKnife";
            labelKnife.Size = new System.Drawing.Size(81, 26);
            labelKnife.TabIndex = 2;
            labelKnife.Text = "Knife (1,0)";
            labelKnife.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGun
            // 
            labelGun.AutoSize = true;
            labelGun.Dock = System.Windows.Forms.DockStyle.Fill;
            labelGun.Location = new System.Drawing.Point(3, 77);
            labelGun.Name = "labelGun";
            labelGun.Size = new System.Drawing.Size(81, 26);
            labelGun.TabIndex = 3;
            labelGun.Text = "Gun (1,0)";
            labelGun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAction
            // 
            labelAction.AutoSize = true;
            labelAction.Dock = System.Windows.Forms.DockStyle.Fill;
            labelAction.Location = new System.Drawing.Point(3, 139);
            labelAction.Name = "labelAction";
            labelAction.Size = new System.Drawing.Size(81, 26);
            labelAction.TabIndex = 4;
            labelAction.Text = "Action";
            labelAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEnemies
            // 
            labelEnemies.AutoSize = true;
            labelEnemies.Dock = System.Windows.Forms.DockStyle.Fill;
            labelEnemies.Location = new System.Drawing.Point(3, 103);
            labelEnemies.Name = "labelEnemies";
            labelEnemies.Size = new System.Drawing.Size(81, 26);
            labelEnemies.TabIndex = 5;
            labelEnemies.Text = "Enemies (#>=0)";
            labelEnemies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            this.tablePanelUseNetwork.SetColumnSpan(label2, 2);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(187, 25);
            label2.TabIndex = 12;
            label2.Text = "Use Network";
            // 
            // labMaxError
            // 
            labMaxError.AutoSize = true;
            labMaxError.Dock = System.Windows.Forms.DockStyle.Fill;
            labMaxError.Location = new System.Drawing.Point(3, 185);
            labMaxError.Name = "labMaxError";
            labMaxError.Size = new System.Drawing.Size(75, 26);
            labMaxError.TabIndex = 15;
            labMaxError.Text = "Max Error";
            labMaxError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 3;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutMain.Controls.Add(this.chartNetwork, 1, 0);
            this.layoutMain.Controls.Add(this.panControls, 0, 0);
            this.layoutMain.Controls.Add(this.tbResults, 2, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 1;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(1798, 985);
            this.layoutMain.TabIndex = 1;
            // 
            // chartNetwork
            // 
            this.chartNetwork.BackColor = System.Drawing.Color.Transparent;
            this.chartNetwork.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartNetwork.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.Title = "Cycle";
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.Title = "MSE (Mean Square Error)";
            chartArea2.Name = "chartAreaMSE";
            this.chartNetwork.ChartAreas.Add(chartArea1);
            this.chartNetwork.ChartAreas.Add(chartArea2);
            this.chartNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.DockedToChartArea = "chartAreaMSE";
            legend1.MaximumAutoSize = 100F;
            legend1.Name = "Legend1";
            this.chartNetwork.Legends.Add(legend1);
            this.chartNetwork.Location = new System.Drawing.Point(303, 3);
            this.chartNetwork.Name = "chartNetwork";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Black;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Connections";
            dataPoint3.IsEmpty = true;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.CustomProperties = "LabelStyle=Center";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.MarkerColor = System.Drawing.Color.Silver;
            series2.MarkerSize = 20;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Nodes";
            dataPoint6.Label = "1";
            dataPoint7.Label = "2";
            dataPoint8.Label = "3";
            dataPoint9.Label = "4";
            dataPoint10.Label = "5";
            dataPoint11.Label = "6";
            dataPoint12.Label = "7";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "chartAreaMSE";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Black;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "MSE";
            dataPoint13.IsEmpty = true;
            dataPoint14.IsEmpty = true;
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            this.chartNetwork.Series.Add(series1);
            this.chartNetwork.Series.Add(series2);
            this.chartNetwork.Series.Add(series3);
            this.chartNetwork.Size = new System.Drawing.Size(836, 979);
            this.chartNetwork.TabIndex = 0;
            this.chartNetwork.TabStop = false;
            this.chartNetwork.Text = "chart1";
            // 
            // panControls
            // 
            this.panControls.Controls.Add(this.tablePanelUseNetwork);
            this.panControls.Controls.Add(this.tablePanelAdjustNetwork);
            this.panControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panControls.Location = new System.Drawing.Point(3, 3);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(294, 803);
            this.panControls.TabIndex = 1;
            // 
            // tablePanelUseNetwork
            // 
            this.tablePanelUseNetwork.AutoSize = true;
            this.tablePanelUseNetwork.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanelUseNetwork.ColumnCount = 2;
            this.tablePanelUseNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelUseNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelUseNetwork.Controls.Add(label2, 0, 0);
            this.tablePanelUseNetwork.Controls.Add(this.tbEnemies, 1, 4);
            this.tablePanelUseNetwork.Controls.Add(this.tbGun, 1, 3);
            this.tablePanelUseNetwork.Controls.Add(this.tbKnife, 1, 2);
            this.tablePanelUseNetwork.Controls.Add(labelAction, 0, 6);
            this.tablePanelUseNetwork.Controls.Add(labelKnife, 0, 2);
            this.tablePanelUseNetwork.Controls.Add(labelHealth, 0, 1);
            this.tablePanelUseNetwork.Controls.Add(labelGun, 0, 3);
            this.tablePanelUseNetwork.Controls.Add(labelEnemies, 0, 4);
            this.tablePanelUseNetwork.Controls.Add(this.tbAction, 0, 6);
            this.tablePanelUseNetwork.Controls.Add(this.tbHealth, 1, 1);
            this.tablePanelUseNetwork.Location = new System.Drawing.Point(9, 496);
            this.tablePanelUseNetwork.Name = "tablePanelUseNetwork";
            this.tablePanelUseNetwork.RowCount = 7;
            this.tablePanelUseNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelUseNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelUseNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelUseNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelUseNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelUseNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tablePanelUseNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelUseNetwork.Size = new System.Drawing.Size(193, 165);
            this.tablePanelUseNetwork.TabIndex = 11;
            // 
            // tbEnemies
            // 
            this.tbEnemies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEnemies.Location = new System.Drawing.Point(90, 106);
            this.tbEnemies.MaxLength = 2;
            this.tbEnemies.Name = "tbEnemies";
            this.tbEnemies.Size = new System.Drawing.Size(100, 20);
            this.tbEnemies.TabIndex = 8;
            this.tbEnemies.Text = "1";
            this.tbEnemies.TextChanged += new System.EventHandler(this.tbUseNetwork_TextChanged);
            // 
            // tbGun
            // 
            this.tbGun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGun.Location = new System.Drawing.Point(90, 80);
            this.tbGun.MaxLength = 1;
            this.tbGun.Name = "tbGun";
            this.tbGun.Size = new System.Drawing.Size(100, 20);
            this.tbGun.TabIndex = 7;
            this.tbGun.Text = "1";
            this.tbGun.TextChanged += new System.EventHandler(this.tbUseNetwork_TextChanged);
            // 
            // tbKnife
            // 
            this.tbKnife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKnife.Location = new System.Drawing.Point(90, 54);
            this.tbKnife.MaxLength = 1;
            this.tbKnife.Name = "tbKnife";
            this.tbKnife.Size = new System.Drawing.Size(100, 20);
            this.tbKnife.TabIndex = 6;
            this.tbKnife.Text = "1";
            this.tbKnife.TextChanged += new System.EventHandler(this.tbUseNetwork_TextChanged);
            // 
            // tbAction
            // 
            this.tbAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAction.Location = new System.Drawing.Point(90, 142);
            this.tbAction.MaxLength = 10;
            this.tbAction.Name = "tbAction";
            this.tbAction.ReadOnly = true;
            this.tbAction.Size = new System.Drawing.Size(100, 20);
            this.tbAction.TabIndex = 9;
            // 
            // tbHealth
            // 
            this.tbHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHealth.Location = new System.Drawing.Point(90, 28);
            this.tbHealth.MaxLength = 2;
            this.tbHealth.Name = "tbHealth";
            this.tbHealth.Size = new System.Drawing.Size(100, 20);
            this.tbHealth.TabIndex = 5;
            this.tbHealth.Text = "2";
            this.tbHealth.TextChanged += new System.EventHandler(this.tbUseNetwork_TextChanged);
            // 
            // tablePanelAdjustNetwork
            // 
            this.tablePanelAdjustNetwork.AutoSize = true;
            this.tablePanelAdjustNetwork.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanelAdjustNetwork.ColumnCount = 2;
            this.tablePanelAdjustNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelAdjustNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelAdjustNetwork.Controls.Add(this.tbMaxError, 1, 7);
            this.tablePanelAdjustNetwork.Controls.Add(labMaxError, 0, 7);
            this.tablePanelAdjustNetwork.Controls.Add(this.chbClearMSE, 0, 9);
            this.tablePanelAdjustNetwork.Controls.Add(this.tbLearningRate, 1, 5);
            this.tablePanelAdjustNetwork.Controls.Add(labelAdjust, 0, 0);
            this.tablePanelAdjustNetwork.Controls.Add(this.btnTrain, 0, 8);
            this.tablePanelAdjustNetwork.Controls.Add(label1, 0, 5);
            this.tablePanelAdjustNetwork.Controls.Add(labelInput, 0, 1);
            this.tablePanelAdjustNetwork.Controls.Add(labelCycles, 0, 6);
            this.tablePanelAdjustNetwork.Controls.Add(this.tbOutputNodes, 1, 3);
            this.tablePanelAdjustNetwork.Controls.Add(this.tbCycles, 1, 6);
            this.tablePanelAdjustNetwork.Controls.Add(labelOutput, 0, 3);
            this.tablePanelAdjustNetwork.Controls.Add(this.tbInputNodes, 1, 1);
            this.tablePanelAdjustNetwork.Controls.Add(this.tbHiddenNodes, 1, 2);
            this.tablePanelAdjustNetwork.Controls.Add(labelHidden, 0, 2);
            this.tablePanelAdjustNetwork.Location = new System.Drawing.Point(9, 9);
            this.tablePanelAdjustNetwork.Name = "tablePanelAdjustNetwork";
            this.tablePanelAdjustNetwork.RowCount = 10;
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAdjustNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelAdjustNetwork.Size = new System.Drawing.Size(187, 290);
            this.tablePanelAdjustNetwork.TabIndex = 7;
            // 
            // tbMaxError
            // 
            this.tbMaxError.Location = new System.Drawing.Point(84, 188);
            this.tbMaxError.Name = "tbMaxError";
            this.tbMaxError.Size = new System.Drawing.Size(100, 20);
            this.tbMaxError.TabIndex = 13;
            this.tbMaxError.Text = "0.1";
            // 
            // chbClearMSE
            // 
            this.chbClearMSE.AutoSize = true;
            this.tablePanelAdjustNetwork.SetColumnSpan(this.chbClearMSE, 2);
            this.chbClearMSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbClearMSE.Location = new System.Drawing.Point(3, 260);
            this.chbClearMSE.Name = "chbClearMSE";
            this.chbClearMSE.Size = new System.Drawing.Size(181, 27);
            this.chbClearMSE.TabIndex = 4;
            this.chbClearMSE.Text = "Clear MSE Chart";
            this.chbClearMSE.UseVisualStyleBackColor = true;
            // 
            // tbLearningRate
            // 
            this.tbLearningRate.Location = new System.Drawing.Point(84, 136);
            this.tbLearningRate.Name = "tbLearningRate";
            this.tbLearningRate.Size = new System.Drawing.Size(100, 20);
            this.tbLearningRate.TabIndex = 1;
            this.tbLearningRate.Text = "0.1";
            // 
            // btnTrain
            // 
            this.tablePanelAdjustNetwork.SetColumnSpan(this.btnTrain, 2);
            this.btnTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrain.Location = new System.Drawing.Point(3, 214);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(181, 40);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // tbOutputNodes
            // 
            this.tbOutputNodes.Location = new System.Drawing.Point(84, 80);
            this.tbOutputNodes.Name = "tbOutputNodes";
            this.tbOutputNodes.ReadOnly = true;
            this.tbOutputNodes.Size = new System.Drawing.Size(100, 20);
            this.tbOutputNodes.TabIndex = 5;
            this.tbOutputNodes.TabStop = false;
            this.tbOutputNodes.Text = "4";
            this.tbOutputNodes.TextChanged += new System.EventHandler(this.tbNodes_TextChanged);
            // 
            // tbCycles
            // 
            this.tbCycles.Location = new System.Drawing.Point(84, 162);
            this.tbCycles.Name = "tbCycles";
            this.tbCycles.Size = new System.Drawing.Size(100, 20);
            this.tbCycles.TabIndex = 2;
            this.tbCycles.Text = "100";
            // 
            // tbInputNodes
            // 
            this.tbInputNodes.Location = new System.Drawing.Point(84, 28);
            this.tbInputNodes.Name = "tbInputNodes";
            this.tbInputNodes.ReadOnly = true;
            this.tbInputNodes.Size = new System.Drawing.Size(100, 20);
            this.tbInputNodes.TabIndex = 3;
            this.tbInputNodes.TabStop = false;
            this.tbInputNodes.Text = "4";
            this.tbInputNodes.TextChanged += new System.EventHandler(this.tbNodes_TextChanged);
            // 
            // tbHiddenNodes
            // 
            this.tbHiddenNodes.Location = new System.Drawing.Point(84, 54);
            this.tbHiddenNodes.Name = "tbHiddenNodes";
            this.tbHiddenNodes.Size = new System.Drawing.Size(100, 20);
            this.tbHiddenNodes.TabIndex = 0;
            this.tbHiddenNodes.Text = "3";
            this.tbHiddenNodes.TextChanged += new System.EventHandler(this.tbNodes_TextChanged);
            // 
            // tbResults
            // 
            this.tbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResults.Location = new System.Drawing.Point(1145, 3);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResults.Size = new System.Drawing.Size(650, 979);
            this.tbResults.TabIndex = 2;
            this.tbResults.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1798, 985);
            this.Controls.Add(this.layoutMain);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ch5 - Artificial Neural Network";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNetwork)).EndInit();
            this.panControls.ResumeLayout(false);
            this.panControls.PerformLayout();
            this.tablePanelUseNetwork.ResumeLayout(false);
            this.tablePanelUseNetwork.PerformLayout();
            this.tablePanelAdjustNetwork.ResumeLayout(false);
            this.tablePanelAdjustNetwork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNetwork;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.TextBox tbHiddenNodes;
        private System.Windows.Forms.TextBox tbOutputNodes;
        private System.Windows.Forms.TextBox tbInputNodes;
        private System.Windows.Forms.TableLayoutPanel tablePanelAdjustNetwork;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.TextBox tbCycles;
        private System.Windows.Forms.TextBox tbLearningRate;
        private System.Windows.Forms.CheckBox chbClearMSE;
        private System.Windows.Forms.TableLayoutPanel tablePanelUseNetwork;
        private System.Windows.Forms.TextBox tbAction;
        private System.Windows.Forms.TextBox tbEnemies;
        private System.Windows.Forms.TextBox tbGun;
        private System.Windows.Forms.TextBox tbKnife;
        private System.Windows.Forms.TextBox tbHealth;
        private System.Windows.Forms.TextBox tbMaxError;
    }
}

