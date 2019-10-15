using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class EventWriter
	{
		public void Write(string message)
		{
			bool debug = bool.Parse(ConfigurationManager.AppSettings["Debug"].ToString());
			if (debug)
			{
				if (message.Length > 4000)
				{
					message = message.Substring(0, 4000);
				}

				string serviceName = ConfigurationManager.AppSettings["ServiceName"].ToString();
				using (SqlConnection conn = new SqlConnection(DbConn.Get()))
				{
                    SqlCommand cmd = new SqlCommand("GTS_EventLog_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@EventMessage", SqlDbType.NVarChar).Value = message;
					cmd.Parameters.Add("@EventSource", SqlDbType.NVarChar).Value = serviceName;
					cmd.CommandTimeout = 0;
					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}
