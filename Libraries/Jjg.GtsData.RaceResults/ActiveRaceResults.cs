using Jjg.GtsData.ProfileProcessor;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class ActiveRaceResults
    {
        public void Get()
        {
            foreach (DataRow dr in new GetCountryList().Get().Rows)
            {
                long totalCount = 0;
                EventWriter writer = new EventWriter();
                long countryId = long.Parse(dr[0].ToString());
                if (countryId <= 0)
                {
                    continue;
                }
                GetActiveUsers getActiveUsers = new GetActiveUsers();
                List<NumberGroup> numbers = getActiveUsers.Get(countryId, out totalCount);
                DateTime start = DateTime.Now;
                writer.Write(string.Format("Start:GetActiveRaceResults:{0}-Count:{1:N0}-Country:{2}", start.ToString(), totalCount, countryId));
                new ProcessRaceResultNumberGroup().Process(numbers);
                TimeSpan ts = DateTime.Now.Subtract(start);
                DateTime now = DateTime.Now;
                writer.Write(string.Format("End:GetActiveRaceResults:{0}-Duration:{1}", now.ToString(), ts.ToString()));
            }
        }
    }
}
