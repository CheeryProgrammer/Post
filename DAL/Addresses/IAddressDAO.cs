using System.Collections.Generic;

namespace DAL.Addresses
{
	public interface IAddressDAO
	{
		int Add(Entities.Address abonent);
		void Update(Entities.Address editAbonent);
		void Remove(Entities.Address abonent);
		IEnumerable<Entities.Address> GetList();
		void Remove(int code);
	}
}
