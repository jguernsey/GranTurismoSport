using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class GetNationsCupResults
    {
        public void Get()
        {
            DateTime start = DateTime.Now;
            EventWriter writer = new EventWriter();
            writer.Write(string.Format("Start: GetNationsCupResults - {0}", start));
            DataTable dt = new GetChampionshipDetails().Get(11);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string region = dr[0].ToString();
                    long seasonId = long.Parse(dr[1].ToString());
                    new RequestNationsResultsLoop().Request(region, seasonId);
                    new CloseSeason().Close(seasonId);
                }
            }
            TimeSpan ts = DateTime.Now.Subtract(start);
            DateTime now = DateTime.Now;
            writer.Write(string.Format("End: GetNationsCupResults - {0} - Duration: {1}", now.ToString(), ts.ToString()));
        }
    }
}
