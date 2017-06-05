using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.DAL.DB;
using Entities;

namespace DAL.Abonents
{
	public class AbonentsSQL : IAbonentDAO
	{
		private SqlConnection _connection;
		private SqlCommand _cmd;
		private SqlDataReader _reader;

		public AbonentsSQL()
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
				_cmd.CommandText = "UPDATE Users SET FirstName=@firstName, " +
					"LastName=@lastName, BirthDate=@birthDate " +
					"WHERE UserID = @userId; " +
					"DELETE FROM Rewardings WHERE UserID = @userId;";

				_cmd.Parameters.Add("@firstName", SqlDbType.NVarChar, 50).Value = editAbonent.FirstName;
				_cmd.Parameters.Add("@lastName", SqlDbType.NVarChar, 50).Value = editAbonent.LastName;
				_cmd.Parameters.Add("@birthDate", SqlDbType.DateTime).Value = editAbonent.BirthDate;
				_cmd.Parameters.Add("@userId", SqlDbType.Int).Value = editAbonent.Code;

				_cmd.Prepare();

				var result_1 = _cmd.ExecuteNonQuery();
				var result_2 = _cmd.ExecuteNonQuery();
			}
		}
		

		public void Remove(Abonent user)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = String.Format("DELETE FROM Rewardings WHERE UserID = @userId;" +
					"DELETE FROM Users WHERE UserID = @userId;");
				_cmd.Parameters.Add("@userId", SqlDbType.Int).Value = user.Code;
				var result_1 = _cmd.ExecuteNonQuery();
				var result_2 = _cmd.ExecuteNonQuery();
			}
			return;
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

		private IEnumerable<int> GetAwardIdList(int id)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = String.Format("SELECT AwardID FROM Rewardings WHERE UserID = @id");
				_cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

				using (_reader = _cmd.ExecuteReader())
				{
					while (_reader.Read())
						yield return (int)_reader["AwardID"];
				}
			}
		}

		public void Dispose()
		{
			if (_connection != null)
				_connection.Dispose();
		}
	}
}
