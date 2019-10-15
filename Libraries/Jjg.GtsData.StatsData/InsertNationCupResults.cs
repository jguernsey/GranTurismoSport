using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class InsertNationCupResults
	{
        public long Insert(NationResults nr)
        {
            long resultId = 0;
            try
            {
                long profileId = new GetProfileId().Get(nr.user_id);
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_NationsCupResults_InsertUpdate", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@SeasonId", SqlDbType.BigInt).Value = long.Parse(nr.season_id);
                    cmd.Parameters.Add("@ProfileId", SqlDbType.BigInt).Value = profileId;
                    cmd.Parameters.Add("@DriverClass", SqlDbType.BigInt).Value = long.Parse(nr.driver_class);
                    cmd.Parameters.Add("@MannerPoint", SqlDbType.BigInt).Value = long.Parse(nr.manner_point);
                    cmd.Parameters.Add("@WorldRank", SqlDbType.BigInt).Value = long.Parse(nr.display_rank);
                    cmd.Parameters.Add("@CountryRank", SqlDbType.BigInt).Value = long.Parse(nr.display_rank_country);
                    cmd.Parameters.Add("@TotalPoints", SqlDbType.BigInt).Value = long.Parse(nr.point_total);
                    conn.Open();
                    resultId = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return resultId;
        }
    }
}
