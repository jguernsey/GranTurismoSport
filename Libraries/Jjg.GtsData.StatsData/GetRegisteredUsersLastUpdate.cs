using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Jjg.GtsData.StatsData
{
	public class GetRegisteredUsersLastUpdate
	{
        public DataTable Get(long pageNumber)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RegisteredUsersLastUpdate_SelectAll", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@PageNumber", SqlDbType.BigInt).Value = pageNumber;
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
