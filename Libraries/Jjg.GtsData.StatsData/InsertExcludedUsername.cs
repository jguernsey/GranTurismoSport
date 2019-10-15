using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class InsertExcludedUsername
	{
        public void Insert(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_ExcludedUsernames_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
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
