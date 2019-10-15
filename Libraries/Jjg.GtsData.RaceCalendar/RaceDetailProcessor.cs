using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class RaceDetailProcessor
    {
        public void Process()
        {
            DateTime start = DateTime.Now;
            EventWriter writer = new EventWriter();
            writer.Write(string.Format("Start:RaceDetailProcessor:{0}", start));
            try
            {
                DataTable dt = new GetEventsToUpdate().Get();
                new ProcessMissingEvents().Process(dt);
            }
            catch (Exception exception)
            {
                writer.Write(exception.ToString());
            }
            TimeSpan ts = DateTime.Now.Subtract(start);
            DateTime now = DateTime.Now;
            writer.Write(string.Format("End:RaceDetailProcessor:{0}-Duration:{1}", now.ToString(), ts.ToString()));
        }
    }
}
