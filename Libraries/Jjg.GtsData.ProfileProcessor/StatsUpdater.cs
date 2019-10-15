using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class StatsUpdater
	{
		public void Update(Int64 profileId, Int64 statId, Int64 year, Int64 month, string[] stats)
		{
			if (stats != null && stats.Length > 0)
			{
				try
				{
					int index = 1;
					foreach (string statValue in stats)
					{
						if (!statValue.Trim().Equals("0"))
						{
							InsertStats insertStats = new InsertStats();
							insertStats.Insert(profileId, statId, year, month, index, Int64.Parse(statValue));
						}
						index++;
					}
				}
				catch (Exception ex)
				{
					EventWriter writer = new EventWriter();
					writer.Write(ex.ToString());
				}
			}
		}
	}
}
