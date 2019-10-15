﻿using Jjg.GtsData.Common;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Jjg.GtsData.StatsData
{
    public class InsertFiaRaceCalendar
    {
        public void Insert(RaceCalendarEvent rce)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_FIARaceHeader_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@CalendarId", SqlDbType.BigInt).Value = long.Parse(rce.event_calendar_id);
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = long.Parse(rce.region_id);
                    cmd.Parameters.Add("@ChannelId", SqlDbType.BigInt).Value = long.Parse(rce.channel_id);
                    cmd.Parameters.Add("@StartTime", SqlDbType.DateTime).Value = DateTime.Parse(rce.start_time);
                    cmd.Parameters.Add("@EndTime", SqlDbType.DateTime).Value = DateTime.Parse(rce.end_time);
                    cmd.Parameters.Add("@EventId", SqlDbType.BigInt).Value = long.Parse(rce.event_id);
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