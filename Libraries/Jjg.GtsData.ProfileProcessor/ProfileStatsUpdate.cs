using System;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.ProfileProcessor
{
	public class ProfileStatsUpdate
	{
		public void Update(StatHistoryDetail history, Int64 profileId)
		{
			Int64 year = Int64.Parse(history.Year);
			Int64 month = Int64.Parse(history.Month);

			UpdateStatsOne statsOne = new UpdateStatsOne();
			statsOne.Update(profileId, year, month, history);

			UpdateStatsTwo statsTwo = new UpdateStatsTwo();
			statsTwo.Update(profileId, year, month, history);

			UpdateStatsThree statsThree = new UpdateStatsThree();
			statsThree.Update(profileId, year, month, history);

			UpdateStatsFour statsFour = new UpdateStatsFour();
			statsFour.Update(profileId, year, month, history);

			UpdateStatsFive statsFive = new UpdateStatsFive();
			statsFive.Update(profileId, year, month, history);

			UpdateStatsSix statsSix = new UpdateStatsSix();
			statsSix.Update(profileId, year, month, history);

			UpdateStatsSeven statsSeven = new UpdateStatsSeven();
			statsSeven.Update(profileId, year, month, history);

			UpdateStatsEleven statsEleven = new UpdateStatsEleven();
			statsEleven.Update(profileId, year, month, history);

			UpdateStatsTwelve statsTwelve = new UpdateStatsTwelve();
			statsTwelve.Update(profileId, year, month, history);

			UpdateStatsThirteen statsThirteen = new UpdateStatsThirteen();
			statsThirteen.Update(profileId, year, month, history);
		}
	}
}
