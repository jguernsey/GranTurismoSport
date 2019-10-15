using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetNationsCupSummaryCountByCountry
	{
        public long Get(string season, long regionId, long countryId)
        {
            long entryCount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_NationsCup_GetCountByCountry", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@EventTarget", SqlDbType.NVarChar).Value = season;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.Parameters.Add("@CountryId", SqlDbType.BigInt).Value = countryId;
                    cmd.CommandTimeout = 0;
                    conn.Open();
                    entryCount = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return entryCount;
        }
    }
}
