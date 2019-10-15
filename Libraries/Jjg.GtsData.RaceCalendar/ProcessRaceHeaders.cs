using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;

namespace Jjg.GtsData.RaceCalendar
{
    public class ProcessRaceHeaders
    {
        public void Process(RaceCalendarEvent[] events)
        {
            EventWriter writer = new EventWriter();
            if (events != null)
            {
                RaceCalendarEvent[] raceCalendarEventArray = events;
                for (int i = 0; i < raceCalendarEventArray.Length; i++)
                {
                    RaceCalendarEvent rce = raceCalendarEventArray[i];

                    try
                    {
                        new InsertRaceCalendar().Insert(rce);
                    }
                    catch (Exception exception)
                    {
                        writer.Write(exception.ToString());
                    }
                }
            }
        }
    }
}
