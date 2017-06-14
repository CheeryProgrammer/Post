using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Department.DAL.DB;
using Entities;

namespace DAL.Subscriprions
{
	public class SubscriprionsSQL : ISubscriprionDAO
	{
		private SqlConnection _connection;
		private SqlCommand _cmd;
		private SqlDataReader _reader;

		public SubscriprionsSQL()
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

		public IEnumerable<Abonent> GetList()
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "SELECT * FROM Abonent";
				using (_reader = _cmd.ExecuteReader())
				{
					while (_reader.Read())
					{
						yield return new Abonent
						{
							Code = (int)_reader["AbonentCode"],
							AddressCode = (int)_reader["ClientAdress"],
							FirstName = (string)_reader["FirstName"],
							LastName = (string)_reader["SecondName"],
							MidName = (string)_reader["Patronymic"],
							BirthDate = (DateTime)_reader["BirthDay"]
						};
					}
				}
			}
		}

		public int Add(Abonent abonent)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "INSERT INTO Abonent(ClientAdress, SecondName, FirstName, Patronymic, BirthDay, AbonentCode)" +
								   "VALUES (@addressCode, @lastname, @firstname, @midname, @birthdate, @code);";
				_cmd.Parameters.Add(new SqlParameter("@addressCode", SqlDbType.Int));
				_cmd.Parameters.Add(new SqlParameter("@lastname", SqlDbType.NVarChar, 100));
				_cmd.Parameters.Add(new SqlParameter("@firstname", SqlDbType.NVarChar, 100));
				_cmd.Parameters.Add(new SqlParameter("@midname", SqlDbType.NVarChar, 100));
				_cmd.Parameters.Add(new SqlParameter("@birthdate", SqlDbType.DateTime));
				_cmd.Parameters.Add(new SqlParameter("@code", SqlDbType.Int));

				_cmd.Prepare();

				_cmd.Parameters[0].Value = abonent.AddressCode;
				_cmd.Parameters[1].Value = abonent.LastName;
				_cmd.Parameters[2].Value = abonent.FirstName;
				_cmd.Parameters[3].Value = abonent.MidName;
				_cmd.Parameters[4].Value = abonent.BirthDate;
				_cmd.Parameters[5].Value = abonent.Code;

				_cmd.ExecuteNonQuery();
			}
			return abonent.Code;
		}

		public void Update(Abonent editAbonent)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "UPDATE Abonent SET ClientAdress=@addressCode, " +
				                   "SecondName=@lastname, FirstName=@firstname, " +
				                   "Patronymic=@midname, BirthDay=@birthdate " +
				                   "WHERE AbonentCode = @code;";

				_cmd.Parameters.Add(new SqlParameter("@addressCode", SqlDbType.Int)).Value = editAbonent.AddressCode;
				_cmd.Parameters.Add(new SqlParameter("@lastname", SqlDbType.NVarChar, 100)).Value = editAbonent.LastName;
				_cmd.Parameters.Add(new SqlParameter("@firstname", SqlDbType.NVarChar, 100)).Value = editAbonent.FirstName;
				_cmd.Parameters.Add(new SqlParameter("@midname", SqlDbType.NVarChar, 100)).Value = editAbonent.MidName;
				_cmd.Parameters.Add(new SqlParameter("@birthdate", SqlDbType.DateTime)).Value = editAbonent.BirthDate;
				_cmd.Parameters.Add(new SqlParameter("@code", SqlDbType.Int)).Value = editAbonent.Code;

				_cmd.Prepare();
				_cmd.ExecuteNonQuery();
			}
		}

		public void Remove(int code)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "DELETE FROM Abonent WHERE AbonentCode = @code;";
				_cmd.Parameters.Add("@code", SqlDbType.Int).Value = code;
				_cmd.ExecuteNonQuery();
			}
		}

		public void Remove(Abonent abonent)
		{
			Remove(abonent.Code);
		}
		
		public void Dispose()
		{
			if (_connection != null)
				_connection.Dispose();
		}
	}
}
