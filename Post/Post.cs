using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;

namespace Post
{
	public partial class Post : Form
	{
		SortableBindingList<Abonent> abonents;
		AbonentsBL _abonents = new AbonentsBL();

		Random rnd = new Random();
		public Post()
		{
			InitializeComponent();
		}

		private void Post_Load(object sender, EventArgs e)
		{
			abonents = new SortableBindingList<Abonent>(_abonents.GetList());
			dgwAbonents.DataSource = abonents;
		}

		private void BtnAbonentsShow_Click(object sender, EventArgs e)
		{
			abonents = new SortableBindingList<Abonent>(_abonents.GetList());
			dgwAbonents.DataSource = abonents;
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
	}
}
