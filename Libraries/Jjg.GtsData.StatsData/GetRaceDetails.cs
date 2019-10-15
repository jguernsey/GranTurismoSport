using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetRaceDetails
	{
        public DataTable Get(long raceHeaderId)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RaceHeaderId", typeof(long));
            dt.Columns.Add("RaceDetailsId", typeof(long));
            dt.Columns.Add("Driver", typeof(string));
            dt.Columns.Add("Rank", typeof(long));
            dt.Columns.Add("StartDR", typeof(long));
            dt.Columns.Add("EndDR", typeof(long));
            dt.Columns.Add("DRChange", typeof(long));
            dt.Columns.Add("StartPosition", typeof(long));
            dt.Columns.Add("EndPosition", typeof(long));
            dt.Columns.Add("PositionChange", typeof(long));
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RaceDetails_Select", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@RaceHeaderId", SqlDbType.BigInt).Value = raceHeaderId;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(dt);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return dt;
        }
    }
}
