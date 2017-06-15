using System.Collections.Generic;

namespace DAL.Mails
{
	public interface IMailDAO
	{
		int Add(Entities.Mail mail);
		void Update(Entities.Mail editMail);
		void Remove(Entities.Mail mail);
		IEnumerable<Entities.Mail> GetList();
		void Remove(int code);
	}
}
