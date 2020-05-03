namespace digitRecognizer.Controls.Grid
{
	partial class DrawingGridControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gridPnl = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// gridPnl
			// 
			this.gridPnl.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.gridPnl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridPnl.Location = new System.Drawing.Point(0, 0);
			this.gridPnl.Name = "gridPnl";
			this.gridPnl.Size = new System.Drawing.Size(463, 421);
			this.gridPnl.TabIndex = 0;
			this.gridPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.gridPnl_Paint);
			this.gridPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridPnl_MouseDown);
			this.gridPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridPnl_MouseMove);
			this.gridPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridPnl_MouseUp);
			this.gridPnl.Resize += new System.EventHandler(this.gridPnl_Resize);
			// 
			// DrawingGridControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridPnl);
			this.Name = "DrawingGridControl";
			this.Size = new System.Drawing.Size(463, 421);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel gridPnl;
	}
}
