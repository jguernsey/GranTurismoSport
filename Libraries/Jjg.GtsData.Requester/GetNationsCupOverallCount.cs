using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetNationsCupOverallCount
	{
		public string Get(string region, string country, Int64 seasonId)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/championship/?job=4&country={1}&season_id={2}", region, country, seasonId);
				RequestData mr = new RequestData();
				content = mr.Request(url);
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
