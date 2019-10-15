using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
    public class InsertCarCategories
    {
        public void Insert(string[] carCategories, long detailId)
        {
            string[] strArrays = carCategories;
            for (int i = 0; i < strArrays.Length; i++)
            {
                string car = strArrays[i];
                try
                {
                    using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                    {
                        SqlCommand cmd = new SqlCommand("GTS_RaceCars_Insert", conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                            CommandTimeout = 0
                        };
                        cmd.Parameters.Add("@RaceDetailId", SqlDbType.BigInt).Value = detailId;
                        cmd.Parameters.Add("@CarCategory", SqlDbType.NVarChar).Value = car;
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
}
