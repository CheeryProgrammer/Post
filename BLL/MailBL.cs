using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Mails;
using Entities;

namespace BLL
{
	public class MailsBL : IDisposable
	{
		private readonly IMailDAO _mails;
		private int top = 1;

		public MailsBL()
		{
			_mails = new MailsSQL();
		}

		public IEnumerable<Mail> GetList()
		{
			var res = _mails.GetList();
			if(res.Any())
				top = res.Select(a => a.Code).Max();
			return res;
		}

		public void Add(Mail newMail)
		{
			newMail.Code = ++top;
			_mails.Add(newMail);
		}

		public void Update(Mail mail)
		{
			_mails.Update(mail);
		}

		public void Remove(int code)
		{
			_mails.Remove(code);
		}

		public void Dispose()
		{
			if (_mails != null)
				(_mails as MailsSQL).Dispose();
		}
	}
}
