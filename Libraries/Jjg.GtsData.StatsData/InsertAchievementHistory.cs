using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class InsertAchievementHistory
	{
        public void Insert(long profileId, long[] values)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_AchievementHistory_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@ProfileId", SqlDbType.BigInt).Value = profileId;
                    cmd.Parameters.Add("@PlayTime", SqlDbType.BigInt).Value = values[0];
                    cmd.Parameters.Add("@DistanceDriven", SqlDbType.BigInt).Value = values[1];
                    cmd.Parameters.Add("@TimeDriven", SqlDbType.BigInt).Value = values[2];
                    cmd.Parameters.Add("@FuelConsumed", SqlDbType.BigInt).Value = values[3];
                    cmd.Parameters.Add("@DriftPoints", SqlDbType.BigInt).Value = values[4];
                    cmd.Parameters.Add("@PrizeCredits", SqlDbType.BigInt).Value = values[5];
                    cmd.Parameters.Add("@MileagePointsEarned", SqlDbType.BigInt).Value = values[6];
                    cmd.Parameters.Add("@MileagePointsUsed", SqlDbType.BigInt).Value = values[7];
                    cmd.Parameters.Add("@CarsPurchased", SqlDbType.BigInt).Value = values[8];
                    cmd.Parameters.Add("@ValueofCarsPurchased", SqlDbType.BigInt).Value = values[9];
                    cmd.Parameters.Add("@CleanRaces", SqlDbType.BigInt).Value = values[10];
                    cmd.Parameters.Add("@PolePositions", SqlDbType.BigInt).Value = values[11];
                    cmd.Parameters.Add("@FastestLaps", SqlDbType.BigInt).Value = values[12];
                    cmd.Parameters.Add("@RacesFinished", SqlDbType.BigInt).Value = values[13];
                    cmd.Parameters.Add("@Wins", SqlDbType.BigInt).Value = values[14];
                    cmd.Parameters.Add("@PhotosTaken", SqlDbType.BigInt).Value = values[15];
                    cmd.Parameters.Add("@LiveryCreated", SqlDbType.BigInt).Value = values[16];
                    cmd.Parameters.Add("@PhotoLikes", SqlDbType.BigInt).Value = values[17];
                    cmd.Parameters.Add("@LiveryLikes", SqlDbType.BigInt).Value = values[18];
                    cmd.Parameters.Add("@DaysLoggedIn", SqlDbType.BigInt).Value = values[19];
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
