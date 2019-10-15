using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.Requester
{
    public class GetRequestBytes
    {
        public long Get(HttpWebResponse response)
        {
            long requestBytes = 0;
            try
            {
                if (response != null)
                {
                    requestBytes = !long.TryParse(response.ContentLength.ToString(), out requestBytes) ? 0 : response.ContentLength;
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return requestBytes;
        }
    }
}
