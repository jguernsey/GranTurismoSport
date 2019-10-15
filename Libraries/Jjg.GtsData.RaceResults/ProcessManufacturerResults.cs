using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class ProcessManufacturerResults
    {
        public void Process(ManufacturerResults mr)
        {
            long imrId = 0;
            try
            {
                imrId = new InsertManufacturerResults().Insert(mr);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            if (imrId > 0)
            {
                for (int i = 0; i < mr.point.Length; i++)
                {
                    try
                    {
                        InsertManufacturerPoints imp = new InsertManufacturerPoints();
                        imp.Insert(imrId, long.Parse(mr.point[i].ToString()), long.Parse(mr.event_result_id[i].ToString()));
                    }
                    catch (Exception exception1)
                    {
                        new EventWriter().Write(exception1.ToString());
                    }
                }
            }
        }
    }
}
