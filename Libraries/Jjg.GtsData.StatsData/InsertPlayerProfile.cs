using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class InsertPlayerProfile
	{
        public void Insert(Profile profile)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_PlayerProfile_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = profile.Id;
                    cmd.Parameters.Add("@ProfileNumber", SqlDbType.BigInt).Value = long.Parse(profile.Number);
                    cmd.Parameters.Add("@ProfileStatus", SqlDbType.BigInt).Value = long.Parse(profile.Status);
                    cmd.Parameters.Add("@CountryCode", SqlDbType.NVarChar).Value = profile.Country;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
