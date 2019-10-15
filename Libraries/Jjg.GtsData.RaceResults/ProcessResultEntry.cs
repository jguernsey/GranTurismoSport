using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class ProcessResultEntry
    {
        public void Process(Entry entry, long eventResultId, long eventCalendarId)
        {
            try
            {
                long lap = 0;
                long.TryParse(entry.lap, out lap);
                long leadLap = 0;
                long.TryParse(entry.lead_lap, out leadLap);
                long mannerPoint = 0;
                long.TryParse(entry.manner_point, out mannerPoint);
                long manufacturerId = 0;
                long.TryParse(entry.manufacturer_id, out manufacturerId);
                long qualifyRank = 0;
                long.TryParse(entry.qualify_rank, out qualifyRank);
                long rank = 0;
                long.TryParse(entry.rank, out rank);
                long userNo = 0;
                long.TryParse(entry.user_no, out userNo);
                InsertEventResults ier = new InsertEventResults();
                ier.Insert(eventResultId, eventCalendarId, lap, leadLap, mannerPoint, manufacturerId, qualifyRank, rank, userNo);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
