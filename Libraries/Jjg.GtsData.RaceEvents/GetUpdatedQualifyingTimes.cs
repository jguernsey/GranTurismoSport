using System;
using System.Data;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.RaceEvents
{
	public class GetUpdatedQualifyingTimes
	{
		public void Get()
		{
			GetDailyRaceInfo gdri = new GetDailyRaceInfo();
			DataTable dt = gdri.Get();

			if (dt.Rows.Count > 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					string region = dr[0].ToString();
					Int64 boardId = Int64.Parse(dr[1].ToString());
					Int64 entryCount = Int64.Parse(dr[2].ToString());

					GetQualifyingTimes gttl = new GetQualifyingTimes();
					gttl.Get(region, boardId, entryCount);

					UpdateRaceUpdateTimes urut = new UpdateRaceUpdateTimes();
					urut.Update(boardId);
				}
			}
		}
	}
}
