using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Department.DAL.DB;
using Entities;

namespace DAL.Addresses
{
	public class AddressesSQL : IAddressDAO
	{
		private SqlConnection _connection;
		private SqlCommand _cmd;
		private SqlDataReader _reader;

		public AddressesSQL()
		{
			InitConnection();
		}

		private void InitConnection()
		{
			_connection = new SqlConnection(DatabaseCfg.GetConnectionString());
			_connection.Open();
			_connection.StateChange += ConnectionStateChange;
		}

		private void ConnectionStateChange(object sender, StateChangeEventArgs e)
		{
			if (e.CurrentState == ConnectionState.Broken)
				InitConnection();
		}

		public IEnumerable<Address> GetList()
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "SELECT * FROM ClientAdress";
				using (_reader = _cmd.ExecuteReader())
				{
					while (_reader.Read())
					{
						yield return new Address
						{
							ID = (int)_reader["ID"],
							RegionCode = (int)_reader["Region"],
							Street = (string)_reader["Street"],
							House = (short)_reader["House"],
							Letter = ((string)_reader["Letter"])[0],
							FlatNumber = (short)_reader["Flat"]
						};
					}
				}
			}
		}

		public int Add(Address address)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "INSERT INTO ClientAdress(Region, Street, House, Letter, Flat)" +
								   "VALUES (@region, @street, @house, @letter, @flat);";
				_cmd.Parameters.Add(new SqlParameter("@region", SqlDbType.Int));
				_cmd.Parameters.Add(new SqlParameter("@street", SqlDbType.NVarChar, 100));
				_cmd.Parameters.Add(new SqlParameter("@house", SqlDbType.SmallInt));
				_cmd.Parameters.Add(new SqlParameter("@letter", SqlDbType.Char));
				_cmd.Parameters.Add(new SqlParameter("@flat", SqlDbType.SmallInt));

				_cmd.Prepare();

				_cmd.Parameters[0].Value = address.RegionCode;
				_cmd.Parameters[1].Value = address.Street;
				_cmd.Parameters[2].Value = address.House;
				_cmd.Parameters[3].Value = address.Letter;
				_cmd.Parameters[4].Value = address.FlatNumber;

				_cmd.ExecuteNonQuery();
			}
			return address.ID;
		}

		public void Update(Address editAddress)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "UPDATE ClientAdress SET Region=@region, " +
								   "Street=@street, House=@house, " +
								   "Letter=@letter, Flat=@flat " +
				                   "WHERE ID = @code;";

				_cmd.Parameters.Add(new SqlParameter("@region", SqlDbType.Int)).Value = editAddress.RegionCode;
				_cmd.Parameters.Add(new SqlParameter("@street", SqlDbType.NVarChar, 100)).Value = editAddress.Street;
				_cmd.Parameters.Add(new SqlParameter("@house", SqlDbType.SmallInt)).Value = editAddress.House;
				_cmd.Parameters.Add(new SqlParameter("@letter", SqlDbType.Char)).Value = editAddress.Letter;
				_cmd.Parameters.Add(new SqlParameter("@flat", SqlDbType.SmallInt)).Value = editAddress.FlatNumber;
				_cmd.Parameters.Add(new SqlParameter("@code", SqlDbType.Int)).Value = editAddress.ID;

				_cmd.Prepare();
				_cmd.ExecuteNonQuery();
			}
		}

		public void Remove(int code)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "DELETE FROM ClientAdress WHERE ID = @code;";
				_cmd.Parameters.Add("@code", SqlDbType.Int).Value = code;
				_cmd.ExecuteNonQuery();
			}
		}

		public void Remove(Address address)
		{
			Remove(address.ID);
		}
		
		public void Dispose()
		{
			if (_connection != null)
				_connection.Dispose();
		}
	}
}
