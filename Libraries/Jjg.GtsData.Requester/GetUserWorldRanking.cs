using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetUserWorldRanking
	{
		public string Get(string region, Int64 boardId, Int64 userNumber)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/ranking/?job=2&board_id={1}&user_no={2}", region, boardId, userNumber);
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
