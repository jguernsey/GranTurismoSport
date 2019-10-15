using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class InsertEventHeader
	{
        public void Insert(RaceEvent raceEvent)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_EventHeader_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@EventCalendarId", SqlDbType.BigInt).Value = raceEvent.EventCalendarId;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = raceEvent.RegionId;
                    cmd.Parameters.Add("@ChannelId", SqlDbType.BigInt).Value = raceEvent.ChannelId;
                    cmd.Parameters.Add("@StartTime", SqlDbType.DateTime).Value = DateTime.Parse(raceEvent.StartTime);
                    cmd.Parameters.Add("@EndTime", SqlDbType.DateTime).Value = DateTime.Parse(raceEvent.EndTime);
                    cmd.Parameters.Add("@EventId", SqlDbType.BigInt).Value = raceEvent.EventId;
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
