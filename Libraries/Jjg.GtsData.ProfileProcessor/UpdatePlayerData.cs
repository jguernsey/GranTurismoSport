using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class UpdatePlayerData
	{
		public void Update(string playerId)
		{
			GetProfileNumber getProfileNumber = new GetProfileNumber();
			Int64 profileNumber = getProfileNumber.Get(playerId);
			if (profileNumber >= 1000000)
			{
				GetProfileId getProfileId = new GetProfileId();
				Int64 profileId = getProfileId.Get(playerId);

				ConvertUpdateStats cus = new ConvertUpdateStats();
				cus.Convert(profileId, profileNumber);
			}
		}
	}
}
