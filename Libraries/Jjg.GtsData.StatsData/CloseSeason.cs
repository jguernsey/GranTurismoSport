using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class CloseSeason
	{
		public void Close(Int64 seasonId)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(DbConn.Get()))
				{
					SqlCommand cmd = new SqlCommand("GTS_SeasonsClose", conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandTimeout = 0;
					cmd.Parameters.Add("@SeasonId", SqlDbType.BigInt).Value = seasonId;
					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
		}
	}
}
