using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Addresses;
using Entities;

namespace BLL
{
	public class AddressesBL : IDisposable
	{
		private readonly IAddressDAO _addresses;
		private int top = 1;

		public AddressesBL()
		{
			_addresses = new AddressesSQL();
		}

		public IEnumerable<Address> GetList()
		{
			var res = _addresses.GetList();
			if(res.Any())
				top = res.Select(a => a.ID).Max();
			return res;
		}

		public void Add(Address newAddress)
		{
			newAddress.ID = ++top;
			_addresses.Add(newAddress);
		}

		public void Update(Address address)
		{
			_addresses.Update(address);
		}

		public void Remove(int code)
		{
			_addresses.Remove(code);
		}

		public void Dispose()
		{
			if (_addresses != null)
				(_addresses as AddressesSQL).Dispose();
		}
	}
}
