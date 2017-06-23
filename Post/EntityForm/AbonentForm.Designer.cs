namespace Post
{
	partial class AbonentForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbMidName = new System.Windows.Forms.TextBox();
			this.tbAddressCode = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAbonentChangeOk = new System.Windows.Forms.Button();
			this.btnAbonentChangeCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First name";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(104, 6);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(200, 20);
			this.tbFirstName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Last name";
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(104, 32);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(200, 20);
			this.tbLastName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mid name";
			// 
			// tbMidName
			// 
			this.tbMidName.Location = new System.Drawing.Point(104, 58);
			this.tbMidName.Name = "tbMidName";
			this.tbMidName.Size = new System.Drawing.Size(200, 20);
			this.tbMidName.TabIndex = 1;
			// 
			// tbAddressCode
			// 
			this.tbAddressCode.Location = new System.Drawing.Point(104, 84);
			this.tbAddressCode.Name = "tbAddressCode";
			this.tbAddressCode.Size = new System.Drawing.Size(200, 20);
			this.tbAddressCode.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Address code";
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Location = new System.Drawing.Point(104, 110);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthday.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Birth date";
			// 
			// btnAbonentChangeOk
			// 
			this.btnAbonentChangeOk.Location = new System.Drawing.Point(63, 151);
			this.btnAbonentChangeOk.Name = "btnAbonentChangeOk";
			this.btnAbonentChangeOk.Size = new System.Drawing.Size(75, 23);
			this.btnAbonentChangeOk.TabIndex = 6;
			this.btnAbonentChangeOk.Text = "OK";
			this.btnAbonentChangeOk.UseVisualStyleBackColor = true;
			this.btnAbonentChangeOk.Click += new System.EventHandler(this.BtnAbonentChangeOk_Click);
			// 
			// btnAbonentChangeCancel
			// 
			this.btnAbonentChangeCancel.Location = new System.Drawing.Point(180, 151);
			this.btnAbonentChangeCancel.Name = "btnAbonentChangeCancel";
			this.btnAbonentChangeCancel.Size = new System.Drawing.Size(75, 23);
			this.btnAbonentChangeCancel.TabIndex = 7;
			this.btnAbonentChangeCancel.Text = "Cancel";
			this.btnAbonentChangeCancel.UseVisualStyleBackColor = true;
			this.btnAbonentChangeCancel.Click += new System.EventHandler(this.btnAbonentChangeCancel_Click);
			// 
			// AbonentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 186);
			this.Controls.Add(this.btnAbonentChangeCancel);
			this.Controls.Add(this.btnAbonentChangeOk);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpBirthday);
			this.Controls.Add(this.tbAddressCode);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbMidName);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.label1);
			this.Name = "AbonentForm";
			this.Text = "AbonentForm";
			this.Load += new System.EventHandler(this.AbonentForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbMidName;
		private System.Windows.Forms.TextBox tbAddressCode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAbonentChangeOk;
		private System.Windows.Forms.Button btnAbonentChangeCancel;
	}
}