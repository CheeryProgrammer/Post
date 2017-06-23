namespace Post
{
	partial class ErrorConnectionForm
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
			this.btnRetry = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRetry
			// 
			this.btnRetry.Location = new System.Drawing.Point(93, 62);
			this.btnRetry.Name = "btnRetry";
			this.btnRetry.Size = new System.Drawing.Size(75, 23);
			this.btnRetry.TabIndex = 0;
			this.btnRetry.Text = "Retry";
			this.btnRetry.UseVisualStyleBackColor = true;
			this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(174, 62);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ошибка подключения к базе данных!";
			// 
			// ErrorConnectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 93);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnRetry);
			this.Name = "ErrorConnectionForm";
			this.Text = "Connection error";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRetry;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
	}
}