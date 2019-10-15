using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class UpdateEndPosition
	{
        public void Update(long raceHeaderId, long position)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_UpdateEndPosition", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@RaceHeaderId", SqlDbType.BigInt).Value = raceHeaderId;
                    cmd.Parameters.Add("@Position", SqlDbType.BigInt).Value = position;
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
