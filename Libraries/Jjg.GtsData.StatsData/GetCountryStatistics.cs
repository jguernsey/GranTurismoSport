using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Jjg.GtsData.StatsData
{
	public class GetCountryStatistics
	{
        public DataTable Get()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Rank", typeof(long));
            dt.Columns.Add("ImagePath", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            dt.Columns.Add("TotalPercent", typeof(string));
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_PlayersByCountry_Select", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
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
