using System;
using System.Collections.Generic;
using System.Data;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class GetOtherUsers
	{
		public List<NumberGroup> Get(Int64 countryId, out Int64 totalCount)
		{
			totalCount = 0;
			List<NumberGroup> groups = new List<NumberGroup>();
			for (int i = 1; i <= 15; i++)
			{
				try
				{
					GetOtherUserInfo goui = new GetOtherUserInfo();
					DataTable dt = goui.Get(countryId, i);
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
