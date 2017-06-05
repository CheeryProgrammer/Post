using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abonents
{
	public interface IAbonentDAO
	{
		int Add(Entities.Abonent abonent);
		void Update(Entities.Abonent editAbonent);
		void Remove(Entities.Abonent abonent);
		IEnumerable<Entities.Abonent> GetList();
	}
}
