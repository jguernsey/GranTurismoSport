using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.Profiles
{
    public class ProcessProfileGroups
    {
        public void Process(List<NumberGroup> groups, long totalCount)
        {
            DateTime start = DateTime.Now;
            EventWriter writer = new EventWriter();
            writer.Write(string.Format("Started at: {0}", start.ToString()));
            writer.Write(string.Format("ProcessProfileGroups - {0:N0} profiles", totalCount));
            if (totalCount > 0)
            {
                Task[] taskArray = new Task[] { Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[0])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[1])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[2])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[3])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[4])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[5])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[6])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[7])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[8])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[9])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[10])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[11])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[12])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[13])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[14])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[15])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[16])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[17])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[18])), Task.Factory.StartNew(() => this.ProcessProfileGroup(groups[19])) };
                Task.WaitAll(taskArray);
                TimeSpan ts = DateTime.Now.Subtract(start);
                decimal perSecond = Convert.ToDecimal(totalCount) / Convert.ToDecimal(ts.TotalSeconds);
                writer.Write(string.Format("GetNewProfiles::TC:{0}::T:{1}::PS:{2}", totalCount, ts.ToString(), perSecond));
            }
        }

        private void ProcessProfileGroup(NumberGroup group)
        {
            new ProfileGroupProcessor().Process(group);
        }
    }
}
