using System.Configuration;
using System.Data.SqlClient;

namespace Department.DAL.DB
{
	static class DatabaseCfg
	{
		public static string GetConnectionString()
		{
			string databaseName = ConfigurationManager.AppSettings["DatabaseName"];
			ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["connectionString1"];
			SqlConnectionStringBuilder builder =
				new SqlConnectionStringBuilder(settings.ConnectionString);
			builder.DataSource = databaseName;
			return settings.ConnectionString;
		}
	}
}
