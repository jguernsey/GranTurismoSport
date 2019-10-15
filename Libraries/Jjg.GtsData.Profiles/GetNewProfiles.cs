using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System.Collections.Generic;

namespace Jjg.GtsData.Profiles
{
    public class GetNewProfiles
    {
        public void Get()
        {
            EventWriter writer = new EventWriter();

            long totalCount = 0;

            GetLastProfileNumber getLastProfileNumber = new GetLastProfileNumber();
            long lastProfileNumber = getLastProfileNumber.Get();

            writer.Write(string.Format("Last Profile Number: {0}", lastProfileNumber));

            GetEndPoint getEndPoint = new GetEndPoint();
            long endPoint = getEndPoint.Get(lastProfileNumber);

            writer.Write(string.Format("New Last Profile Number: {0}", endPoint));

            IncreaseMaximumNumber increaseMaximumNumber = new IncreaseMaximumNumber();
            increaseMaximumNumber.Update(lastProfileNumber, endPoint);

            GetProfileGroups getProfileGroups = new GetProfileGroups();
            List<NumberGroup> groups = getProfileGroups.Get(out totalCount);

            ProcessProfileGroups processProfileGroups = new ProcessProfileGroups();
            processProfileGroups.Process(groups, totalCount);
        }
    }
}
