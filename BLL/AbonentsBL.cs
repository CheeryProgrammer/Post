using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abonents;
using Entities;

namespace BLL
{
	public class AbonentsBL : IDisposable
	{
		private readonly IAbonentDAO _abonents;
		private int top = 1;

		public AbonentsBL()
		{
			_abonents = new AbonentsSQL();
		}

		public IEnumerable<Abonent> GetList()
		{
			var res = _abonents.GetList();
			if(res.Any())
				top = res.Select(a => a.Code).Max();
			return res;
		}

		public void Dispose()
		{
			if (_abonents != null)
				(_abonents as AbonentsSQL).Dispose();
		}

		public void Add(Abonent newAbonent)
		{
			newAbonent.Code = ++top;
			_abonents.Add(newAbonent);
		}
	}
}
