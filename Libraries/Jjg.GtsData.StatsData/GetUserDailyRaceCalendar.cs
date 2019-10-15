using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetUserDailyRaceCalendar
	{
        public DataTable Get(string username)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_GetUsersDailyRaces", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = username;
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
                    if (!dr[7].ToString().Equals("Y"))
                    {
                        DataRowCollection rows = rt.Rows;
                        object[] str = new object[] { dr[0].ToString(), string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };
                        rows.Add(str);
                        DataRowCollection dataRowCollection = rt.Rows;
                        object[] objArray = new object[] { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), string.Format("{0:N0}", long.Parse(dr[6].ToString())) };
                        dataRowCollection.Add(objArray);
                    }
                    else
                    {
                        DataRowCollection rows1 = rt.Rows;
                        object[] objArray1 = new object[] { string.Format("24 Superstars - {0}", dr[0].ToString()), string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };
                        rows1.Add(objArray1);
                        DataRowCollection dataRowCollection1 = rt.Rows;
                        object[] str1 = new object[] { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), string.Format("{0:N0}", long.Parse(dr[6].ToString())) };
                        dataRowCollection1.Add(str1);
                    }
                }
            }
            return rt;
        }
    }
}
