using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class InsertManufacturerResults
	{
        public long Insert(ManufacturerResults mr)
        {
            long resultId = 0;
            try
            {
                long profileId = new GetProfileId().Get(mr.user_id);
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_ManufacturerResults_InsertUpdate", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@SeasonId", SqlDbType.BigInt).Value = long.Parse(mr.season_id);
                    cmd.Parameters.Add("@ProfileId", SqlDbType.BigInt).Value = profileId;
                    cmd.Parameters.Add("@DriverClass", SqlDbType.BigInt).Value = long.Parse(mr.driver_class);
                    cmd.Parameters.Add("@MannerPoint", SqlDbType.BigInt).Value = long.Parse(mr.manner_point);
                    cmd.Parameters.Add("@WorldRank", SqlDbType.BigInt).Value = long.Parse(mr.display_rank);
                    cmd.Parameters.Add("@ManufacturerRank", SqlDbType.BigInt).Value = long.Parse(mr.display_rank_manufacturer);
                    cmd.Parameters.Add("@TotalPoints", SqlDbType.BigInt).Value = long.Parse(mr.point_total);
                    cmd.Parameters.Add("@ManufacturerId", SqlDbType.BigInt).Value = long.Parse(mr.manufacturer_id);
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
