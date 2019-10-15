using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetTrackDetailByTime
	{
        public DataTable Get()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_GetTrackSportsmanshipRatingByTimeOfDay", conn)
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
            DataTable rt = new DataTable();
            rt.Columns.Add("Track", typeof(string));
            rt.Columns.Add("Category", typeof(string));
            rt.Columns.Add("Time", typeof(string));
            rt.Columns.Add("Entries", typeof(string));
            rt.Columns.Add("MostGained", typeof(string));
            rt.Columns.Add("MostLost", typeof(string));
            rt.Columns.Add("Average", typeof(string));
            rt.Columns.Add("Total", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                int hour = int.Parse(dr[2].ToString());
                TimeSpan tStart = new TimeSpan(hour * 4, 0, 0);
                TimeSpan tEnd = tStart.Add(new TimeSpan(3, 59, 59));
                string span = string.Format("{0} - {1}", tStart.ToString("hh\\:mm"), tEnd.ToString("hh\\:mm"));
                DataRowCollection rows = rt.Rows;
                object[] str = new object[] { dr[0].ToString(), dr[1].ToString(), span, string.Format("{0:N0}", long.Parse(dr[3].ToString())), string.Format("{0:N0}", long.Parse(dr[4].ToString())), string.Format("{0:N0}", long.Parse(dr[5].ToString())), string.Format("{0:N3}", decimal.Parse(dr[6].ToString())), string.Format("{0:N0}", long.Parse(dr[7].ToString())) };
                rows.Add(str);
            }
            return rt;
        }
    }
}
