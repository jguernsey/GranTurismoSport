using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class CreateEventDetail
    {
        public void Create(EventResults er)
        {
            long eventResultId = 0;
            long.TryParse(er.event_result_id, out eventResultId);
            long eventCalendarId = 0;
            long.TryParse(er.event_calendar_id, out eventCalendarId);
            try
            {
                Detail d = new ConvertToEventResultDetail().Convert(er.detail);
                if (d != null)
                {
                    Entry[] eventResult = d.event_result.entry;
                    for (int i = 0; i < eventResult.Length; i++)
                    {
                        Entry entry = eventResult[i];
                        new ProcessResultEntry().Process(entry, eventResultId, eventCalendarId);
                    }
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
