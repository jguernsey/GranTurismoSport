﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetRaceTimes
	{
        public DataTable Get(long regionId, string title)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_GetRaceRankings_ByRegionTitle", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = title;
                    cmd.CommandTimeout = 0;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(dt);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            DataTable rt = new DataTable();
            rt.Columns.Add("Rank", typeof(long));
            rt.Columns.Add("UserId", typeof(string));
            rt.Columns.Add("ImagePath", typeof(string));
            rt.Columns.Add("Score", typeof(string));
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TimeSpan ts = TimeSpan.FromMilliseconds(double.Parse(dr[2].ToString()));
                    DataRowCollection rows = rt.Rows;
                    object[] objArray = new object[] { long.Parse(dr[0].ToString()), dr[1].ToString(), dr[3].ToString(), ts.ToString("m\\:ss\\.fff") };
                    rows.Add(objArray);
                }
            }
            return rt;
        }
    }
}
