using System.Collections.Generic;

namespace DAL.Mails
{
	public interface IMailDAO
	{
		int Add(Entities.Abonent abonent);
		void Update(Entities.Abonent editAbonent);
		void Remove(Entities.Abonent abonent);
		IEnumerable<Entities.Abonent> GetList();
		void Remove(int code);
	}
}
