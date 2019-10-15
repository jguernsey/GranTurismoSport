using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class UpdateDriverRating
	{
        public void Update(long profileId, long driverRating, string updateType)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RealTimeDriverRating_Update", conn)
                    {
                        CommandTimeout = 0,
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@ProfileId", SqlDbType.BigInt).Value = profileId;
                    cmd.Parameters.Add("@DriverRating", SqlDbType.BigInt).Value = driverRating;
                    cmd.Parameters.Add("@UpdateType", SqlDbType.NVarChar).Value = updateType;
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
