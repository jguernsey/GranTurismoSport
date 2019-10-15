using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Data;

namespace Jjg.GtsData.Profiles
{
    public class GetProfileGroups
    {
        public List<NumberGroup> Get(out long totalCount)
        {
            EventWriter groups = new EventWriter();
            DateTime now = DateTime.Now;
            groups.Write(string.Format("Started Getting Profile Groups: {0}", now.ToString()));
            totalCount = 0;
            List<NumberGroup> i = new List<NumberGroup>();
            for (long gpnp = 1; gpnp <= 20; gpnp += 1)
            {
                try
                {
                    DataTable tpg = new GetProfileNumbersPaged().Get(gpnp);
                    totalCount += tpg.Rows.Count;
                    NumberGroup ex = new NumberGroup()
                    {
                        GroupId = gpnp,
                        Numbers = tpg
                    };
                    i.Add(ex);
                }
                catch (Exception exception)
                {
                    groups.Write(exception.ToString());
                }
            }
            DateTime dateTime = DateTime.Now;
            groups.Write(string.Format("Done Getting Profile Groups: {0}", dateTime.ToString()));
            return i;
        }
    }
}
