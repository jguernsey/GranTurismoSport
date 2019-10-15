using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToAchievementStats
	{
		public AchievementStats Convert(string content)
		{
			InitializeAchievementStats ias = new InitializeAchievementStats();
			AchievementStats ach = ias.Initialize();

			if (!string.IsNullOrEmpty(content))
			{
				try
				{
					ach = JsonConvert.DeserializeObject<AchievementStats>(content);
				}
				catch (Exception ex)
				{
					EventWriter writer = new EventWriter();
					writer.Write(ex.ToString());
				}
			}
			return ach;
		}

	}
}
