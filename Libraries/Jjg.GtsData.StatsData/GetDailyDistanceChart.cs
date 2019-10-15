using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetDailyDistanceChart
	{
        public DataTable Get(string id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("HistoryDate", typeof(DateTime));
            dt.Columns.Add("Kilometers", typeof(decimal));
            dt.Columns.Add("RunningTotal", typeof(decimal));
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_Chart_DailyDistance", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
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
