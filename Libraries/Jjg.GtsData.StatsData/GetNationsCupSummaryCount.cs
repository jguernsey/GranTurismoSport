using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetNationsCupSummaryCount
	{
        public long Get(string season, long regionId)
        {
            long entries = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_NationsCup_GetSummaryCount", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@EventTarget", SqlDbType.NVarChar).Value = season;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.CommandTimeout = 0;
                    conn.Open();
                    entries = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return entries;
        }
    }
}
