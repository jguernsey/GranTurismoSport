using Jjg.GtsData.Common;
using Jjg.GtsData.Requester;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class GetRaceResults
    {
        public void Get(NumberGroup group)
        {
            foreach (DataRow dr in group.Numbers.Rows)
            {
                long profileNumber = long.Parse(dr[1].ToString());
                string region = dr[2].ToString();
                string content = new GetUserEvents().Get(region, profileNumber);
                new ResultContentReader().Read(content);
            }
        }
    }
}
