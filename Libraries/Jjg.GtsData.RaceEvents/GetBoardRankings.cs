using System;
using System.Collections.Generic;
using System.Data;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.RaceEvents
{
	public class GetBoardRankings
	{
        public DataTable Get(List<RankingInfo> boardIds, string psnLogin)
        {
            DataTable rankings = new DataTable();
            rankings.Columns.Add("Race", typeof(string));
            rankings.Columns.Add("RegionRank", typeof(long));
            rankings.Columns.Add("RegionTotal", typeof(long));
            rankings.Columns.Add("WorldRank", typeof(long));
            rankings.Columns.Add("WorldTotal", typeof(long));
            rankings.Columns.Add("Time", typeof(string));
            rankings.Columns.Add("RegionGap", typeof(string));
            rankings.Columns.Add("WorldGap", typeof(string));
            rankings.Columns.Add("RegionNext", typeof(string));
            rankings.Columns.Add("WorldNext", typeof(string));
            foreach (RankingInfo ri in boardIds)
            {
                try
                {
                    RaceRanking rank = new GetUserRanking().Get(psnLogin, ri.BoardId);
                    DataRowCollection rows = rankings.Rows;
                    object[] raceTitle = new object[] { ri.RaceTitle, rank.RegionRank, rank.RegionTotal, rank.WorldRank, rank.WorldTotal, rank.Time, rank.RegionGap, rank.WorldGap, rank.RegionNext, rank.WorldNext };
                    rows.Add(raceTitle);
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
            }
            return rankings;
        }
    }
}
