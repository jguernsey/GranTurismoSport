using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.LapTimes
{
    public class GetUpdatedQualifyingTimes
    {
        public void Get()
        {
            ProcessBoards processBoards = new ProcessBoards();
            processBoards.Process();
            new UpdateLapTimeRankings().Update();
        }
    }
}
