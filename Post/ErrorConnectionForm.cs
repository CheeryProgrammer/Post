using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Post
{
	public partial class ErrorConnectionForm : Form
	{
		public ErrorConnectionForm()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Abort;
			Close();
		}

		private void btnRetry_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Retry;
			Close();
		}
	}
}
