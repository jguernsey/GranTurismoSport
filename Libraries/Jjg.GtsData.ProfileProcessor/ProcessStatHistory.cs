using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class ProcessStatHistory
	{
		public void Process(StatHistory stats, Int64 profileId)
		{
			foreach (StatHistoryDetail history in stats.stats_history)
			{
				try
				{
					ProfileStatsUpdate update = new ProfileStatsUpdate();
					update.Update(history, profileId);
				}
				catch(Exception ex)
				{
					EventWriter writer = new EventWriter();
					writer.Write(ex.ToString());
				}
			}
		}
	}
}
