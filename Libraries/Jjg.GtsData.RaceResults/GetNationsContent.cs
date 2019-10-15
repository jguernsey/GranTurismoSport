using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class GetNationsContent
    {
        public string Get(string region, long seasonId, long startNumber, long endNumber)
        {
            string content = string.Empty;
            try
            {
                content = new GetNationsCupRaceResults().Get(region, seasonId, startNumber, endNumber);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            if (content.Length < 200)
            {
                content = string.Empty;
            }
            return content;
        }
    }
}
