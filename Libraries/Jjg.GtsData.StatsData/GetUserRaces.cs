using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetUserRaces
	{
        public DataTable Get(long profileId)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RaceHeaderId", typeof(long));
            dt.Columns.Add("RaceDate", typeof(DateTime));
            dt.Columns.Add("RaceType", typeof(string));
            dt.Columns.Add("TrackName", typeof(string));
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Columns.Add("RaceStatus", typeof(bool));
            dt.Columns.Add("CarName", typeof(string));
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RaceHeader_Select", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@ProfileId", SqlDbType.BigInt).Value = profileId;
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
            rt.Columns.Add("RaceHeaderId", typeof(long));
            rt.Columns.Add("RaceDate", typeof(DateTime));
            rt.Columns.Add("RaceType", typeof(string));
            rt.Columns.Add("TrackName", typeof(string));
            rt.Columns.Add("CategoryName", typeof(string));
            rt.Columns.Add("RaceStatus", typeof(bool));
            rt.Columns.Add("CarName", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                bool status = false;
                if (dr[5].ToString().Equals("true"))
                {
                    status = true;
                }
                DataRowCollection rows = rt.Rows;
                object[] objArray = new object[] { long.Parse(dr[0].ToString()), DateTime.Parse(dr[1].ToString()), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), status, dr[6].ToString() };
                rows.Add(objArray);
            }
            return rt;
        }
    }
}
