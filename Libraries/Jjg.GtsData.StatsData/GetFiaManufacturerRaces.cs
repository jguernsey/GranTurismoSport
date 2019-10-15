using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
    public class GetFiaManufacturerRaces
    {
        public DataTable Get()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_GetFiaManufacturerRaces", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.CommandTimeout = 0;
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            DataTable rt = new DataTable();
            rt.Columns.Add("Track", typeof(string));
            rt.Columns.Add("Category", typeof(string));
            rt.Columns.Add("Laps", typeof(string));
            rt.Columns.Add("Fuel", typeof(string));
            rt.Columns.Add("TireWear", typeof(string));
            rt.Columns.Add("RegionCount", typeof(string));
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    DataRowCollection rows = rt.Rows;
                    object[] str = new object[] { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), string.Format("{0:N0}", long.Parse(dr[6].ToString())) };
                    rows.Add(str);
                }
            }
            return rt;
        }
    }
}
