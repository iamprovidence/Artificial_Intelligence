namespace Salesman_tour
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Map = new System.Windows.Forms.Panel();
            this.CityTrackBar = new System.Windows.Forms.TrackBar();
            this.StartBtn = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.CityToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GenerationToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.IndividualToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CostToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CityAmountLbl = new System.Windows.Forms.Label();
            this.PopulationSizeLbl = new System.Windows.Forms.Label();
            this.PopulationTrackBar = new System.Windows.Forms.TrackBar();
            this.VisibleCityAmountLbl = new System.Windows.Forms.Label();
            this.VisiblePopulationSizeLbl = new System.Windows.Forms.Label();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.ChildrenAmountLbl = new System.Windows.Forms.Label();
            this.ChildrenTrackBar = new System.Windows.Forms.TrackBar();
            this.VisibleChildrenAmountLbl = new System.Windows.Forms.Label();
            this.MutationTrackBar = new System.Windows.Forms.TrackBar();
            this.MutationRateLbl = new System.Windows.Forms.Label();
            this.VisibleMutationRateLbl = new System.Windows.Forms.Label();
            this.GenerationLbl = new System.Windows.Forms.Label();
            this.VisibleGenerationLbl = new System.Windows.Forms.Label();
            this.GenerationTrackBar = new System.Windows.Forms.TrackBar();
            this.DelayTrackBar = new System.Windows.Forms.TrackBar();
            this.DelayLbl = new System.Windows.Forms.Label();
            this.VisibleDelayLbl = new System.Windows.Forms.Label();
            this.OneInGenerationCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.EvaluateBtn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StartCityUpDown = new System.Windows.Forms.NumericUpDown();
            this.DistanceToolStripStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CityTrackBar)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Map.BackColor = System.Drawing.SystemColors.Window;
            this.Map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Map.Location = new System.Drawing.Point(12, 25);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(426, 251);
            this.Map.TabIndex = 0;
            this.toolTip.SetToolTip(this.Map, "Click: choose city for evaluating\r\nDoubleClick: place new city");
            this.Map.SizeChanged += new System.EventHandler(this.Map_Resize);
            this.Map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            this.Map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChooseCityMap_MouseDown);
            this.Map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SetNewCityMap_MouseDown);
            this.Map.Resize += new System.EventHandler(this.Map_Resize);
            // 
            // CityTrackBar
            // 
            this.CityTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTrackBar.Location = new System.Drawing.Point(468, 44);
            this.CityTrackBar.Maximum = 100;
            this.CityTrackBar.Minimum = 3;
            this.CityTrackBar.Name = "CityTrackBar";
            this.CityTrackBar.Size = new System.Drawing.Size(165, 45);
            this.CityTrackBar.TabIndex = 1;
            this.CityTrackBar.Value = 5;
            this.CityTrackBar.Scroll += new System.EventHandler(this.CityTrackBar_Scroll);
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.Location = new System.Drawing.Point(607, 231);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(86, 45);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CityToolStripStatusLabel,
            this.GenerationToolStripStatusLabel,
            this.IndividualToolStripStatusLabel,
            this.CostToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 295);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(824, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // CityToolStripStatusLabel
            // 
            this.CityToolStripStatusLabel.Name = "CityToolStripStatusLabel";
            this.CityToolStripStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.CityToolStripStatusLabel.Text = "city = 5";
            // 
            // GenerationToolStripStatusLabel
            // 
            this.GenerationToolStripStatusLabel.Name = "GenerationToolStripStatusLabel";
            this.GenerationToolStripStatusLabel.Size = new System.Drawing.Size(84, 17);
            this.GenerationToolStripStatusLabel.Text = "generation = 0";
            // 
            // IndividualToolStripStatusLabel
            // 
            this.IndividualToolStripStatusLabel.Name = "IndividualToolStripStatusLabel";
            this.IndividualToolStripStatusLabel.Size = new System.Drawing.Size(79, 17);
            this.IndividualToolStripStatusLabel.Text = "individual = 0";
            // 
            // CostToolStripStatusLabel
            // 
            this.CostToolStripStatusLabel.Name = "CostToolStripStatusLabel";
            this.CostToolStripStatusLabel.Size = new System.Drawing.Size(49, 17);
            this.CostToolStripStatusLabel.Text = "cost = 0";
            // 
            // CityAmountLbl
            // 
            this.CityAmountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityAmountLbl.AutoSize = true;
            this.CityAmountLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this.CityAmountLbl.Location = new System.Drawing.Point(465, 25);
            this.CityAmountLbl.Name = "CityAmountLbl";
            this.CityAmountLbl.Size = new System.Drawing.Size(63, 13);
            this.CityAmountLbl.TabIndex = 4;
            this.CityAmountLbl.Text = "City Amount";
            this.toolTip.SetToolTip(this.CityAmountLbl, "Determines the number of cities on the map that should be bypassed");
            // 
            // PopulationSizeLbl
            // 
            this.PopulationSizeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopulationSizeLbl.AutoSize = true;
            this.PopulationSizeLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this.PopulationSizeLbl.Location = new System.Drawing.Point(465, 82);
            this.PopulationSizeLbl.Name = "PopulationSizeLbl";
            this.PopulationSizeLbl.Size = new System.Drawing.Size(80, 13);
            this.PopulationSizeLbl.TabIndex = 5;
            this.PopulationSizeLbl.Text = "Population Size";
            this.toolTip.SetToolTip(this.PopulationSizeLbl, "Determines population size after selection");
            // 
            // PopulationTrackBar
            // 
            this.PopulationTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopulationTrackBar.Location = new System.Drawing.Point(468, 105);
            this.PopulationTrackBar.Maximum = 25;
            this.PopulationTrackBar.Minimum = 2;
            this.PopulationTrackBar.Name = "PopulationTrackBar";
            this.PopulationTrackBar.Size = new System.Drawing.Size(165, 45);
            this.PopulationTrackBar.TabIndex = 6;
            this.PopulationTrackBar.Value = 10;
            this.PopulationTrackBar.Scroll += new System.EventHandler(this.PopulationTrackBar_Scroll);
            // 
            // VisibleCityAmountLbl
            // 
            this.VisibleCityAmountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisibleCityAmountLbl.AutoSize = true;
            this.VisibleCityAmountLbl.Location = new System.Drawing.Point(611, 25);
            this.VisibleCityAmountLbl.Name = "VisibleCityAmountLbl";
            this.VisibleCityAmountLbl.Size = new System.Drawing.Size(13, 13);
            this.VisibleCityAmountLbl.TabIndex = 7;
            this.VisibleCityAmountLbl.Text = "5";
            // 
            // VisiblePopulationSizeLbl
            // 
            this.VisiblePopulationSizeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisiblePopulationSizeLbl.AutoSize = true;
            this.VisiblePopulationSizeLbl.Location = new System.Drawing.Point(611, 82);
            this.VisiblePopulationSizeLbl.Name = "VisiblePopulationSizeLbl";
            this.VisiblePopulationSizeLbl.Size = new System.Drawing.Size(19, 13);
            this.VisiblePopulationSizeLbl.TabIndex = 8;
            this.VisiblePopulationSizeLbl.Text = "10";
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateBtn.Location = new System.Drawing.Point(468, 231);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(126, 45);
            this.GenerateBtn.TabIndex = 9;
            this.GenerateBtn.Text = "generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateNewBtn_Click);
            // 
            // ChildrenAmountLbl
            // 
            this.ChildrenAmountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChildrenAmountLbl.AutoSize = true;
            this.ChildrenAmountLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this.ChildrenAmountLbl.Location = new System.Drawing.Point(641, 25);
            this.ChildrenAmountLbl.Name = "ChildrenAmountLbl";
            this.ChildrenAmountLbl.Size = new System.Drawing.Size(84, 13);
            this.ChildrenAmountLbl.TabIndex = 10;
            this.ChildrenAmountLbl.Text = "Children Amount";
            this.toolTip.SetToolTip(this.ChildrenAmountLbl, "Determines the number of children per individual");
            // 
            // ChildrenTrackBar
            // 
            this.ChildrenTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChildrenTrackBar.Location = new System.Drawing.Point(647, 44);
            this.ChildrenTrackBar.Maximum = 50;
            this.ChildrenTrackBar.Minimum = 1;
            this.ChildrenTrackBar.Name = "ChildrenTrackBar";
            this.ChildrenTrackBar.Size = new System.Drawing.Size(165, 45);
            this.ChildrenTrackBar.TabIndex = 11;
            this.ChildrenTrackBar.Value = 20;
            this.ChildrenTrackBar.Scroll += new System.EventHandler(this.ChildrenTrackBar_Scroll);
            // 
            // VisibleChildrenAmountLbl
            // 
            this.VisibleChildrenAmountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisibleChildrenAmountLbl.AutoSize = true;
            this.VisibleChildrenAmountLbl.Location = new System.Drawing.Point(785, 25);
            this.VisibleChildrenAmountLbl.Name = "VisibleChildrenAmountLbl";
            this.VisibleChildrenAmountLbl.Size = new System.Drawing.Size(19, 13);
            this.VisibleChildrenAmountLbl.TabIndex = 12;
            this.VisibleChildrenAmountLbl.Text = "20";
            // 
            // MutationTrackBar
            // 
            this.MutationTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MutationTrackBar.Location = new System.Drawing.Point(647, 105);
            this.MutationTrackBar.Maximum = 50;
            this.MutationTrackBar.Minimum = 1;
            this.MutationTrackBar.Name = "MutationTrackBar";
            this.MutationTrackBar.Size = new System.Drawing.Size(165, 45);
            this.MutationTrackBar.TabIndex = 13;
            this.MutationTrackBar.Value = 5;
            this.MutationTrackBar.Scroll += new System.EventHandler(this.MutationTrackBar_Scroll);
            this.MutationTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MutationTrackBar_MouseUp);
            // 
            // MutationRateLbl
            // 
            this.MutationRateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MutationRateLbl.AutoSize = true;
            this.MutationRateLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this.MutationRateLbl.Location = new System.Drawing.Point(641, 82);
            this.MutationRateLbl.Name = "MutationRateLbl";
            this.MutationRateLbl.Size = new System.Drawing.Size(74, 13);
            this.MutationRateLbl.TabIndex = 14;
            this.MutationRateLbl.Text = "Mutation Rate";
            this.toolTip.SetToolTip(this.MutationRateLbl, "Number of differences in descendants\r\nBe aware: does not affect the quality or sp" +
        "eed of the solution\r\n");
            // 
            // VisibleMutationRateLbl
            // 
            this.VisibleMutationRateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisibleMutationRateLbl.AutoSize = true;
            this.VisibleMutationRateLbl.Location = new System.Drawing.Point(785, 82);
            this.VisibleMutationRateLbl.Name = "VisibleMutationRateLbl";
            this.VisibleMutationRateLbl.Size = new System.Drawing.Size(13, 13);
            this.VisibleMutationRateLbl.TabIndex = 15;
            this.VisibleMutationRateLbl.Text = "5";
            // 
            // GenerationLbl
            // 
            this.GenerationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerationLbl.AutoSize = true;
            this.GenerationLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this.GenerationLbl.Location = new System.Drawing.Point(644, 144);
            this.GenerationLbl.Name = "GenerationLbl";
            this.GenerationLbl.Size = new System.Drawing.Size(82, 13);
            this.GenerationLbl.TabIndex = 16;
            this.GenerationLbl.Text = "Max Generation";
            this.toolTip.SetToolTip(this.GenerationLbl, "The number of generations during which there will be a selection of the best");
            // 
            // VisibleGenerationLbl
            // 
            this.VisibleGenerationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisibleGenerationLbl.AutoSize = true;
            this.VisibleGenerationLbl.Location = new System.Drawing.Point(785, 144);
            this.VisibleGenerationLbl.Name = "VisibleGenerationLbl";
            this.VisibleGenerationLbl.Size = new System.Drawing.Size(19, 13);
            this.VisibleGenerationLbl.TabIndex = 17;
            this.VisibleGenerationLbl.Text = "50";
            // 
            // GenerationTrackBar
            // 
            this.GenerationTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerationTrackBar.Location = new System.Drawing.Point(647, 160);
            this.GenerationTrackBar.Maximum = 500;
            this.GenerationTrackBar.Minimum = 1;
            this.GenerationTrackBar.Name = "GenerationTrackBar";
            this.GenerationTrackBar.Size = new System.Drawing.Size(165, 45);
            this.GenerationTrackBar.TabIndex = 18;
            this.GenerationTrackBar.Value = 50;
            this.GenerationTrackBar.Scroll += new System.EventHandler(this.GenerationTrackBar_Scroll);
            // 
            // DelayTrackBar
            // 
            this.DelayTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayTrackBar.Location = new System.Drawing.Point(468, 160);
            this.DelayTrackBar.Maximum = 25;
            this.DelayTrackBar.Name = "DelayTrackBar";
            this.DelayTrackBar.Size = new System.Drawing.Size(165, 45);
            this.DelayTrackBar.TabIndex = 19;
            this.DelayTrackBar.Value = 7;
            this.DelayTrackBar.Scroll += new System.EventHandler(this.DelayTrackBar_Scroll);
            // 
            // DelayLbl
            // 
            this.DelayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayLbl.AutoSize = true;
            this.DelayLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this.DelayLbl.Location = new System.Drawing.Point(465, 144);
            this.DelayLbl.Name = "DelayLbl";
            this.DelayLbl.Size = new System.Drawing.Size(34, 13);
            this.DelayLbl.TabIndex = 20;
            this.DelayLbl.Text = "Delay";
            this.toolTip.SetToolTip(this.DelayLbl, "Delay between generations / individuals / etc\r\nIs calculated by the formula (x * " +
        "100)ms");
            // 
            // VisibleDelayLbl
            // 
            this.VisibleDelayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisibleDelayLbl.AutoSize = true;
            this.VisibleDelayLbl.Location = new System.Drawing.Point(611, 144);
            this.VisibleDelayLbl.Name = "VisibleDelayLbl";
            this.VisibleDelayLbl.Size = new System.Drawing.Size(13, 13);
            this.VisibleDelayLbl.TabIndex = 21;
            this.VisibleDelayLbl.Text = "7";
            // 
            // OneInGenerationCheckBox
            // 
            this.OneInGenerationCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OneInGenerationCheckBox.AutoSize = true;
            this.OneInGenerationCheckBox.Checked = true;
            this.OneInGenerationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OneInGenerationCheckBox.Location = new System.Drawing.Point(539, 200);
            this.OneInGenerationCheckBox.Name = "OneInGenerationCheckBox";
            this.OneInGenerationCheckBox.Size = new System.Drawing.Size(199, 17);
            this.OneInGenerationCheckBox.TabIndex = 22;
            this.OneInGenerationCheckBox.Text = "show only the best one in generation";
            this.OneInGenerationCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Enabled = false;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(703, 231);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(95, 45);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EvaluateBtn
            // 
            this.EvaluateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EvaluateBtn.Location = new System.Drawing.Point(694, 295);
            this.EvaluateBtn.Name = "EvaluateBtn";
            this.EvaluateBtn.Size = new System.Drawing.Size(75, 23);
            this.EvaluateBtn.TabIndex = 24;
            this.EvaluateBtn.Text = "evaluate";
            this.toolTip.SetToolTip(this.EvaluateBtn, "Evaluate the best possible way with Hill Climbing method\r\n(Finds the shortest pat" +
        "h from the current city)");
            this.EvaluateBtn.UseVisualStyleBackColor = true;
            this.EvaluateBtn.Click += new System.EventHandler(this.EvaluateBtn_Click);
            // 
            // StartCityUpDown
            // 
            this.StartCityUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartCityUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartCityUpDown.Location = new System.Drawing.Point(775, 295);
            this.StartCityUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.StartCityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartCityUpDown.Name = "StartCityUpDown";
            this.StartCityUpDown.Size = new System.Drawing.Size(50, 23);
            this.StartCityUpDown.TabIndex = 27;
            this.StartCityUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.StartCityUpDown, "Choose from which cities you want to start evaluating");
            this.StartCityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartCityUpDown.ValueChanged += new System.EventHandler(this.StartCityUpDown_ValueChanged);
            // 
            // DistanceToolStripStatusLabel
            // 
            this.DistanceToolStripStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DistanceToolStripStatusLabel.Location = new System.Drawing.Point(545, 300);
            this.DistanceToolStripStatusLabel.Name = "DistanceToolStripStatusLabel";
            this.DistanceToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DistanceToolStripStatusLabel.Size = new System.Drawing.Size(148, 13);
            this.DistanceToolStripStatusLabel.TabIndex = 25;
            this.DistanceToolStripStatusLabel.Text = "###";
            this.DistanceToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AcceptButton = this.StartBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(824, 317);
            this.Controls.Add(this.StartCityUpDown);
            this.Controls.Add(this.DistanceToolStripStatusLabel);
            this.Controls.Add(this.EvaluateBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OneInGenerationCheckBox);
            this.Controls.Add(this.VisibleDelayLbl);
            this.Controls.Add(this.DelayLbl);
            this.Controls.Add(this.DelayTrackBar);
            this.Controls.Add(this.GenerationTrackBar);
            this.Controls.Add(this.VisibleGenerationLbl);
            this.Controls.Add(this.GenerationLbl);
            this.Controls.Add(this.VisibleMutationRateLbl);
            this.Controls.Add(this.MutationRateLbl);
            this.Controls.Add(this.MutationTrackBar);
            this.Controls.Add(this.VisibleChildrenAmountLbl);
            this.Controls.Add(this.ChildrenTrackBar);
            this.Controls.Add(this.ChildrenAmountLbl);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.VisiblePopulationSizeLbl);
            this.Controls.Add(this.VisibleCityAmountLbl);
            this.Controls.Add(this.PopulationTrackBar);
            this.Controls.Add(this.PopulationSizeLbl);
            this.Controls.Add(this.CityAmountLbl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.CityTrackBar);
            this.Controls.Add(this.Map);
            this.MinimumSize = new System.Drawing.Size(840, 355);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesman tour";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CityTrackBar)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Map;
        private System.Windows.Forms.TrackBar CityTrackBar;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel GenerationToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel CostToolStripStatusLabel;
        private System.Windows.Forms.Label CityAmountLbl;
        private System.Windows.Forms.Label PopulationSizeLbl;
        private System.Windows.Forms.TrackBar PopulationTrackBar;
        private System.Windows.Forms.Label VisibleCityAmountLbl;
        private System.Windows.Forms.Label VisiblePopulationSizeLbl;
        private System.Windows.Forms.ToolStripStatusLabel CityToolStripStatusLabel;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Label ChildrenAmountLbl;
        private System.Windows.Forms.TrackBar ChildrenTrackBar;
        private System.Windows.Forms.Label VisibleChildrenAmountLbl;
        private System.Windows.Forms.TrackBar MutationTrackBar;
        private System.Windows.Forms.Label MutationRateLbl;
        private System.Windows.Forms.Label VisibleMutationRateLbl;
        private System.Windows.Forms.Label GenerationLbl;
        private System.Windows.Forms.Label VisibleGenerationLbl;
        private System.Windows.Forms.TrackBar GenerationTrackBar;
        private System.Windows.Forms.TrackBar DelayTrackBar;
        private System.Windows.Forms.Label DelayLbl;
        private System.Windows.Forms.Label VisibleDelayLbl;
        private System.Windows.Forms.CheckBox OneInGenerationCheckBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ToolStripStatusLabel IndividualToolStripStatusLabel;
        private System.Windows.Forms.Button EvaluateBtn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label DistanceToolStripStatusLabel;
        private System.Windows.Forms.NumericUpDown StartCityUpDown;
    }
}

