using System;
using System.Windows.Forms;
using BLL;
using Entities;

namespace Post
{
	public partial class Post : Form
	{
		SortableBindingList<Abonent> abonents;
		AbonentsBL _abonents = new AbonentsBL();
		SortableBindingList<Address> addresses;
		AddressesBL _addresses = new AddressesBL();
		SortableBindingList<Mail> mails;
		MailsBL _mails = new MailsBL();
		SortableBindingList<Subscription> subscriptions;
		SubscriptionsBL _subscriptions = new SubscriptionsBL();

		public Post()
		{
			InitializeComponent();
		}

		private void Post_Load(object sender, EventArgs e)
		{
			LoadAbonents();
			LoadAddresses();
			LoadSubscriptions();
			LoadMails();
		}

		private void LoadMails()
		{
			mails = new SortableBindingList<Mail>(_mails.GetList());
			dgwMails.DataSource = mails;
		}

		private void LoadSubscriptions()
		{
			subscriptions = new SortableBindingList<Subscription>(_subscriptions.GetList());
			dgwSubscriptions.DataSource = subscriptions;
		}

		private void LoadAddresses()
		{
			addresses = new SortableBindingList<Address>(_addresses.GetList());
			dgwAddresses.DataSource = addresses;
		}

		private void LoadAbonents()
		{
			abonents = new SortableBindingList<Abonent>(_abonents.GetList());
			dgwAbonents.DataSource = abonents;
		}

		private void BtnAbonentsShow_Click(object sender, EventArgs e)
		{
			LoadAbonents();
		}

		private void BtnAbonentAdd_Click(object sender, EventArgs e)
		{
			AddAbonent();
		}

		private void AddAbonent()
		{
			Abonent newAbonent = null;
			if (new AbonentForm(ref newAbonent).ShowDialog() == DialogResult.OK)
				_abonents.Add(newAbonent);
		}

		private void BtnAbonentChange_Click(object sender, EventArgs e)
		{
			if (dgwAbonents.SelectedCells.Count > 0)
				ChangeAbonent(dgwAbonents.SelectedCells[0].RowIndex);
		}

		private void ChangeAbonent(int index)
		{
			var abonent = new Abonent();
			abonent.Code = Convert.ToInt32(dgwAbonents.Rows[index].Cells[0].Value);
			abonent.AddressCode = Convert.ToInt32(dgwAbonents.Rows[index].Cells[1].Value);
			abonent.FirstName = Convert.ToString(dgwAbonents.Rows[index].Cells[2].Value);
			abonent.LastName = Convert.ToString(dgwAbonents.Rows[index].Cells[3].Value);
			abonent.MidName = Convert.ToString(dgwAbonents.Rows[index].Cells[4].Value);
			abonent.BirthDate = Convert.ToDateTime(dgwAbonents.Rows[index].Cells[5].Value);

			if (new AbonentForm(ref abonent).ShowDialog() == DialogResult.OK)
				_abonents.Update(abonent);

			LoadAbonents();
		}

		private void BtnAbonentRemove_Click(object sender, EventArgs e)
		{
			if (dgwAbonents.SelectedCells.Count > 0)
				RemoveAbonent(dgwAbonents.SelectedCells[0].RowIndex);
		}

		private void RemoveAbonent(int rowIndex)
		{
			_abonents.Remove(Convert.ToInt32(dgwAbonents.Rows[rowIndex].Cells[0].Value));
			LoadAbonents();
		}

		private void Post_FormClosed(object sender, FormClosedEventArgs e)
		{
			_abonents?.Dispose();
			_subscriptions?.Dispose();
			_addresses?.Dispose();
			_mails?.Dispose();
		}
	}
}
