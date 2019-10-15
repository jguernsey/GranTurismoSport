using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.Requester
{
    public class GetManufacturerResults
    {
        public string Get(string region, long seasonId, long begin, long end, long manufacturerId)
        {
            string content = string.Empty;
            try
            {
                object[] objArray = new object[] { region, manufacturerId, seasonId, begin, end };
                string url = string.Format("https://www.gran-turismo.com/{0}/api/gt7sp/championship/?job=11&manufacturer_id={1}&season_id={2}&begin={3}&end={4}", objArray);
                content = new RequestData().Request(url);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return content;
        }
    }
}
