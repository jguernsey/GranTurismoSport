using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetManufacturerSeriesOverallCount
	{
		public string Get(string region, Int64 manufacturerId, Int64 seasonId)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/championship/?job=10&manufacturer_id={1}&season_id={2}", region, manufacturerId, seasonId);
				RequestData mr = new RequestData();
				content = mr.Request(url);
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
