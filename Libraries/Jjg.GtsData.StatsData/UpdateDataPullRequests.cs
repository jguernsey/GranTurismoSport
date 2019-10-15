using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
    public class UpdateDataPullRequests
    {
        public void Update(long requestBytes)
        {
            string serviceName = ConfigurationManager.AppSettings["ServiceName"].ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_DataPullRequests_Update", conn)
                    {
                        CommandTimeout = 0,
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@ServiceName", SqlDbType.NVarChar).Value = serviceName;
                    cmd.Parameters.Add("@RequestBytes", SqlDbType.BigInt).Value = requestBytes;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
