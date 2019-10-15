using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetChannelDetails
	{
		public string Get(string region, int channelId)
		{
			string channelDetails = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/event/?job=3&channel_id_csv={1}", region, channelId);
				RequestData makeRequest = new RequestData();
				channelDetails = makeRequest.Request(url);
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return channelDetails;
		}
	}
}
