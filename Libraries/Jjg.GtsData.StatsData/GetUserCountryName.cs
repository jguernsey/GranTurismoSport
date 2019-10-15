using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetUserCountryName
	{
        public string Get(string id)
        {
            string country = string.Empty;
            if (!string.IsNullOrEmpty(id))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                    {
                        SqlCommand cmd = new SqlCommand("GTS_UserCountry_Select", conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                            CommandTimeout = 0
                        };
                        cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
                        conn.Open();
                        country = cmd.ExecuteScalar().ToString();
                    }
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
            }
            return country;
        }
    }
}
