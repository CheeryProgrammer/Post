using System.Collections.Generic;

namespace DAL.Addresses
{
	public interface IAddressDAO
	{
		int Add(Entities.Address address);
		void Update(Entities.Address editAddress);
		void Remove(Entities.Address address);
		IEnumerable<Entities.Address> GetList();
		void Remove(int code);
	}
}
