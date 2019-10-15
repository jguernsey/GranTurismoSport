using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetUserBestLaps
	{
        public DataTable Get(string userId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_GetUserBestLaps", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
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
            rt.Columns.Add("Category", typeof(string));
            rt.Columns.Add("Score", typeof(string));
            rt.Columns.Add("World", typeof(string));
            rt.Columns.Add("Region", typeof(string));
            rt.Columns.Add("Country", typeof(string));
            rt.Columns.Add("Date", typeof(string));
            string lastTrack = string.Empty;
            foreach (DataRow dr in dt.Rows)
            {
                if (!dr[0].ToString().Equals(lastTrack))
                {
                    string track = dr[0].ToString();
                    DataRowCollection rows = rt.Rows;
                    object[] empty = new object[] { track, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };
                    rows.Add(empty);
                    string category = dr[1].ToString();
                    TimeSpan ts = TimeSpan.FromMilliseconds(double.Parse(dr[2].ToString()));
                    string score = ts.ToString("m\\:ss\\.fff");
                    string world = dr[3].ToString();
                    string region = dr[4].ToString();
                    string country = dr[5].ToString();
                    string date = dr[6].ToString().Replace(".000", string.Empty);
                    DataRowCollection dataRowCollection = rt.Rows;
                    object[] objArray = new object[] { category, score, world, region, country, date };
                    dataRowCollection.Add(objArray);
                    lastTrack = track;
                }
                else
                {
                    string category = dr[1].ToString();
                    TimeSpan ts = TimeSpan.FromMilliseconds(double.Parse(dr[2].ToString()));
                    string score = ts.ToString("m\\:ss\\.fff");
                    string world = dr[3].ToString();
                    string region = dr[4].ToString();
                    string country = dr[5].ToString();
                    string date = dr[6].ToString().Replace(".000", string.Empty);
                    DataRowCollection rows1 = rt.Rows;
                    object[] objArray1 = new object[] { category, score, world, region, country, date };
                    rows1.Add(objArray1);
                    lastTrack = dr[0].ToString();
                }
            }
            return rt;
        }
    }
}
