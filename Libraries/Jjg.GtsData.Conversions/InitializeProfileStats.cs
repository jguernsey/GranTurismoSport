using Jjg.GtsData.Common;

namespace Jjg.GtsData.Conversions
{
	public class InitializeProfileStats
	{
		public ProfileStats Initialize()
		{
			ProfileStats ps = new ProfileStats();
			UserStats us = new UserStats();
			us.user_no = "0";
			us.manufacturer_id = "0";
			us.stats = string.Empty;
			us.ugc_all_count = "0";
			us.ugc_photo_3_count = "0";
			us.ugc_photo_11_count = "0";
			us.ugc_livery_1_count = "0";
			us.ugc_livery_2_count = "0";
			us.ugc_livery_3_count = "0";
			us.ugc_decal_count = "0";
			us.ugc_replay_count = "0";
			us.comment = string.Empty;
			us.driver_class = "0";
			us.driver_point = "0";
			us.manner_point = "0";
			us.race_count = "0";
			us.driver_point_up_rate = "0";
			us.driver_photo_id = string.Empty;
			us.profile_photo_id = string.Empty;
			us.follower_count = "0";
			ps.Stats = us;
			return ps;
		}
	}
}
