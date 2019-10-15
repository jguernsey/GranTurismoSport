using System;
using System.IO;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetSeasons
	{
		public string Get(string region)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/event/?job=10", region);
				RequestData makeRequest = new RequestData();
				content = makeRequest.Request(url);
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}

			content = content.Replace("{\"season_information\":", string.Empty);
			content = content.Replace("}]}]}}", "}]}]}");
			return content;
		}
	}
}
