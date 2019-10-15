using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class GetProfileGroups
	{
		public List<NumberGroup> Get(out Int64 totalCount)
		{
			totalCount = 0;
			List<NumberGroup> groups = new List<NumberGroup>();
			for (Int64 i = 1; i <= 15; i++)
			{
				DataTable dt = new DataTable();
				try
				{
					using (SqlConnection conn = new SqlConnection(DbConn.Get()))
					{
						SqlCommand cmd = new SqlCommand("GTS_GetNewProfileNumbers_Paged", conn);
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandTimeout = 0;
						cmd.Parameters.Add("@PageNumber", SqlDbType.BigInt).Value = i;
						conn.Open();
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						da.Fill(dt);
					}
					totalCount += dt.Rows.Count;

					NumberGroup tpg = new NumberGroup();
					tpg.GroupId = i;
					tpg.Numbers = dt;
					groups.Add(tpg);
				}
				catch (Exception ex)
				{
					EventWriter writer = new EventWriter();
					writer.Write(ex.ToString());
				}
			}
			return groups;
		}
	}
}
