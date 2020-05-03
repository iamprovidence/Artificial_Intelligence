namespace digitRecognizer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.guessBtn = new System.Windows.Forms.Button();
			this.clearBtn = new System.Windows.Forms.Button();
			this.trainBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.numberFlp = new System.Windows.Forms.FlowLayoutPanel();
			this.drawingGrid = new digitRecognizer.Controls.Grid.DrawingGridControl();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 471);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.guessBtn, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.clearBtn, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.trainBtn, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 436);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 35);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// guessBtn
			// 
			this.guessBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guessBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guessBtn.Location = new System.Drawing.Point(181, 3);
			this.guessBtn.Name = "guessBtn";
			this.guessBtn.Size = new System.Drawing.Size(172, 29);
			this.guessBtn.TabIndex = 1;
			this.guessBtn.Text = "guess";
			this.guessBtn.UseVisualStyleBackColor = true;
			this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
			// 
			// clearBtn
			// 
			this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clearBtn.Location = new System.Drawing.Point(3, 3);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(172, 29);
			this.clearBtn.TabIndex = 2;
			this.clearBtn.Text = "clear";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// trainBtn
			// 
			this.trainBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trainBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trainBtn.Location = new System.Drawing.Point(359, 3);
			this.trainBtn.Name = "trainBtn";
			this.trainBtn.Size = new System.Drawing.Size(172, 29);
			this.trainBtn.TabIndex = 2;
			this.trainBtn.Text = "train";
			this.trainBtn.UseVisualStyleBackColor = true;
			this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(528, 35);
			this.label5.TabIndex = 1;
			this.label5.Text = "Digit Recognizer";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel3.Controls.Add(this.numberFlp, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.drawingGrid, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 35);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(534, 401);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// numberFlp
			// 
			this.numberFlp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.numberFlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numberFlp.Location = new System.Drawing.Point(434, 0);
			this.numberFlp.Margin = new System.Windows.Forms.Padding(0);
			this.numberFlp.Name = "numberFlp";
			this.numberFlp.Size = new System.Drawing.Size(100, 401);
			this.numberFlp.TabIndex = 1;
			// 
			// drawingGrid
			// 
			this.drawingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.drawingGrid.Location = new System.Drawing.Point(3, 3);
			this.drawingGrid.Name = "drawingGrid";
			this.drawingGrid.Size = new System.Drawing.Size(428, 395);
			this.drawingGrid.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(534, 471);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(550, 510);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Digit Recognizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Button trainBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel numberFlp;
        private System.Windows.Forms.Button clearBtn;
		private Controls.Grid.DrawingGridControl drawingGrid;
	}
}

