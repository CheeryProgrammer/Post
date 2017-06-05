namespace Post
{
	partial class Post
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tcLists = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dgwAbonents = new System.Windows.Forms.DataGridView();
			this.btnAbonentRemove = new System.Windows.Forms.Button();
			this.btnAbonentChange = new System.Windows.Forms.Button();
			this.btnAbonentAdd = new System.Windows.Forms.Button();
			this.btnAbonentsShow = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.statusStrip1.SuspendLayout();
			this.tcLists.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwAbonents)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 440);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(887, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// tcLists
			// 
			this.tcLists.Controls.Add(this.tabPage1);
			this.tcLists.Controls.Add(this.tabPage2);
			this.tcLists.Controls.Add(this.tabPage3);
			this.tcLists.Controls.Add(this.tabPage4);
			this.tcLists.Controls.Add(this.tabPage5);
			this.tcLists.Controls.Add(this.tabPage6);
			this.tcLists.Controls.Add(this.tabPage7);
			this.tcLists.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcLists.Location = new System.Drawing.Point(0, 0);
			this.tcLists.Name = "tcLists";
			this.tcLists.SelectedIndex = 0;
			this.tcLists.Size = new System.Drawing.Size(887, 440);
			this.tcLists.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(879, 414);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Abonents";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dgwAbonents);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnAbonentRemove);
			this.splitContainer1.Panel2.Controls.Add(this.btnAbonentChange);
			this.splitContainer1.Panel2.Controls.Add(this.btnAbonentAdd);
			this.splitContainer1.Panel2.Controls.Add(this.btnAbonentsShow);
			this.splitContainer1.Size = new System.Drawing.Size(873, 408);
			this.splitContainer1.SplitterDistance = 354;
			this.splitContainer1.TabIndex = 0;
			// 
			// dgwAbonents
			// 
			this.dgwAbonents.AllowUserToAddRows = false;
			this.dgwAbonents.AllowUserToDeleteRows = false;
			this.dgwAbonents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwAbonents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgwAbonents.Location = new System.Drawing.Point(0, 0);
			this.dgwAbonents.Name = "dgwAbonents";
			this.dgwAbonents.ReadOnly = true;
			this.dgwAbonents.Size = new System.Drawing.Size(873, 354);
			this.dgwAbonents.TabIndex = 0;
			// 
			// btnAbonentRemove
			// 
			this.btnAbonentRemove.Location = new System.Drawing.Point(248, 3);
			this.btnAbonentRemove.Name = "btnAbonentRemove";
			this.btnAbonentRemove.Size = new System.Drawing.Size(75, 23);
			this.btnAbonentRemove.TabIndex = 3;
			this.btnAbonentRemove.Text = "Remove";
			this.btnAbonentRemove.UseVisualStyleBackColor = true;
			this.btnAbonentRemove.Click += new System.EventHandler(this.BtnAbonentRemove_Click);
			// 
			// btnAbonentChange
			// 
			this.btnAbonentChange.Location = new System.Drawing.Point(167, 3);
			this.btnAbonentChange.Name = "btnAbonentChange";
			this.btnAbonentChange.Size = new System.Drawing.Size(75, 23);
			this.btnAbonentChange.TabIndex = 2;
			this.btnAbonentChange.Text = "Change";
			this.btnAbonentChange.UseVisualStyleBackColor = true;
			this.btnAbonentChange.Click += new System.EventHandler(this.BtnAbonentChange_Click);
			// 
			// btnAbonentAdd
			// 
			this.btnAbonentAdd.Location = new System.Drawing.Point(86, 3);
			this.btnAbonentAdd.Name = "btnAbonentAdd";
			this.btnAbonentAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAbonentAdd.TabIndex = 1;
			this.btnAbonentAdd.Text = "Add";
			this.btnAbonentAdd.UseVisualStyleBackColor = true;
			this.btnAbonentAdd.Click += new System.EventHandler(this.BtnAbonentAdd_Click);
			// 
			// btnAbonentsShow
			// 
			this.btnAbonentsShow.Location = new System.Drawing.Point(5, 3);
			this.btnAbonentsShow.Name = "btnAbonentsShow";
			this.btnAbonentsShow.Size = new System.Drawing.Size(75, 23);
			this.btnAbonentsShow.TabIndex = 0;
			this.btnAbonentsShow.Text = "Load";
			this.btnAbonentsShow.UseVisualStyleBackColor = true;
			this.btnAbonentsShow.Click += new System.EventHandler(this.BtnAbonentsShow_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(879, 414);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Subscriptions";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(879, 414);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Addresses";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(879, 414);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Editions";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(879, 414);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Authors";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// tabPage6
			// 
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(879, 414);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Publishers";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// tabPage7
			// 
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new System.Drawing.Size(879, 414);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "Mails";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// Post
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 462);
			this.Controls.Add(this.tcLists);
			this.Controls.Add(this.statusStrip1);
			this.Name = "Post";
			this.Text = "Post";
			this.Load += new System.EventHandler(this.Post_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tcLists.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwAbonents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.TabControl tcLists;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgwAbonents;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.Button btnAbonentRemove;
		private System.Windows.Forms.Button btnAbonentChange;
		private System.Windows.Forms.Button btnAbonentAdd;
		private System.Windows.Forms.Button btnAbonentsShow;
	}
}

