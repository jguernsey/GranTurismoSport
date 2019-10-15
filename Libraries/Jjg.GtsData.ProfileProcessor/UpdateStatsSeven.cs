using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class UpdateStatsSeven
	{
		public void Update(Int64 profileId, Int64 year, Int64 month, StatHistoryDetail stats)
		{
			try
			{
				StatsUpdater stats1 = new StatsUpdater();
				stats1.Update(profileId, 7, year, month, stats.Stats7);
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
		}
	}
}
