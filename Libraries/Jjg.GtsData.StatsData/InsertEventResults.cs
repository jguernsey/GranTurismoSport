using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class InsertEventResults
	{
        public void Insert(long eventResultId, long eventCalendarId, long lap, long leadLap, long mannerPoint, long manufacturerId, long qualifyRank, long rank, long profileNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_EventResults_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@EventResultId", SqlDbType.BigInt).Value = eventResultId;
                    cmd.Parameters.Add("@EventCalendarId", SqlDbType.BigInt).Value = eventCalendarId;
                    cmd.Parameters.Add("@Lap", SqlDbType.BigInt).Value = lap;
                    cmd.Parameters.Add("@LeadLap", SqlDbType.BigInt).Value = leadLap;
                    cmd.Parameters.Add("@MannerPoint", SqlDbType.BigInt).Value = mannerPoint;
                    cmd.Parameters.Add("@ManufacturerId", SqlDbType.BigInt).Value = manufacturerId;
                    cmd.Parameters.Add("@QualifyRank", SqlDbType.BigInt).Value = qualifyRank;
                    cmd.Parameters.Add("@Rank", SqlDbType.BigInt).Value = rank;
                    cmd.Parameters.Add("@UserNumber", SqlDbType.BigInt).Value = profileNumber;
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
