using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class InsertRaceDetails
	{
        public void Insert(long raceHeaderId, long startPosition)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RaceDetails_Insert", conn)
                    {
                        CommandTimeout = 0,
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@RaceHeaderId", SqlDbType.BigInt).Value = raceHeaderId;
                    cmd.Parameters.Add("@StartPosition", SqlDbType.BigInt).Value = startPosition;
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
