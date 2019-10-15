using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetEventDetails
	{
		public string Get(string region, Int64 eventId)
		{
			string content = string.Empty;
			try
			{
				string detailUrl = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/event/?job=1&event_id_csv={1}", region, eventId);
				RequestData mr = new RequestData();
				content = mr.Request(detailUrl);
                if (content.StartsWith("\r\n{\"event\":[]}"))
				{
					content = string.Empty;
				}
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
