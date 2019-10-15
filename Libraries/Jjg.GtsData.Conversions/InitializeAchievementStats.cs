using Jjg.GtsData.Common;

namespace Jjg.GtsData.Conversions
{
	public class InitializeAchievementStats
	{
		public AchievementStats Initialize()
		{
			AchievementStats ach = new AchievementStats();
			ach.achievement_arcade = string.Empty;
			ach.achievement_history = string.Empty;
			ach.achievement_history_raw = string.Empty;
			ach.buy_car_count = "0";
			ach.campaign_progress = string.Empty;
			ach.car_count = "0";
			ach.credit_earned = "0";
			ach.level = "0";
			ach.level_progress = "0";
			ach.login_count = "0";
			ach.mileage_earned = "0";
			ach.nickname = string.Empty;
			ach.photo_count = string.Empty;
			ach.profile_color = string.Empty;
			ach.ride_car_id = string.Empty;
			ach.total_running_meter = "0";
			ach.xp = "0";
			return ach;
		}
	}
}
