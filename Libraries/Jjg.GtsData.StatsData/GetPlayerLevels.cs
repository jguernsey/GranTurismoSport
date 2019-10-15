using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetPlayerLevels
	{
        public DataTable Get()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_PlayerLevels_Select", conn)
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
            DataTable returnTable = new DataTable();
            returnTable.Columns.Add("PlayerLevel", typeof(long));
            returnTable.Columns.Add("PlayerCount", typeof(string));
            returnTable.Columns.Add("PercentageOfTotal", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                DataRowCollection rows = returnTable.Rows;
                object[] objArray = new object[] { long.Parse(dr[0].ToString()), string.Format("{0:N0}", long.Parse(dr[1].ToString())), string.Format("{0:0.0000}%", decimal.Parse(dr[2].ToString()) * new decimal(100)) };
                rows.Add(objArray);
            }
            return returnTable;
        }
    }
}
