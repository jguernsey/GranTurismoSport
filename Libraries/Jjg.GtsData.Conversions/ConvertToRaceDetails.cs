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
    public class ConvertToRaceDetails
    {
        public GtsRaces Convert(string content)
        {
            GtsRaces raceEvents = new GtsRaces();
            try
            {
                raceEvents = JsonConvert.DeserializeObject<GtsRaces>(content);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return raceEvents;
        }
    }
}
