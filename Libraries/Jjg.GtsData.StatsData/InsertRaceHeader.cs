using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class InsertRaceHeader
	{
        public long Insert(long profileId, long raceTypeId, long carClassId, long trackId, long carId)
        {
            long raceHeaderId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_RaceHeader_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@ProfileId", SqlDbType.BigInt).Value = profileId;
                    cmd.Parameters.Add("@RaceTypeId", SqlDbType.BigInt).Value = raceTypeId;
                    cmd.Parameters.Add("@ClassId", SqlDbType.BigInt).Value = carClassId;
                    cmd.Parameters.Add("@TrackId", SqlDbType.BigInt).Value = trackId;
                    cmd.Parameters.Add("@CarId", SqlDbType.BigInt).Value = carId;
                    conn.Open();
                    raceHeaderId = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return raceHeaderId;
        }
    }
}
