using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetStatsHistory
	{
		public string Get(Int64 startMonth, Int64 endMonth, Int64 profileNumber, Int64 startYear, Int64 endYear)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/us/api/gt7sp/profile/?job=12&month_begin={0}&month_end={1}&user_no={2}&year_begin={3}&year_end={4}", startMonth, endMonth, profileNumber, startYear, endYear);
				RequestData request = new RequestData();
				content = request.Request(url);
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
