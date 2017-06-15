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

		public IEnumerable<Subscription> GetList()
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "SELECT * FROM Subscribe";
				using (_reader = _cmd.ExecuteReader())
				{
					while (_reader.Read())
					{
						yield return new Subscription
						{
							Code = (decimal)_reader["Code"],
							EditionCode = (string)_reader["Edition"],
							Abonent = (int)_reader["Abonent"],
							Period = (int)_reader["Period"],
							Cost = (decimal)_reader["Cost"],
						};
					}
				}
			}
		}

		public int Add(Subscription subscription)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "INSERT INTO Subscribe(Edition, Abonent, Period, Cost)" +
								   "VALUES (@edition, @abonent, @period, @cost);";
				_cmd.Parameters.Add(new SqlParameter("@edition", SqlDbType.VarChar, 20));
				_cmd.Parameters.Add(new SqlParameter("@abonent", SqlDbType.Int));
				_cmd.Parameters.Add(new SqlParameter("@period", SqlDbType.Int));
				_cmd.Parameters.Add(new SqlParameter("@cost", SqlDbType.Money));

				_cmd.Prepare();

				_cmd.Parameters[0].Value = subscription.EditionCode;
				_cmd.Parameters[1].Value = subscription.Abonent;
				_cmd.Parameters[2].Value = subscription.Period;
				_cmd.Parameters[5].Value = subscription.Cost;

				_cmd.ExecuteNonQuery();
			}
			return Convert.ToInt32(subscription.Code);
		}

		public void Update(Subscription editSubscription)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "UPDATE Subscribe SET Edition=@edition, " +
								   "Abonent=@abonent, Period=@period, " +
								   "Cost=@cost";


				_cmd.Parameters.Add(new SqlParameter("@edition", SqlDbType.VarChar, 20)).Value = editSubscription.EditionCode;
				_cmd.Parameters.Add(new SqlParameter("@abonent", SqlDbType.Int)).Value = editSubscription.Abonent;
				_cmd.Parameters.Add(new SqlParameter("@period", SqlDbType.Int)).Value = editSubscription.Period;
				_cmd.Parameters.Add(new SqlParameter("@cost", SqlDbType.Money)).Value = editSubscription.Cost;

				_cmd.Prepare();
				_cmd.ExecuteNonQuery();
			}
		}

		public void Remove(int code)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "DELETE FROM Subscribe WHERE Code = @code;";
				_cmd.Parameters.Add("@code", SqlDbType.Int).Value = code;
				_cmd.ExecuteNonQuery();
			}
		}

		public void Remove(Subscription subscription)
		{
			Remove(Convert.ToInt32(subscription.Code));
		}

		public void Dispose()
		{
			if (_connection != null)
				_connection.Dispose();
		}
	}
}
