using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.RaceEvents
{
	public class GetQualifyingTimes
	{
		public void Get(string region, Int64 boardId, Int64 entryCount)
		{
			bool isEmpty = false;
			Int64 startNumber = 1;
			Int64 endNumber = 100;
			Int64 interval = 100;

			if(entryCount >= 500)
			{
				endNumber = 500;
				interval = 500;
			}
            if(entryCount >= 1000)
            {
                endNumber = 1000;
                interval = 1000;
            }

			do
			{
				GetRankingRange grr = new GetRankingRange();
				string content = grr.Get(region, boardId, startNumber, endNumber);

				if (!string.IsNullOrEmpty(content))
				{
					if (content.Contains("\r\n{\"ranking\":[]}\r\n"))
					{
						isEmpty = true;
						break;
					}
					else
					{
						ConvertToRankings ctr = new ConvertToRankings();
						RankingArray rankings = ctr.Convert(content);
						if (rankings.Ranking.Length > 0)
						{
							foreach (Ranking r in rankings.Ranking)
							{
								InsertRankings ir = new InsertRankings();
								ir.Insert(r);
							}
						}
						else
						{
							isEmpty = true;
							break;
						}
						if(rankings.Ranking.Length < interval)
						{
							isEmpty = true;
							break;
						}
					}
				}
				else
				{
					isEmpty = true;
					break;
				}
				startNumber = startNumber + interval;
				endNumber = endNumber + interval;
			} while (!isEmpty);
		}
	}
}
