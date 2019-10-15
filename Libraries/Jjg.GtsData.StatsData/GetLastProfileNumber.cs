using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Jjg.GtsData.StatsData
{
	public class GetLastProfileNumber
	{
        public long Get()
        {
            long profileNumber = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_MaxProfileNumber_Select", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    conn.Open();
                    profileNumber = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return profileNumber;
        }
    }
}
