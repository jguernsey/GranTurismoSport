using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetUserEvents
	{
		public string Get(string region, Int64 profileNumber)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/event/?job=5&user_no={1}", region, profileNumber);
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
