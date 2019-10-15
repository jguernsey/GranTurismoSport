using Jjg.GtsData.StatsData;
using System;
using System.Data;

namespace Jjg.GtsData.RaceCalendar
{
    public class FiaDetailProcessor
    {
        public void Process()
        {
            DateTime start = DateTime.Now;
            EventWriter writer = new EventWriter();
            writer.Write(string.Format("Start:FiaDetailProcessor:{0}", start));
            try
            {
                DataTable dt = new GetFiaEventsToUpdate().Get();
                new ProcessMissingFiaEvents().Process(dt);
            }
            catch (Exception exception)
            {
                writer.Write(exception.ToString());
            }
            TimeSpan ts = DateTime.Now.Subtract(start);
            DateTime now = DateTime.Now;
            writer.Write(string.Format("End:FiaDetailProcessor:{0}-Duration:{1}", now.ToString(), ts.ToString()));
        }
    }
}
