﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class UpdateDriverRatingStart
	{
        public void Update(long raceHeaderId, long driverRating)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RaceDetails_UpdateStartDR", conn)
                    {
                        CommandTimeout = 0,
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@RaceHeaderId", SqlDbType.BigInt).Value = raceHeaderId;
                    cmd.Parameters.Add("@StartDR", SqlDbType.BigInt).Value = driverRating;
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