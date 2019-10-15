using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class ProcessFiaHeaders
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
                        new InsertFiaRaceCalendar().Insert(rce);
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
