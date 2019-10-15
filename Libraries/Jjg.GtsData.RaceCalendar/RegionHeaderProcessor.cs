using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using Jjg.GtsData.Requester;
using Jjg.GtsData.Conversions;

namespace Jjg.GtsData.RaceCalendar
{
    public class RegionHeaderProcessor
    {
        private readonly string[] channels = new string[] { "1", "2", "3", "11", "12", "101", "102", "103" };

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
                    new ProcessRaceHeaders().Process(ctca.event_calendar);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
