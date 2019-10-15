using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class InsertRankings
	{
        public void Insert(Ranking ranking)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RaceRankings_InsertUpdate", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@BoardId", SqlDbType.BigInt).Value = ranking.Board_Id;
                    cmd.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = ranking.User_Id;
                    cmd.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Parse(ranking.Create_Time);
                    cmd.Parameters.Add("@Score", SqlDbType.BigInt).Value = ranking.Score;
                    cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value = ranking.User_Country;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
