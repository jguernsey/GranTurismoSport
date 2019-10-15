using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class FiaRegionHeaderProcessor
    {
        private readonly string[] channels = new string[] { "11", "12" };

        public void Process(string region, DateTime begin, DateTime end)
        {
            try
            {
                string[] strArrays = this.channels;
                for (int i = 0; i < strArrays.Length; i++)
                {
                    string writer = strArrays[i];
                    GetEventCalendar channel = new GetEventCalendar();
                    string gec = channel.Get(region, writer, begin.ToString("yyyy-MM-dd"), end.ToString("yyyy-MM-dd"));

                    RaceCalendarArray ctca = new ConvertToRaceCalendarArray().Convert(gec);
                    new ProcessFiaHeaders().Process(ctca.event_calendar);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
