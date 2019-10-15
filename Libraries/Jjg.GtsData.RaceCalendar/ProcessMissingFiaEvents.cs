using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class ProcessMissingFiaEvents
    {
        public void Process(DataTable dt)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string region = dr[0].ToString();
                        long regionId = long.Parse(dr[1].ToString());
                        long eventId = long.Parse(dr[2].ToString());
                        string content = new GetEventDetails().Get(region, eventId);
                        new EventContentReader().Read(content, regionId);
                    }
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
