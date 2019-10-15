using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class GetUserRanking
	{
        public RaceRanking Get(string userId, long boardId)
        {
            RaceRanking rr = new RaceRanking()
            {
                RegionRank = 0,
                RegionTotal = 0,
                WorldRank = 0,
                WorldTotal = 0,
                Time = string.Empty,
                RegionGap = string.Empty,
                WorldGap = string.Empty
            };
            if (!string.IsNullOrEmpty(userId))
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                    {
                        SqlCommand cmd = new SqlCommand("GTS_RaceRankings_SelectUserInfo", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
                        cmd.Parameters.Add("@BoardId", SqlDbType.BigInt).Value = boardId;
                        cmd.CommandTimeout = 0;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        conn.Open();
                        da.Fill(dt);
                    }
                    if (dt.Rows.Count >= 1)
                    {
                        rr.RegionRank = dt.Rows[0][0].SafeToInt();
                        rr.RegionTotal = dt.Rows[0][1].SafeToInt();
                        TimeSpan ts = TimeSpan.FromMilliseconds(dt.Rows[0][4].SafeToDouble());
                        rr.Time = ts.ToString("m\\:ss\\.fff");
                        TimeSpan ts2 = TimeSpan.FromMilliseconds(dt.Rows[0][5].SafeToDouble());
                        rr.RegionGap = ts2.ToString("m\\:ss\\.fff");
                        TimeSpan ts3 = TimeSpan.FromMilliseconds(dt.Rows[0][6].SafeToDouble());
                        rr.RegionNext = ts3.ToString("m\\:ss\\.fff");
                    }
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
                try
                {
                    DataTable dt2 = new DataTable();
                    using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                    {
                        SqlCommand cmd = new SqlCommand("GTS_RaceRankings_SelectWorldWideUser", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
                        cmd.Parameters.Add("@BoardId", SqlDbType.BigInt).Value = boardId;
                        cmd.CommandTimeout = 0;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        conn.Open();
                        da.Fill(dt2);
                    }
                    if (dt2.Rows.Count >= 1)
                    {
                        rr.WorldRank = dt2.Rows[0][0].SafeToInt();
                        rr.WorldTotal = dt2.Rows[0][1].SafeToInt();
                        TimeSpan ts2 = TimeSpan.FromMilliseconds(dt2.Rows[0][5].SafeToDouble());
                        rr.WorldGap = ts2.ToString("m\\:ss\\.fff");
                        TimeSpan ts3 = TimeSpan.FromMilliseconds(dt2.Rows[0][6].SafeToDouble());
                        rr.WorldNext = ts3.ToString("m\\:ss\\.fff");
                    }
                }
                catch (Exception exception1)
                {
                    new EventWriter().Write(exception1.ToString());
                }
            }
            return rr;
        }
    }
}
