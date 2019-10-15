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
    public class ConvertToSeasonsArray
    {
        public SeasonsArray Convert(string content)
        {
            SeasonsArray sa = new SeasonsArray();
            try
            {
                sa = JsonConvert.DeserializeObject<SeasonsArray>(content);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return sa;
        }
    }
}
