namespace logicalOperatorsClassifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.aFuncCb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.andBtn = new System.Windows.Forms.Button();
            this.orBtn = new System.Windows.Forms.Button();
            this.xorBtn = new System.Windows.Forms.Button();
            this.xnorBtn = new System.Windows.Forms.Button();
            this.resultBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.resultGb = new System.Windows.Forms.GroupBox();
            this.resultPnl = new System.Windows.Forms.Panel();
            this.neuralNetworkGb = new System.Windows.Forms.GroupBox();
            this.neuralNetworkPnl = new System.Windows.Forms.Panel();
            this.scaleTbl = new System.Windows.Forms.TableLayoutPanel();
            this.mainTbl = new System.Windows.Forms.TableLayoutPanel();
            this.paintingTbl = new System.Windows.Forms.TableLayoutPanel();
            this.configTbl = new System.Windows.Forms.TableLayoutPanel();
            this.neuralNetworkParamTbl = new System.Windows.Forms.TableLayoutPanel();
            this.infoGb = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.inputAmountTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hiddenAmountTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputAmountTb = new System.Windows.Forms.TextBox();
            this.settingGb = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.trainingAmountTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.learningRateTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.activationTb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.randBtn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.resultGb.SuspendLayout();
            this.neuralNetworkGb.SuspendLayout();
            this.scaleTbl.SuspendLayout();
            this.mainTbl.SuspendLayout();
            this.paintingTbl.SuspendLayout();
            this.configTbl.SuspendLayout();
            this.neuralNetworkParamTbl.SuspendLayout();
            this.infoGb.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.settingGb.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // aFuncCb
            // 
            this.aFuncCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.SetFlowBreak(this.aFuncCb, true);
            this.aFuncCb.FormattingEnabled = true;
            this.aFuncCb.Location = new System.Drawing.Point(129, 29);
            this.aFuncCb.Name = "aFuncCb";
            this.aFuncCb.Size = new System.Drawing.Size(166, 21);
            this.aFuncCb.TabIndex = 1;
            this.aFuncCb.SelectedIndexChanged += new System.EventHandler(this.aFuncCb_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 112);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Train With Logical Operators";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.andBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.orBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.xorBtn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.xnorBtn, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 93);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // andBtn
            // 
            this.andBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.andBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.andBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.andBtn.Location = new System.Drawing.Point(3, 3);
            this.andBtn.Name = "andBtn";
            this.andBtn.Size = new System.Drawing.Size(145, 40);
            this.andBtn.TabIndex = 0;
            this.andBtn.Text = "AND";
            this.andBtn.UseVisualStyleBackColor = true;
            this.andBtn.Click += new System.EventHandler(this.andBtn_Click);
            // 
            // orBtn
            // 
            this.orBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orBtn.Location = new System.Drawing.Point(154, 3);
            this.orBtn.Name = "orBtn";
            this.orBtn.Size = new System.Drawing.Size(145, 40);
            this.orBtn.TabIndex = 1;
            this.orBtn.Text = "OR";
            this.orBtn.UseVisualStyleBackColor = true;
            this.orBtn.Click += new System.EventHandler(this.orBtn_Click);
            // 
            // xorBtn
            // 
            this.xorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xorBtn.Location = new System.Drawing.Point(154, 49);
            this.xorBtn.Name = "xorBtn";
            this.xorBtn.Size = new System.Drawing.Size(145, 41);
            this.xorBtn.TabIndex = 3;
            this.xorBtn.Text = "XOR";
            this.xorBtn.UseVisualStyleBackColor = true;
            this.xorBtn.Click += new System.EventHandler(this.xorBtn_Click);
            // 
            // xnorBtn
            // 
            this.xnorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xnorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xnorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xnorBtn.Location = new System.Drawing.Point(3, 49);
            this.xnorBtn.Name = "xnorBtn";
            this.xnorBtn.Size = new System.Drawing.Size(145, 41);
            this.xnorBtn.TabIndex = 2;
            this.xnorBtn.Text = "XNOR";
            this.xnorBtn.UseVisualStyleBackColor = true;
            this.xnorBtn.Click += new System.EventHandler(this.xnorBtn_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBtn.Location = new System.Drawing.Point(320, 3);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(311, 44);
            this.resultBtn.TabIndex = 4;
            this.resultBtn.Text = "show result";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(3, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(628, 40);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Train Neural Network ";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultGb
            // 
            this.resultGb.Controls.Add(this.resultPnl);
            this.resultGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultGb.Location = new System.Drawing.Point(0, 0);
            this.resultGb.Margin = new System.Windows.Forms.Padding(0);
            this.resultGb.Name = "resultGb";
            this.resultGb.Size = new System.Drawing.Size(314, 173);
            this.resultGb.TabIndex = 6;
            this.resultGb.TabStop = false;
            this.resultGb.Text = "Result";
            // 
            // resultPnl
            // 
            this.resultPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPnl.Location = new System.Drawing.Point(3, 16);
            this.resultPnl.Margin = new System.Windows.Forms.Padding(6);
            this.resultPnl.Name = "resultPnl";
            this.resultPnl.Size = new System.Drawing.Size(308, 154);
            this.resultPnl.TabIndex = 0;
            this.resultPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.resultPnl_Paint);
            // 
            // neuralNetworkGb
            // 
            this.neuralNetworkGb.Controls.Add(this.neuralNetworkPnl);
            this.neuralNetworkGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neuralNetworkGb.Location = new System.Drawing.Point(0, 173);
            this.neuralNetworkGb.Margin = new System.Windows.Forms.Padding(0);
            this.neuralNetworkGb.Name = "neuralNetworkGb";
            this.neuralNetworkGb.Size = new System.Drawing.Size(314, 173);
            this.neuralNetworkGb.TabIndex = 7;
            this.neuralNetworkGb.TabStop = false;
            this.neuralNetworkGb.Text = "Neural Network";
            // 
            // neuralNetworkPnl
            // 
            this.neuralNetworkPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neuralNetworkPnl.Location = new System.Drawing.Point(3, 16);
            this.neuralNetworkPnl.Margin = new System.Windows.Forms.Padding(6);
            this.neuralNetworkPnl.Name = "neuralNetworkPnl";
            this.neuralNetworkPnl.Size = new System.Drawing.Size(308, 154);
            this.neuralNetworkPnl.TabIndex = 0;
            this.neuralNetworkPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.neuralNetworkPnl_Paint);
            // 
            // scaleTbl
            // 
            this.scaleTbl.ColumnCount = 1;
            this.scaleTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.scaleTbl.Controls.Add(this.nameLbl, 0, 0);
            this.scaleTbl.Controls.Add(this.mainTbl, 0, 1);
            this.scaleTbl.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.scaleTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scaleTbl.Location = new System.Drawing.Point(0, 0);
            this.scaleTbl.Margin = new System.Windows.Forms.Padding(0);
            this.scaleTbl.Name = "scaleTbl";
            this.scaleTbl.RowCount = 3;
            this.scaleTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.scaleTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.scaleTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.scaleTbl.Size = new System.Drawing.Size(634, 442);
            this.scaleTbl.TabIndex = 8;
            // 
            // mainTbl
            // 
            this.mainTbl.ColumnCount = 2;
            this.mainTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTbl.Controls.Add(this.paintingTbl, 1, 0);
            this.mainTbl.Controls.Add(this.configTbl, 0, 0);
            this.mainTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTbl.Location = new System.Drawing.Point(3, 43);
            this.mainTbl.Name = "mainTbl";
            this.mainTbl.RowCount = 1;
            this.mainTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTbl.Size = new System.Drawing.Size(628, 346);
            this.mainTbl.TabIndex = 6;
            // 
            // paintingTbl
            // 
            this.paintingTbl.ColumnCount = 1;
            this.paintingTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paintingTbl.Controls.Add(this.neuralNetworkGb, 0, 1);
            this.paintingTbl.Controls.Add(this.resultGb, 0, 0);
            this.paintingTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintingTbl.Location = new System.Drawing.Point(314, 0);
            this.paintingTbl.Margin = new System.Windows.Forms.Padding(0);
            this.paintingTbl.Name = "paintingTbl";
            this.paintingTbl.RowCount = 2;
            this.paintingTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paintingTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paintingTbl.Size = new System.Drawing.Size(314, 346);
            this.paintingTbl.TabIndex = 0;
            // 
            // configTbl
            // 
            this.configTbl.ColumnCount = 1;
            this.configTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.configTbl.Controls.Add(this.groupBox2, 0, 1);
            this.configTbl.Controls.Add(this.neuralNetworkParamTbl, 0, 0);
            this.configTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configTbl.Location = new System.Drawing.Point(0, 0);
            this.configTbl.Margin = new System.Windows.Forms.Padding(0);
            this.configTbl.Name = "configTbl";
            this.configTbl.RowCount = 2;
            this.configTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.18497F));
            this.configTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.81503F));
            this.configTbl.Size = new System.Drawing.Size(314, 346);
            this.configTbl.TabIndex = 1;
            // 
            // neuralNetworkParamTbl
            // 
            this.neuralNetworkParamTbl.ColumnCount = 1;
            this.neuralNetworkParamTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.neuralNetworkParamTbl.Controls.Add(this.infoGb, 0, 0);
            this.neuralNetworkParamTbl.Controls.Add(this.settingGb, 0, 1);
            this.neuralNetworkParamTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neuralNetworkParamTbl.Location = new System.Drawing.Point(0, 0);
            this.neuralNetworkParamTbl.Margin = new System.Windows.Forms.Padding(0);
            this.neuralNetworkParamTbl.Name = "neuralNetworkParamTbl";
            this.neuralNetworkParamTbl.RowCount = 2;
            this.neuralNetworkParamTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.neuralNetworkParamTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.neuralNetworkParamTbl.Size = new System.Drawing.Size(314, 228);
            this.neuralNetworkParamTbl.TabIndex = 4;
            // 
            // infoGb
            // 
            this.infoGb.Controls.Add(this.flowLayoutPanel1);
            this.infoGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoGb.Location = new System.Drawing.Point(3, 0);
            this.infoGb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.infoGb.Name = "infoGb";
            this.infoGb.Size = new System.Drawing.Size(308, 98);
            this.infoGb.TabIndex = 4;
            this.infoGb.TabStop = false;
            this.infoGb.Text = "Info";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.inputAmountTb);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.hiddenAmountTb);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.outputAmountTb);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 79);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Neuron Amount";
            // 
            // inputAmountTb
            // 
            this.inputAmountTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFlowBreak(this.inputAmountTb, true);
            this.inputAmountTb.Location = new System.Drawing.Point(129, 3);
            this.inputAmountTb.Name = "inputAmountTb";
            this.inputAmountTb.ReadOnly = true;
            this.inputAmountTb.Size = new System.Drawing.Size(166, 20);
            this.inputAmountTb.TabIndex = 1;
            this.inputAmountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hidden Neuron Amount";
            // 
            // hiddenAmountTb
            // 
            this.hiddenAmountTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFlowBreak(this.hiddenAmountTb, true);
            this.hiddenAmountTb.Location = new System.Drawing.Point(129, 28);
            this.hiddenAmountTb.Name = "hiddenAmountTb";
            this.hiddenAmountTb.Size = new System.Drawing.Size(166, 20);
            this.hiddenAmountTb.TabIndex = 5;
            this.hiddenAmountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.hiddenAmountTb, "ex: 2 | 3 | 2");
            this.hiddenAmountTb.Validating += new System.ComponentModel.CancelEventHandler(this.hiddenAmountTb_Validating);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Neuron Amount";
            // 
            // outputAmountTb
            // 
            this.outputAmountTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFlowBreak(this.outputAmountTb, true);
            this.outputAmountTb.Location = new System.Drawing.Point(129, 53);
            this.outputAmountTb.Name = "outputAmountTb";
            this.outputAmountTb.ReadOnly = true;
            this.outputAmountTb.Size = new System.Drawing.Size(166, 20);
            this.outputAmountTb.TabIndex = 3;
            this.outputAmountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // settingGb
            // 
            this.settingGb.Controls.Add(this.flowLayoutPanel3);
            this.settingGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingGb.Location = new System.Drawing.Point(3, 101);
            this.settingGb.Name = "settingGb";
            this.settingGb.Size = new System.Drawing.Size(308, 124);
            this.settingGb.TabIndex = 3;
            this.settingGb.TabStop = false;
            this.settingGb.Text = "Setting";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.trainingAmountTb);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.aFuncCb);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.learningRateTb);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.activationTb);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(302, 105);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Training Amount";
            // 
            // trainingAmountTb
            // 
            this.flowLayoutPanel3.SetFlowBreak(this.trainingAmountTb, true);
            this.trainingAmountTb.Location = new System.Drawing.Point(129, 3);
            this.trainingAmountTb.Name = "trainingAmountTb";
            this.trainingAmountTb.Size = new System.Drawing.Size(166, 20);
            this.trainingAmountTb.TabIndex = 5;
            this.trainingAmountTb.Validating += new System.ComponentModel.CancelEventHandler(this.trainingAmountTb_Validating);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Activation Function";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Learning Rate";
            // 
            // learningRateTb
            // 
            this.learningRateTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.SetFlowBreak(this.learningRateTb, true);
            this.learningRateTb.Location = new System.Drawing.Point(129, 56);
            this.learningRateTb.Name = "learningRateTb";
            this.learningRateTb.Size = new System.Drawing.Size(166, 20);
            this.learningRateTb.TabIndex = 2;
            this.learningRateTb.Validating += new System.ComponentModel.CancelEventHandler(this.learningRateTb_Validating);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Activation";
            // 
            // activationTb
            // 
            this.activationTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.SetFlowBreak(this.activationTb, true);
            this.activationTb.Location = new System.Drawing.Point(129, 82);
            this.activationTb.Name = "activationTb";
            this.activationTb.Size = new System.Drawing.Size(166, 20);
            this.activationTb.TabIndex = 3;
            this.activationTb.Validating += new System.ComponentModel.CancelEventHandler(this.activationTb_Validating);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.resultBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.randBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 392);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(634, 50);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // randBtn
            // 
            this.randBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randBtn.Location = new System.Drawing.Point(3, 3);
            this.randBtn.Name = "randBtn";
            this.randBtn.Size = new System.Drawing.Size(311, 44);
            this.randBtn.TabIndex = 5;
            this.randBtn.Text = "randomize weight";
            this.randBtn.UseVisualStyleBackColor = true;
            this.randBtn.Click += new System.EventHandler(this.randBtn_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.resultBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 442);
            this.Controls.Add(this.scaleTbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainer";
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.resultGb.ResumeLayout(false);
            this.neuralNetworkGb.ResumeLayout(false);
            this.scaleTbl.ResumeLayout(false);
            this.scaleTbl.PerformLayout();
            this.mainTbl.ResumeLayout(false);
            this.paintingTbl.ResumeLayout(false);
            this.configTbl.ResumeLayout(false);
            this.neuralNetworkParamTbl.ResumeLayout(false);
            this.infoGb.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.settingGb.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button xorBtn;
        private System.Windows.Forms.Button xnorBtn;
        private System.Windows.Forms.Button orBtn;
        private System.Windows.Forms.Button andBtn;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.GroupBox resultGb;
        private System.Windows.Forms.GroupBox neuralNetworkGb;
        private System.Windows.Forms.ComboBox aFuncCb;
        private System.Windows.Forms.Panel resultPnl;
        private System.Windows.Forms.Panel neuralNetworkPnl;
        private System.Windows.Forms.TableLayoutPanel scaleTbl;
        private System.Windows.Forms.TableLayoutPanel mainTbl;
        private System.Windows.Forms.TableLayoutPanel paintingTbl;
        private System.Windows.Forms.TableLayoutPanel configTbl;
        private System.Windows.Forms.TableLayoutPanel neuralNetworkParamTbl;
        private System.Windows.Forms.GroupBox settingGb;
        private System.Windows.Forms.GroupBox infoGb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputAmountTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputAmountTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hiddenAmountTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox learningRateTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox activationTb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button randBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox trainingAmountTb;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

