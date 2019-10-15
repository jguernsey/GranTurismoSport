using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class ProcessNationsResults
    {
        public void Process(NationResults nr)
        {
            long resultId = 0;
            try
            {
                resultId = new InsertNationCupResults().Insert(nr);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            if (resultId > 0)
            {
                for (int i = 0; i < nr.point.Length; i++)
                {
                    try
                    {
                        InsertNationCupPoints incp = new InsertNationCupPoints();
                        incp.Insert(resultId, long.Parse(nr.point[i].ToString()), long.Parse(nr.event_result_id[i].ToString()));
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
