using Jjg.GtsData.StatsData;
using System;
using System.IO;
using System.Net;

namespace Jjg.GtsData.Requester
{ 
	public class CheckProfileNumber
	{
		public bool Check(Int64 profileNumber)
		{
			string url = string.Format("https://www.gran-turismo.com/us/api/gt7sp/profile/?job=1&user_no={0}", profileNumber);
            bool valid = true;
            try
            {
                string content = string.Empty;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                CookieContainer container = new CookieContainer();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.CookieContainer = container;
                request.KeepAlive = true;
                request.UseDefaultCredentials = false;
                request.Method = "POST";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream stream = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                content = reader.ReadToEnd();
                            }
                        }
                        if(!content.Contains("profile"))
                        {
                            valid = false;
                        }
                    }
                    else
                    {
                        valid = false;
                    }
                }
            }
            catch (Exception exception)
            {
                valid = false;
                EventWriter writer = new EventWriter();
                writer.Write(exception.ToString());
            }
            return valid;
		}
	}
}
