namespace SalesManTour
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbTowns = new System.Windows.Forms.GroupBox();
            this.reGenCb = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.cmsDrawingOpt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbParameters = new System.Windows.Forms.GroupBox();
            this.nudGenMax = new System.Windows.Forms.NumericUpDown();
            this.lblGenMax = new System.Windows.Forms.Label();
            this.nudRotate = new System.Windows.Forms.NumericUpDown();
            this.lblRotate = new System.Windows.Forms.Label();
            this.nudMutate = new System.Windows.Forms.NumericUpDown();
            this.lblMutate = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.grbSolver = new System.Windows.Forms.GroupBox();
            this.nudThreads = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblGenerations = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.grbTowns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.cmsDrawingOpt.SuspendLayout();
            this.grbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.grbSolver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTowns
            // 
            this.grbTowns.Controls.Add(this.reGenCb);
            this.grbTowns.Controls.Add(this.btnGenerate);
            this.grbTowns.Controls.Add(this.nudNumber);
            this.grbTowns.Controls.Add(this.lblNumber);
            this.grbTowns.Location = new System.Drawing.Point(12, 12);
            this.grbTowns.Name = "grbTowns";
            this.grbTowns.Size = new System.Drawing.Size(153, 119);
            this.grbTowns.TabIndex = 0;
            this.grbTowns.TabStop = false;
            this.grbTowns.Text = "Міста";
            // 
            // reGenCb
            // 
            this.reGenCb.AutoSize = true;
            this.reGenCb.Location = new System.Drawing.Point(22, 50);
            this.reGenCb.Name = "reGenCb";
            this.reGenCb.Size = new System.Drawing.Size(113, 30);
            this.reGenCb.TabIndex = 3;
            this.reGenCb.Text = "Генерувати мапу\r\nпри зміні розміру";
            this.reGenCb.UseVisualStyleBackColor = true;
            this.reGenCb.CheckedChanged += new System.EventHandler(this.reGenCb_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(9, 90);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(135, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Генерувати мапу";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumber.Location = new System.Drawing.Point(87, 24);
            this.nudNumber.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(57, 20);
            this.nudNumber.TabIndex = 1;
            this.nudNumber.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 26);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(53, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Кількість";
            // 
            // pnlMap
            // 
            this.pnlMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMap.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMap.ContextMenuStrip = this.cmsDrawingOpt;
            this.pnlMap.Location = new System.Drawing.Point(171, 12);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(651, 447);
            this.pnlMap.TabIndex = 1;
            this.pnlMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMap_Paint);
            // 
            // cmsDrawingOpt
            // 
            this.cmsDrawingOpt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qualityToolStripMenuItem});
            this.cmsDrawingOpt.Name = "cmsDrawingOpt";
            this.cmsDrawingOpt.Size = new System.Drawing.Size(181, 48);
            // 
            // qualityToolStripMenuItem
            // 
            this.qualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highToolStripMenuItem,
            this.lowToolStripMenuItem});
            this.qualityToolStripMenuItem.Name = "qualityToolStripMenuItem";
            this.qualityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qualityToolStripMenuItem.Text = "Quality";
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.ToolStripQualityMenuItem_Click);
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lowToolStripMenuItem.Text = "Low";
            this.lowToolStripMenuItem.Click += new System.EventHandler(this.ToolStripQualityMenuItem_Click);
            // 
            // grbParameters
            // 
            this.grbParameters.Controls.Add(this.nudGenMax);
            this.grbParameters.Controls.Add(this.lblGenMax);
            this.grbParameters.Controls.Add(this.nudRotate);
            this.grbParameters.Controls.Add(this.lblRotate);
            this.grbParameters.Controls.Add(this.nudMutate);
            this.grbParameters.Controls.Add(this.lblMutate);
            this.grbParameters.Controls.Add(this.nudSize);
            this.grbParameters.Controls.Add(this.lblSize);
            this.grbParameters.Location = new System.Drawing.Point(12, 137);
            this.grbParameters.Name = "grbParameters";
            this.grbParameters.Size = new System.Drawing.Size(153, 132);
            this.grbParameters.TabIndex = 2;
            this.grbParameters.TabStop = false;
            this.grbParameters.Text = "Параметри";
            // 
            // nudGenMax
            // 
            this.nudGenMax.Location = new System.Drawing.Point(87, 101);
            this.nudGenMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGenMax.Name = "nudGenMax";
            this.nudGenMax.Size = new System.Drawing.Size(57, 20);
            this.nudGenMax.TabIndex = 9;
            this.nudGenMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGenMax
            // 
            this.lblGenMax.AutoSize = true;
            this.lblGenMax.Location = new System.Drawing.Point(6, 103);
            this.lblGenMax.Name = "lblGenMax";
            this.lblGenMax.Size = new System.Drawing.Size(76, 13);
            this.lblGenMax.TabIndex = 8;
            this.lblGenMax.Text = "Поколінь, тис";
            // 
            // nudRotate
            // 
            this.nudRotate.Location = new System.Drawing.Point(87, 75);
            this.nudRotate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRotate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRotate.Name = "nudRotate";
            this.nudRotate.Size = new System.Drawing.Size(57, 20);
            this.nudRotate.TabIndex = 7;
            this.nudRotate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblRotate
            // 
            this.lblRotate.AutoSize = true;
            this.lblRotate.Location = new System.Drawing.Point(6, 77);
            this.lblRotate.Name = "lblRotate";
            this.lblRotate.Size = new System.Drawing.Size(81, 13);
            this.lblRotate.TabIndex = 6;
            this.lblRotate.Text = "Мутації-оберти";
            // 
            // nudMutate
            // 
            this.nudMutate.Location = new System.Drawing.Point(87, 49);
            this.nudMutate.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMutate.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMutate.Name = "nudMutate";
            this.nudMutate.Size = new System.Drawing.Size(57, 20);
            this.nudMutate.TabIndex = 5;
            this.nudMutate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblMutate
            // 
            this.lblMutate.AutoSize = true;
            this.lblMutate.Location = new System.Drawing.Point(6, 51);
            this.lblMutate.Name = "lblMutate";
            this.lblMutate.Size = new System.Drawing.Size(80, 13);
            this.lblMutate.TabIndex = 4;
            this.lblMutate.Text = "Мутації-обміни";
            // 
            // nudSize
            // 
            this.nudSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSize.Location = new System.Drawing.Point(87, 23);
            this.nudSize.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(57, 20);
            this.nudSize.TabIndex = 3;
            this.nudSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 25);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(58, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Популяція";
            // 
            // grbSolver
            // 
            this.grbSolver.Controls.Add(this.nudThreads);
            this.grbSolver.Controls.Add(this.label1);
            this.grbSolver.Controls.Add(this.lblStopwatch);
            this.grbSolver.Controls.Add(this.btnStop);
            this.grbSolver.Controls.Add(this.lblGenerations);
            this.grbSolver.Controls.Add(this.btnStart);
            this.grbSolver.Location = new System.Drawing.Point(12, 275);
            this.grbSolver.Name = "grbSolver";
            this.grbSolver.Size = new System.Drawing.Size(153, 166);
            this.grbSolver.TabIndex = 3;
            this.grbSolver.TabStop = false;
            this.grbSolver.Text = "Розв\'язування";
            // 
            // nudThreads
            // 
            this.nudThreads.Location = new System.Drawing.Point(105, 23);
            this.nudThreads.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreads.Name = "nudThreads";
            this.nudThreads.Size = new System.Drawing.Size(39, 20);
            this.nudThreads.TabIndex = 10;
            this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кількість потоків";
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.AutoSize = true;
            this.lblStopwatch.Location = new System.Drawing.Point(6, 110);
            this.lblStopwatch.Name = "lblStopwatch";
            this.lblStopwatch.Size = new System.Drawing.Size(48, 13);
            this.lblStopwatch.TabIndex = 3;
            this.lblStopwatch.Text = "Минуло ";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(135, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Зупинити";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblGenerations
            // 
            this.lblGenerations.AutoSize = true;
            this.lblGenerations.Location = new System.Drawing.Point(6, 85);
            this.lblGenerations.Name = "lblGenerations";
            this.lblGenerations.Size = new System.Drawing.Size(121, 13);
            this.lblGenerations.TabIndex = 1;
            this.lblGenerations.Text = "Перевірено 0 поколінь";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Почати";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 444);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(78, 13);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Довжина туру";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 471);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.grbSolver);
            this.Controls.Add(this.grbParameters);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.grbTowns);
            this.MinimumSize = new System.Drawing.Size(850, 510);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тур комівояжера (генетичний алгоритм)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.grbTowns.ResumeLayout(false);
            this.grbTowns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.cmsDrawingOpt.ResumeLayout(false);
            this.grbParameters.ResumeLayout(false);
            this.grbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.grbSolver.ResumeLayout(false);
            this.grbSolver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTowns;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.GroupBox grbParameters;
        private System.Windows.Forms.NumericUpDown nudGenMax;
        private System.Windows.Forms.Label lblGenMax;
        private System.Windows.Forms.NumericUpDown nudRotate;
        private System.Windows.Forms.Label lblRotate;
        private System.Windows.Forms.NumericUpDown nudMutate;
        private System.Windows.Forms.Label lblMutate;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.GroupBox grbSolver;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblGenerations;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudThreads;
        private System.Windows.Forms.CheckBox reGenCb;
        private System.Windows.Forms.ContextMenuStrip cmsDrawingOpt;
        private System.Windows.Forms.ToolStripMenuItem qualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
    }
}

