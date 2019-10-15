using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class InsertSeasonRound
	{
        public long Insert(long seasonId, long roundId, DateTime startDate, DateTime endDate, long eventId)
        {
            long seasonRoundId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_SeasonRounds_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@SeasonId", SqlDbType.BigInt).Value = seasonId;
                    cmd.Parameters.Add("@RoundId", SqlDbType.BigInt).Value = roundId;
                    cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = endDate;
                    cmd.Parameters.Add("@EventId", SqlDbType.BigInt).Value = eventId;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return seasonRoundId;
        }
    }
}
