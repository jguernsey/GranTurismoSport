using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetLastProfileUpdate
	{
        public DateTime Get(long profileId)
        {
            DateTime lastUpdate = new DateTime(1753, 1, 1);
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_LastUpdate_Update", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@ProfileId", SqlDbType.BigInt).Value = profileId;
                    conn.Open();
                    lastUpdate = DateTime.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return lastUpdate;
        }
    }
}
