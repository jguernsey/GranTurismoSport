using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class ProcessSeasons
    {
        public void Process(SeasonsArray seasons, long regionId)
        {
            Season[] seasonArray = seasons.seasons;
            for (int i = 0; i < seasonArray.Length; i++)
            {
                Season season = seasonArray[i];
                try
                {
                    long seasonId = new InsertSeason().Insert(season, regionId);
                    if (seasonId > 0)
                    {
                        new ProcessSeasonRounds().Process(season.rounds, seasonId);
                    }
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
            }
        }
    }
}
