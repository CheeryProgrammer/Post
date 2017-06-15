using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Department.DAL.DB;
using Entities;

namespace DAL.Mails
{
	public class MailsSQL : IMailDAO
	{
		private SqlConnection _connection;
		private SqlCommand _cmd;
		private SqlDataReader _reader;

		public MailsSQL()
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

		public IEnumerable<Mail> GetList()
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "SELECT * FROM Mail";
				using (_reader = _cmd.ExecuteReader())
				{
					while (_reader.Read())
					{
						yield return new Mail
						{
							Code = (int)_reader["MailCode"],
							TypeMail = (int)_reader["TypeMail"],
							Sender = (int)_reader["Sender"],
							Reciever = (int)_reader["Reciever"],
						};
					}
				}
			}
		}

		public int Add(Mail mail)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "INSERT INTO Mail(TypeMail, Sender, Reciever)" +
								   "VALUES (@typeMail, @sender, @reciever);";
				_cmd.Parameters.Add(new SqlParameter("@typeMail", SqlDbType.Int));
				_cmd.Parameters.Add(new SqlParameter("@sender", SqlDbType.Int));
				_cmd.Parameters.Add(new SqlParameter("@reciever", SqlDbType.Int));

				_cmd.Prepare();

				_cmd.Parameters[0].Value = mail.TypeMail;
				_cmd.Parameters[1].Value = mail.Sender;
				_cmd.Parameters[2].Value = mail.Reciever;

				_cmd.ExecuteNonQuery();
			}
			return mail.Code;
		}

		public void Update(Mail editMail)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "UPDATE Mail SET TypeMail=@typeMail, " +
				                   "Sender=@sender, Reciever=@reciever";

				_cmd.Parameters.Add(new SqlParameter("@typeMail", SqlDbType.Int)).Value = editMail.TypeMail;
				_cmd.Parameters.Add(new SqlParameter("@sender", SqlDbType.Int)).Value = editMail.Sender;
				_cmd.Parameters.Add(new SqlParameter("@reciever", SqlDbType.Int)).Value = editMail.Reciever;

				_cmd.Prepare();
				_cmd.ExecuteNonQuery();
			}
		}

		public void Remove(int code)
		{
			using (_cmd = _connection.CreateCommand())
			{
				_cmd.CommandText = "DELETE FROM Mail WHERE MailCode = @code;";
				_cmd.Parameters.Add("@code", SqlDbType.Int).Value = code;
				_cmd.ExecuteNonQuery();
			}
		}

		public void Remove(Mail mail)
		{
			Remove(mail.Code);
		}
		
		public void Dispose()
		{
			if (_connection != null)
				_connection.Dispose();
		}
	}
}
