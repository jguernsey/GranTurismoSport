using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetRaceTypes
	{
        public DataTable Get()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RaceTypeId", typeof(long));
            dt.Columns.Add("RaceType", typeof(string));
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RaceTypes_Select", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(dt);
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
