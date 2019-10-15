using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class GetNextUpdateTime
	{
        public DriverRatingUpdateTime Get()
        {
            DriverRatingUpdateTime dr = new DriverRatingUpdateTime()
            {
                TimeType = string.Empty,
                UpdateTime = DateTime.Now
            };
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_EventTimes_GetNextTime", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
                if (dt.Rows.Count == 1)
                {
                    dr.TimeType = dt.Rows[0][0].ToString();
                    dr.UpdateTime = DateTime.Parse(dt.Rows[0][1].ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return dr;
        }
    }
}
