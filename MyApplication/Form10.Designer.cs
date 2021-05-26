namespace MyApplication
{
	partial class Form10
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

		#region Windows Form Designer generated code:
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.MyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MyLabel
            // 
            this.MyLabel.AutoSize = true;
            this.MyLabel.Location = new System.Drawing.Point(44, 43);
            this.MyLabel.Name = "MyLabel";
            this.MyLabel.Size = new System.Drawing.Size(98, 13);
            this.MyLabel.TabIndex = 0;
            this.MyLabel.Text = "Mahsa Eftekhari";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.MyLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion /Windows Form Designer generated code

        private System.Windows.Forms.Label MyLabel;
    }
}
