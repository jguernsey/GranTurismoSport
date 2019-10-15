using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.Conversions
{
    public class ConvertToEventResultDetail
    {
        public Detail Convert(string content)
        {
            Detail detail = new Detail();
            try
            {
                detail = JsonConvert.DeserializeObject<Detail>(content);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return detail;
        }
    }
}
