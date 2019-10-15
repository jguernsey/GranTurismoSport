using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class DailyRaceResults
    {
        public void Get()
        {
            long totalCount = 0;
            DateTime start = DateTime.Now;
            List<NumberGroup> numbers = new GetRegisteredUserDetails().Get(out totalCount);
            EventWriter writer = new EventWriter();
            writer.Write(string.Format("Start:GetRegisteredRaceResults:{0}-Count:{1:N0}", start.ToString(), totalCount));
            new ProcessRaceResultNumberGroup().Process(numbers);
            TimeSpan ts = DateTime.Now.Subtract(start);
            DateTime now = DateTime.Now;
            writer.Write(string.Format("End:GetRegisteredRaceResults:{0}-Duration:{1}", now.ToString(), ts.ToString()));
        }
    }
}
