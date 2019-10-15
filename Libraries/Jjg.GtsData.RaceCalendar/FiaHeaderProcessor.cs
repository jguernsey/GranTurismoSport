using Jjg.GtsData.Requester;
using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.RaceCalendar
{
    public class FiaHeaderProcessor
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
            string[] regions = new string[] { "jp", "de", "us" };
            for (int i = 0; i < regions.Length; i++)
            {
                try
                {
                    writer.Write(string.Format("Region: {0} - Start Date: {1} - End Date: {2}", regions[i].ToString(), startDate.ToString(), endDate.ToString()));
                    new FiaRegionHeaderProcessor().Process(regions[i], startDate, endDate);
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
