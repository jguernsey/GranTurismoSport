using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetManufacturerSeriesUserRanking
	{
		public string Get(string region, Int64 seasonId, Int64 userNumber)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/championship/?job=8&season_id={1}&user_no={2}", region, seasonId, userNumber);
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
