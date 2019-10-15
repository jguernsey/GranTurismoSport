using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetNationsCupRaceResults
	{
		public string Get(string region, Int64 seasonId, Int64 begin, Int64 end)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/championship/?job=5&season_id={1}&begin={2}&end={3}", region, seasonId, begin, end);
				RequestData makeRequest = new RequestData();
				content = makeRequest.Request(url);
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return content;
		}
	}
}
