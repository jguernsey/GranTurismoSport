using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetManufacturerRaceResults
	{
		public string Get(string region, Int64 seasonId, Int64 begin, Int64 end, Int64 manufacturerId)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/championship/?job=11&manufacturer_id={1}&season_id={2}&begin={3}&end={4}", region, manufacturerId, seasonId, begin, end);
				RequestData makeRequest = new RequestData();
				content = makeRequest.Request(url);
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return content;
		}
	}
}
