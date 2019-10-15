using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetCarsByCategoryId
	{
		public DataTable Get(Int64 categoryId)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("CarId", typeof(Int64));
			dt.Columns.Add("CarName", typeof(string));
			try
			{
				using (SqlConnection conn = new SqlConnection(DbConn.Get()))
				{
					SqlCommand cmd = new SqlCommand("GTS_Cars_SelectByCategoryId", conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("@CategoryId", SqlDbType.BigInt).Value = categoryId;
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					conn.Open();
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
