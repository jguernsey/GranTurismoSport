using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class RaceHeaderProcessor
    {
        public void Process()
        {
            DateTime start = DateTime.Now;
            EventWriter writer = new EventWriter();
            writer.Write(string.Format("Start:RaceHeaderProcessor:{0}", start));
            DateTime now = DateTime.Now;
            DateTime startDate = now.Subtract(TimeSpan.FromDays(4));
            DateTime dateTime = DateTime.Now;
            DateTime endDate = dateTime.Add(TimeSpan.FromDays(30));
            string[] regions = new string[] { "jp", "gb", "us", "au", "mx"};
            for (int i = 0; i < regions.Length; i++)
            {
                try
                {
                    writer.Write(string.Format("Region: {0} - Start Date: {1} - End Date: {2}", regions[i].ToString(), startDate.ToString(), endDate.ToString()));
                    new RegionHeaderProcessor().Process(regions[i], startDate, endDate);
                }
                catch (Exception exception)
                {
                    writer.Write(exception.ToString());
                }
            }
            TimeSpan ts = DateTime.Now.Subtract(start);
            DateTime now1 = DateTime.Now;
            writer.Write(string.Format("End:RaceHeaderProcessor:{0}-Duration:{1}", now1.ToString(), ts.ToString()));
        }
    }
}
