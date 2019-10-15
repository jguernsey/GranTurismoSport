using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class UpdateLapTimeRankings
	{
        public void Update()
        {
            EventWriter writer = new EventWriter();
            DateTime start = DateTime.Now;
            DateTime now = DateTime.Now;
            writer.Write(string.Format("Start:UpdateRankedTimes:{0}", now.ToString()));
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RankedRaceTimes_Update", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                writer.Write(exception.ToString());
            }
            TimeSpan ts = DateTime.Now.Subtract(start);
            DateTime dateTime = DateTime.Now;
            writer.Write(string.Format("End:UpdateRankedTimes:{0}-Duration:{1}", dateTime.ToString(), ts.ToString()));
        }
    }
}
