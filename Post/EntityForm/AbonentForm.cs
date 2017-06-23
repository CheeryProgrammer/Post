using System;
using System.Globalization;
using System.Windows.Forms;
using Entities;

namespace Post
{
	public partial class AbonentForm : Form
	{
		private Abonent _abonent;
		private AbonentForm()
		{
			InitializeComponent();
		}

		public AbonentForm(ref Abonent abonent) : this()
		{
			if (abonent == null)
				abonent = new Abonent();
			_abonent = abonent;
		}

		private void AbonentForm_Load(object sender, EventArgs e)
		{
			tbFirstName.Text = _abonent.FirstName;
			tbLastName.Text = _abonent.LastName;
			tbMidName.Text = _abonent.MidName;
			tbAddressCode.Text = _abonent.AddressCode.ToString();
			dtpBirthday.Text = _abonent.BirthDate.ToString(CultureInfo.InvariantCulture);
		}

		private void BtnAbonentChangeOk_Click(object sender, EventArgs e)
		{
			_abonent.FirstName = tbFirstName.Text;
			_abonent.LastName = tbLastName.Text;
			_abonent.MidName = tbMidName.Text;
			_abonent.AddressCode = int.Parse(tbAddressCode.Text);
			_abonent.BirthDate = DateTime.Parse(dtpBirthday.Text);
			DialogResult = DialogResult.OK;
			Dispose();
		}

		private void btnAbonentChangeCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Dispose();
		}
	}
}
