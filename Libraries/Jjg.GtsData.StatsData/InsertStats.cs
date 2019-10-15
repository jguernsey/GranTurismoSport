using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class InsertStats
	{
        public void Insert(long profileId, long statId, long year, long month, long day, long statValue)
        {
            try
            {
                if (statValue > 0)
                {
                    using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                    {
                        SqlCommand cmd = new SqlCommand("GTS_Stats_Insert", conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                            CommandTimeout = 0
                        };
                        cmd.Parameters.Add("@ProfileId", SqlDbType.BigInt).Value = profileId;
                        cmd.Parameters.Add("@StatId", SqlDbType.BigInt).Value = statId;
                        cmd.Parameters.Add("@StatYear", SqlDbType.BigInt).Value = year;
                        cmd.Parameters.Add("@StatMonth", SqlDbType.BigInt).Value = month;
                        cmd.Parameters.Add("@StatDay", SqlDbType.BigInt).Value = day;
                        cmd.Parameters.Add("@StatValue", SqlDbType.BigInt).Value = statValue;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
