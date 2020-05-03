namespace digitRecognizer.Models.Controls
{
    partial class NumberControl
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
            graphics.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numberLbl = new System.Windows.Forms.Label();
            this.valueLbl = new System.Windows.Forms.Label();
            this.colorPnl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.numberLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueLbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorPnl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(109, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numberLbl
            // 
            this.numberLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberLbl.Location = new System.Drawing.Point(3, 0);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(10, 29);
            this.numberLbl.TabIndex = 0;
            this.numberLbl.Text = "N";
            this.numberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLbl.Location = new System.Drawing.Point(51, 0);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(55, 29);
            this.valueLbl.TabIndex = 1;
            this.valueLbl.Text = "value";
            this.valueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorPnl
            // 
            this.colorPnl.Location = new System.Drawing.Point(19, 3);
            this.colorPnl.Name = "colorPnl";
            this.colorPnl.Size = new System.Drawing.Size(26, 23);
            this.colorPnl.TabIndex = 2;
            this.colorPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.colorPnl_Paint);
            // 
            // NumberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NumberControl";
            this.Size = new System.Drawing.Size(109, 29);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.Panel colorPnl;
    }
}
