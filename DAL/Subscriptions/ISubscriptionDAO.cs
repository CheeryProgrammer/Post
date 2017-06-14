using System.Collections.Generic;

namespace DAL.Subscriprions
{
	public interface ISubscriprionDAO
	{
		int Add(Entities.Abonent abonent);
		void Update(Entities.Abonent editAbonent);
		void Remove(Entities.Abonent abonent);
		IEnumerable<Entities.Abonent> GetList();
		void Remove(int code);
	}
}
