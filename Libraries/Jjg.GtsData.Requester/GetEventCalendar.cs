using System;
using System.IO;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetEventCalendar
	{
		public string Get(string region, string channels, string beginDate, string endDate)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/event/?job=2&channel_id_csv={1}&begin_date={2}&end_date={3}", region, channels, beginDate, endDate);
				RequestData request = new RequestData();
				content = request.Request(url);
                string fileName = string.Format("C:\\GTS\\Services\\Logs\\{0}_{1}_{2}_{3}.json", region, channels, beginDate, endDate);
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(content);
                }
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
