using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetNationsCupSummaryByCountry
	{
        public DataTable Get(long pageNumber, long regionId, string season, long countryId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_NationsCup_GetSummaryByCountry_Paged", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@EventTarget", SqlDbType.NVarChar).Value = season;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.Parameters.Add("@CountryId", SqlDbType.BigInt).Value = countryId;
                    cmd.Parameters.Add("@PageNumber", SqlDbType.BigInt).Value = pageNumber;
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
