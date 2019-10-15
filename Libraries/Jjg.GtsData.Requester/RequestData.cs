using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Requester
{
	public class RequestData
	{
        public string Request(string url)
        {
            string content = string.Empty;
            try
            {
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
                        long requestBytes = new GetRequestBytes().Get(response);
                        if (requestBytes > 0)
                        {
                            new UpdateDataPullRequests().Update(requestBytes);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Exception ex = exception;
                if (ex.ToString().Contains("(403)") || ex.ToString().Contains("(504)"))
                {
                    new EventWriter().Write(ex.ToString());
                    Thread.Sleep(60000);
                }
            }
            return content;
        }
    }
}
