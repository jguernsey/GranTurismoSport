using System;
using System.Linq;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class GetUserProfile
	{
		public string Get(Int64 profileNumber)
		{
			string content = string.Empty;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/us/api/gt7sp/profile/?job=1&user_no={0}", profileNumber);
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
