using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetRankingRange
	{
		public string Get(string region, Int64 boardId, Int64 begin, Int64 end)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/ranking/?job=3&board_id={1}&begin={2}&end={3}", region, boardId, begin, end);
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
