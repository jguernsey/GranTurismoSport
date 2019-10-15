using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetRaceAverages
	{
        public DataTable Get(string userId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RaceAverages", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
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
            rt.Columns.Add("Category", typeof(string));
            rt.Columns.Add("Races", typeof(string));
            rt.Columns.Add("MaxLed", typeof(string));
            rt.Columns.Add("AvgSR", typeof(string));
            rt.Columns.Add("MinSR", typeof(string));
            rt.Columns.Add("MaxSR", typeof(string));
            rt.Columns.Add("AvgQ", typeof(string));
            rt.Columns.Add("WorstQ", typeof(string));
            rt.Columns.Add("BestQ", typeof(string));
            rt.Columns.Add("AvgF", typeof(string));
            rt.Columns.Add("WorstF", typeof(string));
            rt.Columns.Add("BestF", typeof(string));
            if (dt.Rows.Count > 0)
            {
                string lastTrack = string.Empty;
                foreach (DataRow dr in dt.Rows)
                {
                    string track = dr[0].ToString();
                    string category = dr[1].ToString();
                    string races = dr[3].ToString();
                    string maxLed = dr[5].ToString();
                    string avgSr = dr[6].ToString();
                    string minSr = dr[8].ToString();
                    string maxSr = dr[7].ToString();
                    string avgQ = dr[9].ToString();
                    string worstQ = dr[10].ToString();
                    string bestQ = dr[11].ToString();
                    string avgF = dr[12].ToString();
                    string worstF = dr[14].ToString();
                    string bestF = dr[13].ToString();
                    if (!lastTrack.Equals(track))
                    {
                        DataRowCollection rows = rt.Rows;
                        object[] empty = new object[] { track, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };
                        rows.Add(empty);
                        DataRowCollection dataRowCollection = rt.Rows;
                        object[] objArray = new object[] { category, races, maxLed, avgSr, minSr, maxSr, avgQ, worstQ, bestQ, avgF, worstF, bestF };
                        dataRowCollection.Add(objArray);
                        lastTrack = track;
                    }
                    else
                    {
                        DataRowCollection rows1 = rt.Rows;
                        object[] objArray1 = new object[] { category, races, maxLed, avgSr, minSr, maxSr, avgQ, worstQ, bestQ, avgF, worstF, bestF };
                        rows1.Add(objArray1);
                        lastTrack = track;
                    }
                }
            }
            return rt;
        }
    }
}
