using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class ProcessManufacturerSeason
    {
        public void Process(string region, long seasonId)
        {
            long[] manufacturers = new long[] { 3L, 4L, 5L, 6L, 7L, 9L, 11L, 13L, 15L, 16L, 17L, 21L, 22L, 25L, 28L, 32L, 38L, 43L, 46L, 50L, 62L, 110L, 112L, 114L, 117L, 136L };
            for (int i = 0; i < manufacturers.Length; i++)
            {
                new ProcessManufacturer().Process(region, seasonId, manufacturers[i]);
                new CloseSeason().Close(seasonId);
            }
        }
    }
}
