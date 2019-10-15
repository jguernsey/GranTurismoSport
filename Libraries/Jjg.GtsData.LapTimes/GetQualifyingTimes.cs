using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.LapTimes
{
    public class GetQualifyingTimes
    {
        public void Get(string region, long boardId, long entryCount)
        {
            bool isEmpty = false;
            long startNumber = 1;
            long endNumber = 250;
            long interval = 250;
            if (entryCount >= 500)
            {
                endNumber = 500;
                interval = 500;
            }
            if (entryCount >= 1000)
            {
                endNumber = 1000;
                interval = 1000;
            }
            do
            {
                string content = new GetRankingRange().Get(region, boardId, startNumber, endNumber);
                if (string.IsNullOrEmpty(content))
                {
                    isEmpty = true;
                    return;
                }
                if (content.Contains("\r\n{\"ranking\":[]}\r\n"))
                {
                    isEmpty = true;
                    return;
                }
                RankingArray rankings = new ConvertToRankings().Convert(content);
                if (rankings.Ranking.Length <= 0)
                {
                    isEmpty = true;
                    return;
                }
                Ranking[] ranking = rankings.Ranking;
                for (int i = 0; i < ranking.Length; i++)
                {
                    Ranking r = ranking[i];
                    new InsertRankings().Insert(r);
                }
                if (rankings.Ranking.Length < interval)
                {
                    isEmpty = true;
                    return;
                }
                startNumber += interval;
                endNumber += interval;
            }
            while (!isEmpty);
        }
    }
}
