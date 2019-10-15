using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToRankings
	{
		public RankingArray Convert(string content)
		{
			RankingArray raceEvents = new RankingArray();
			try
			{
				raceEvents = JsonConvert.DeserializeObject<RankingArray>(content);
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return raceEvents;
		}
	}
}
