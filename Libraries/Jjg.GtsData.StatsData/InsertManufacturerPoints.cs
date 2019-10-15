using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class InsertManufacturerPoints
	{
        public void Insert(long resultId, long points, long eventResultId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_ManufacturerPoints_InsertUpdate", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@ResultId", SqlDbType.BigInt).Value = resultId;
                    cmd.Parameters.Add("@Points", SqlDbType.BigInt).Value = points;
                    cmd.Parameters.Add("@EventResultId", SqlDbType.BigInt).Value = eventResultId;
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
