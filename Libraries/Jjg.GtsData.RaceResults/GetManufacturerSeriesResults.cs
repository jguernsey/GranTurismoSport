using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class GetManufacturerSeriesResults
    {
        public void Get()
        {
            DateTime start = DateTime.Now;
            EventWriter writer = new EventWriter();
            writer.Write(string.Format("Start: GetManufacturerSeriesResults - {0}", start));
            DataTable dt = new GetChampionshipDetails().Get(12);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string region = dr[0].ToString();
                    long seasonId = long.Parse(dr[1].ToString());
                    if (string.IsNullOrEmpty(region) || seasonId <= 0)
                    {
                        continue;
                    }
                    new ProcessManufacturerSeason().Process(region, seasonId);
                }
            }
            TimeSpan ts = DateTime.Now.Subtract(start);
            DateTime now = DateTime.Now;
            writer.Write(string.Format("End: GetManufacturerSeriesResults - {0} - Duration: {1}", now.ToString(), ts.ToString()));
        }
    }
}
