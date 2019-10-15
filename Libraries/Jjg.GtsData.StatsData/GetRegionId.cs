using Jjg.GtsData.Common;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetRegionId
	{
        public long Get(string psnLogin)
        {
            long regionId = 0;
            if (!string.IsNullOrEmpty(psnLogin))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                    {
                        SqlCommand cmd = new SqlCommand("GTS_Countries_SelectUserRegionId", conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                            CommandTimeout = 0
                        };
                        cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = psnLogin;
                        conn.Open();
                        regionId = cmd.ExecuteScalar().SafeToInt();
                    }
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
            }
            if (regionId != 1 && regionId != 2 && regionId != 3)
            {
                regionId = 1;
            }
            return regionId;
        }
    }
}
