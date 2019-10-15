using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class ConvertUpdateStats
	{
		public void Convert(Int64 profileId, Int64 profileNumber)
		{
			GetProfileDetails getProfileStats = new GetProfileDetails();
			string content = getProfileStats.Get(profileNumber);
			try
			{
				if (!string.IsNullOrEmpty(content))
				{
					ConvertToProfileStats ps = new ConvertToProfileStats();
					ProfileStats stats = ps.Convert(content);

					ConvertToAchievementStats ctas = new ConvertToAchievementStats();
					AchievementStats ach = ctas.Convert(stats.Stats.stats);

					ConvertStringToArray csta = new ConvertStringToArray();
					Int64[] achievementHistory = csta.Convert(ach.achievement_history_raw);

					InsertAchievementHistory insertHistory = new InsertAchievementHistory();
					insertHistory.Insert(profileId, achievementHistory);

					UserStats us = new UserStats();
					us.manufacturer_id = NumberValidation(stats.Stats.manufacturer_id);
					us.driver_class = NumberValidation(stats.Stats.driver_class);
					us.driver_point = NumberValidation(stats.Stats.driver_point);
					us.manner_point = NumberValidation(stats.Stats.manner_point);
					us.race_count = NumberValidation(stats.Stats.race_count);
					us.driver_point_up_rate = NumberValidation(stats.Stats.driver_point_up_rate);

					InsertProfileStats insertStats = new InsertProfileStats();
					insertStats.Insert(profileId, ach, us);
				}
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
		}
		private string NumberValidation(string instr)
		{
			string outVal = "0";
			try
			{
				Int64 tempNumber = 0;
				bool isValid = Int64.TryParse(instr, out tempNumber);
				if(isValid)
				{
					outVal = tempNumber.ToString();
				}
				else
				{
					outVal = "0";
				}
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());

				outVal = "0";
			}
			return outVal;
		}
	}
}
