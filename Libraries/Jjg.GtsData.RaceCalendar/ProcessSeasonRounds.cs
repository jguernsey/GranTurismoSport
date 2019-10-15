using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class ProcessSeasonRounds
    {
        public void Process(Round[] rounds, long seasonId)
        {
            for (int i = 0; i < rounds.Length; i++)
            {
                try
                {
                    InsertSeasonRound isr = new InsertSeasonRound();
                    isr.Insert(seasonId, rounds[i].round_id.SafeToLong(), rounds[i].start_date.SafeDateTime(), rounds[i].end_date.SafeDateTime(), rounds[i].event_id.SafeToLong());
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
            }
        }
    }
}
