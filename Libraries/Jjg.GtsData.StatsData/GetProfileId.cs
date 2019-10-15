using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Jjg.GtsData.StatsData
{
	public class GetProfileId
	{
        public long Get(string id)
        {
            long profileId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_ProfileId_SelectById", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
                    conn.Open();
                    profileId = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return profileId;
        }
    }
}
