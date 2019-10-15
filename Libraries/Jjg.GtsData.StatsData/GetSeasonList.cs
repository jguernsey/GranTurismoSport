﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetSeasonList
	{
        public DataTable Get(long typeId, long regionId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_SeasonNames_Select", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@TypeId", SqlDbType.BigInt).Value = typeId;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.CommandTimeout = 0;
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return dt;
        }
    }
}