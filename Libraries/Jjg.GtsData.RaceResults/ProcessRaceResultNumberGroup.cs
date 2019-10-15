using Jjg.GtsData.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class ProcessRaceResultNumberGroup
    {
        public void Process(List<NumberGroup> groups)
        {
            Task[] taskArray = new Task[] { Task.Factory.StartNew(() => new GetRaceResults().Get(groups[0])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[1])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[2])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[3])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[4])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[5])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[6])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[7])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[8])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[9])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[10])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[11])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[12])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[13])), Task.Factory.StartNew(() => new GetRaceResults().Get(groups[14])) };
            Task.WaitAll(taskArray);
        }
    }
}
