using System;
using System.Data;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class NumberGroupProcessor
	{
		public void Process(NumberGroup group)
		{
			DataTable dt = group.Numbers;
			if (dt.Rows.Count > 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					try
					{
						Int64 profileId = Int64.Parse(dr[0].ToString());
						Int64 profileNumber = Int64.Parse(dr[1].ToString());

						if (profileId != 0 && profileNumber >= 1000000)
						{
							ConvertUpdateStats cus = new ConvertUpdateStats();
							cus.Convert(profileId, profileNumber);
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
	}
}
