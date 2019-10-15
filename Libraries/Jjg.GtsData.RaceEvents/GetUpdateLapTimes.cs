using Jjg.GtsData.StatsData;
using System;

namespace Jjg.GtsData.RaceEvents
{
    public class GetUpdateLapTimes
    {
        public void Update(string region, long boardId, long entryCount)
        {
            if (!string.IsNullOrEmpty(region) && boardId > 0)
            {
                try
                {
                    new GetQualifyingTimes().Get(region, boardId, entryCount);
                    new UpdateRaceUpdateTimes().Update(boardId);
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
            }
        }
    }
}
