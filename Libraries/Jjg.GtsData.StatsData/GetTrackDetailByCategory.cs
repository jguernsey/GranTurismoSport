using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetTrackDetailByCategory
	{
        public DataTable Get()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_GetTrackSportsmanshipRatingByCategory", conn)
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
            rt.Columns.Add("Category", typeof(string));
            rt.Columns.Add("Entries", typeof(string));
            rt.Columns.Add("MostGained", typeof(string));
            rt.Columns.Add("MostLost", typeof(string));
            rt.Columns.Add("Average", typeof(string));
            rt.Columns.Add("Total", typeof(string));
            string lastTrack = string.Empty;
            foreach (DataRow dr in dt.Rows)
            {
                if (!dr[0].Equals(lastTrack))
                {
                    DataRowCollection rows = rt.Rows;
                    object[] str = new object[] { dr[0].ToString(), string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };
                    rows.Add(str);
                    DataRowCollection dataRowCollection = rt.Rows;
                    object[] objArray = new object[] { dr[1].ToString(), string.Format("{0:N0}", long.Parse(dr[2].ToString())), string.Format("{0:N0}", long.Parse(dr[3].ToString())), string.Format("{0:N0}", long.Parse(dr[4].ToString())), string.Format("{0:N3}", decimal.Parse(dr[5].ToString())), string.Format("{0:N0}", long.Parse(dr[6].ToString())) };
                    dataRowCollection.Add(objArray);
                    lastTrack = dr[0].ToString();
                }
                else
                {
                    DataRowCollection rows1 = rt.Rows;
                    object[] str1 = new object[] { dr[1].ToString(), string.Format("{0:N0}", long.Parse(dr[2].ToString())), string.Format("{0:N0}", long.Parse(dr[3].ToString())), string.Format("{0:N0}", long.Parse(dr[4].ToString())), string.Format("{0:N3}", decimal.Parse(dr[5].ToString())), string.Format("{0:N0}", long.Parse(dr[6].ToString())) };
                    rows1.Add(str1);
                    lastTrack = dr[0].ToString();
                }
            }
            return rt;
        }
    }
}
