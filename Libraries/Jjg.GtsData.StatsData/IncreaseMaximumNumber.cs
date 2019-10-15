using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class IncreaseMaximumNumber
	{
        public void Update(long lastProfileNumber, long endPoint)
        {
            long numberIncrease = endPoint - lastProfileNumber;
            EventWriter writer = new EventWriter();
            if (numberIncrease <= 0)
            {
                writer.Write("No profiles number increase.");
            }
            else
            {
                writer.Write(string.Format("Adding {0} new profiles.", numberIncrease));
                try
                {
                    using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                    {
                        SqlCommand cmd = new SqlCommand("GTS_IncreaseMaximumNumber", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add("@NewMax", SqlDbType.BigInt).Value = endPoint;
                        cmd.CommandTimeout = 0;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception exception)
                {
                    writer.Write(exception.ToString());
                }
            }
        }
    }
}
