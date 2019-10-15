using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetTrackRecords
	{
        public DataTable Get()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RacesFastestLap_World", conn)
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
            rt.Columns.Add("Driver", typeof(string));
            rt.Columns.Add("ImagePath", typeof(string));
            rt.Columns.Add("Time", typeof(string));
            rt.Columns.Add("Date", typeof(string));
            int index = 0;
            string lastTrack = string.Empty;
            foreach (DataRow dr in dt.Rows)
            {
                if (index == 0)
                {
                    DataRowCollection rows = rt.Rows;
                    object[] str = new object[] { dr[0].ToString(), string.Empty, string.Empty, string.Empty, string.Empty };
                    rows.Add(str);
                    TimeSpan tsa = TimeSpan.FromMilliseconds(double.Parse(dr[4].ToString()));
                    string dtea = dr[5].ToString().Replace(".000", string.Empty);
                    DataRowCollection dataRowCollection = rt.Rows;
                    object[] objArray = new object[] { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), tsa.ToString("m\\:ss\\.fff"), dtea };
                    dataRowCollection.Add(objArray);
                    lastTrack = dr[0].ToString();
                }
                else if (!dr[0].ToString().Equals(lastTrack))
                {
                    DataRowCollection rows1 = rt.Rows;
                    object[] str1 = new object[] { dr[0].ToString(), string.Empty, string.Empty, string.Empty, string.Empty };
                    rows1.Add(str1);
                    TimeSpan tsa = TimeSpan.FromMilliseconds(double.Parse(dr[4].ToString()));
                    string dtea = dr[5].ToString().Replace(".000", string.Empty);
                    DataRowCollection dataRowCollection1 = rt.Rows;
                    object[] objArray1 = new object[] { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), tsa.ToString("m\\:ss\\.fff"), dtea };
                    dataRowCollection1.Add(objArray1);
                    lastTrack = dr[0].ToString();
                }
                else
                {
                    TimeSpan tsa = TimeSpan.FromMilliseconds(double.Parse(dr[4].ToString()));
                    string dtea = dr[5].ToString().Replace(".000", string.Empty);
                    DataRowCollection rows2 = rt.Rows;
                    object[] str2 = new object[] { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), tsa.ToString("m\\:ss\\.fff"), dtea };
                    rows2.Add(str2);
                    lastTrack = dr[0].ToString();
                }
                index++;
            }
            return rt;
        }
    }
}
