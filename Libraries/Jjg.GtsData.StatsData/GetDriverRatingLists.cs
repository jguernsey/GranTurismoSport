using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Jjg.GtsData.StatsData
{
	public class GetDriverRatingLists
	{
        public List<object> Get(string username, DateTime startDate, DateTime endDate)
        {
            List<object> iData = new List<object>();
            List<string> labels = new List<string>();
            List<int> total = new List<int>();
            List<int> race = new List<int>();
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_GetRealTimeDriverRatingV3", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = username;
                    cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate.ToString();
                    cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = endDate.ToString();
                    cmd.CommandTimeout = 0;
                    new SqlDataAdapter(cmd).Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        labels.Add(dr[3].ToString());
                        total.Add(int.Parse(dr[1].ToString()));
                        race.Add(int.Parse(dr[2].ToString()));
                    }
                    iData.Add(labels);
                    iData.Add(total);
                    iData.Add(race);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return iData;
        }
    }
}
