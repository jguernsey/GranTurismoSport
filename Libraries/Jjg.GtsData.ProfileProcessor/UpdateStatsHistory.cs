using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class UpdateStatsHistory
	{
		public void Update(Int64 profileId, Int64 profileNumber, DateTime lastUpdate)
		{
			if (profileNumber >= 1000000)
			{
				StatDate endDate = new StatDate();
				endDate.StatYear = DateTime.Now.Year;
				endDate.StatMonth = DateTime.Now.Month;

				GetStatStartDate gssd = new GetStatStartDate();
				StatDate startDate = gssd.Get(lastUpdate);

				GetStatsHistory getHistory = new GetStatsHistory();
				string content = getHistory.Get(startDate.StatMonth, endDate.StatMonth, profileNumber, startDate.StatYear, endDate.StatYear);

				GetStatHistoryArray gsha = new GetStatHistoryArray();
				StatHistory stats = gsha.Get(content);

				ProcessStatHistory psh = new ProcessStatHistory();
				psh.Process(stats, profileId);

				UpdateLastUpdateDate updateDate = new UpdateLastUpdateDate();
				updateDate.Update(profileId);
			}
		}
	}
}
