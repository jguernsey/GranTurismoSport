using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class InsertProfileStats
	{
        public void Insert(long profileId, AchievementStats ach, UserStats stats)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_ProfileStats_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@ProfileId", SqlDbType.BigInt).Value = profileId;
                    cmd.Parameters.Add("@ManufacturerId", SqlDbType.BigInt).Value = long.Parse(stats.manufacturer_id);
                    cmd.Parameters.Add("@PurchasedCars", SqlDbType.BigInt).Value = long.Parse(ach.buy_car_count);
                    cmd.Parameters.Add("@CarCount", SqlDbType.BigInt).Value = long.Parse(ach.car_count);
                    cmd.Parameters.Add("@CreditEarned", SqlDbType.BigInt).Value = long.Parse(ach.credit_earned);
                    cmd.Parameters.Add("@Level", SqlDbType.BigInt).Value = long.Parse(ach.level);
                    cmd.Parameters.Add("@LevelProgress", SqlDbType.BigInt).Value = long.Parse(ach.level_progress);
                    cmd.Parameters.Add("@LoginCount", SqlDbType.BigInt).Value = long.Parse(ach.login_count);
                    cmd.Parameters.Add("@MileageEarned", SqlDbType.BigInt).Value = long.Parse(ach.mileage_earned);
                    cmd.Parameters.Add("@TotalRunningMeter", SqlDbType.BigInt).Value = long.Parse(ach.total_running_meter);
                    cmd.Parameters.Add("@Experience", SqlDbType.BigInt).Value = long.Parse(ach.xp);
                    cmd.Parameters.Add("@DriverClass", SqlDbType.BigInt).Value = long.Parse(stats.driver_class);
                    cmd.Parameters.Add("@DriverPoint", SqlDbType.BigInt).Value = long.Parse(stats.driver_point);
                    cmd.Parameters.Add("@MannerPoint", SqlDbType.BigInt).Value = long.Parse(stats.manner_point);
                    cmd.Parameters.Add("@RaceCount", SqlDbType.BigInt).Value = long.Parse(stats.race_count);
                    cmd.Parameters.Add("@DriverPointUpRate", SqlDbType.BigInt).Value = long.Parse(stats.driver_point_up_rate);
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
