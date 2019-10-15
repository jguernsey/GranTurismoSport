using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class InsertSeason
	{
        public long Insert(Season season, long regionId)
        {
            long seasonId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_Seasons_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@SeasonId", SqlDbType.BigInt).Value = season.season_id;
                    cmd.Parameters.Add("@ChampionshipId", SqlDbType.BigInt).Value = season.championship_id;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.Parameters.Add("@RaceCount", SqlDbType.BigInt).Value = long.Parse(season.rounds[0].championship_valid_race_count);
                    cmd.Parameters.Add("@Logo", SqlDbType.NVarChar).Value = season.rounds[0].logo_image_path;
                    cmd.Parameters.Add("@Flyer", SqlDbType.NVarChar).Value = season.rounds[0].flyer_image_path;
                    SqlParameter sqlParameter = cmd.Parameters.Add("@Color", SqlDbType.NVarChar);
                    int num = int.Parse(season.color.r);
                    string str = num.ToString("X2");
                    int num1 = int.Parse(season.color.g);
                    string str1 = num1.ToString("X2");
                    int num2 = int.Parse(season.color.b);
                    sqlParameter.Value = string.Format("#{0}{1}{2}", str, str1, num2.ToString("X2"));
                    conn.Open();
                    seasonId = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return seasonId;
        }
    }
}
