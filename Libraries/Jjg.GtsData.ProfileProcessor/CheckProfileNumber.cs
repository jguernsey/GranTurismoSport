using System;
using System.Net;

namespace Jjg.GtsData.ProfileProcessor
{
	public class CheckProfileNumber
	{
		public bool Check(Int64 profileNumber)
		{
			bool valid = true;
			try
			{
				string url = string.Format("https://www.gran-turismo.com/us/api/gt7sp/profile/?job=1&user_no={0}", profileNumber);
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				request.Method = "POST";
				request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:52.0) Gecko/20100101 Firefox/52.0";
				request.Timeout = 5000;
				using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
				{
					if (response.StatusCode != HttpStatusCode.OK)
					{
						valid = false;
					}
				}
			}
			catch
			{
				valid = false;
			}
			return valid;
		}
	}
}
