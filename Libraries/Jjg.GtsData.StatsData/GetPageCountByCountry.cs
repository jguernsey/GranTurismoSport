using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetPageCountByCountry
	{
        public long Get(string procName, string country, long regionId)
        {
            long pageCount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand(procName, conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value = country;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    conn.Open();
                    pageCount = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return pageCount;
        }
    }
}
