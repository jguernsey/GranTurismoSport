using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetDriverNameSearch
	{
        public DataTable Get(string id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProfileNumber", typeof(long));
            dt.Columns.Add("Id", typeof(string));
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_GetDriverNames_Select", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
                    cmd.CommandTimeout = 0;
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
