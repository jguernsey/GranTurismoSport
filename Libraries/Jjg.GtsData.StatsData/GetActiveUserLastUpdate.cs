using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetActiveUserLastUpdate
	{
		public DataTable Get(Int64 countryId, Int64 pageNumber)
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection conn = new SqlConnection(DbConn.Get()))
				{
					SqlCommand cmd = new SqlCommand("GTS_ActiveUserDetails_SelectAll", conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandTimeout = 0;
					cmd.Parameters.Add("@PageNumber", SqlDbType.BigInt).Value = pageNumber;
					cmd.Parameters.Add("@CountryId", SqlDbType.BigInt).Value = countryId;
					conn.Open();
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					da.Fill(dt);
				}
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return dt;
		}
	}
}
