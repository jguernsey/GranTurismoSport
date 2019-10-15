using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetRaceHistory
	{
        public DataTable Get(string username)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RaceResults_SelectHistory", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = username;
                    cmd.CommandTimeout = 0;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(dt);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            DataTable rt = new DataTable();
            rt.Columns.Add("Time", typeof(string));
            rt.Columns.Add("Type", typeof(string));
            rt.Columns.Add("Track", typeof(string));
            rt.Columns.Add("Category", typeof(string));
            rt.Columns.Add("Qualified", typeof(string));
            rt.Columns.Add("SR", typeof(string));
            rt.Columns.Add("Finish", typeof(string));
            rt.Columns.Add("Change", typeof(string));
            if (dt.Rows.Count > 0)
            {
                string lastDate = string.Empty;
                foreach (DataRow dr in dt.Rows)
                {
                    DateTime dateTime = DateTime.Parse(dr[0].ToString());
                    string date = dateTime.ToShortDateString();
                    string time = dateTime.ToShortTimeString();
                    string type = dr[1].ToString();
                    string track = dr[2].ToString();
                    string category = dr[6].ToString();
                    string qualified = dr[8].ToString();
                    string sr = dr[11].ToString();
                    string finished = dr[12].ToString();
                    string change = dr[13].ToString();
                    if (!lastDate.Equals(date))
                    {
                        DataRowCollection rows = rt.Rows;
                        object[] empty = new object[] { date, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };
                        rows.Add(empty);
                        DataRowCollection dataRowCollection = rt.Rows;
                        object[] objArray = new object[] { time, type, track, category, qualified, sr, finished, change };
                        dataRowCollection.Add(objArray);
                        lastDate = date;
                    }
                    else
                    {
                        DataRowCollection rows1 = rt.Rows;
                        object[] objArray1 = new object[] { time, type, track, category, qualified, sr, finished, change };
                        rows1.Add(objArray1);
                        lastDate = date;
                    }
                }
            }
            return rt;
        }
    }
}
