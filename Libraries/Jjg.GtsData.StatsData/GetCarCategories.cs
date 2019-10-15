using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetCarCategories
	{
		public DataTable Get()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("CategoryId", typeof(Int64));
			dt.Columns.Add("CategoryName", typeof(string));
			try
			{
				using (SqlConnection conn = new SqlConnection(DbConn.Get()))
				{
					SqlCommand cmd = new SqlCommand("GTS_CarCategories_Select", conn);
					cmd.CommandType = CommandType.StoredProcedure;
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
