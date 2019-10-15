using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetCarsByManufacturer
	{
		public DataTable Get(Int64 manufacturerId)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("CarId", typeof(Int64));
			dt.Columns.Add("CarName", typeof(string));
			try
			{
				using (SqlConnection conn = new SqlConnection(DbConn.Get()))
				{
					SqlCommand cmd = new SqlCommand("GTS_Cars_SelectByManufacturerId", conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("@ManufacturerId", SqlDbType.BigInt).Value = manufacturerId;
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
