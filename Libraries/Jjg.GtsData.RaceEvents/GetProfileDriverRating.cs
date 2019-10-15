using System;
using System.Linq;
using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.RaceEvents
{
	public class GetProfileDriverRating
	{
		public Int64 Get(Int64 profileNumber)
		{
			Int64 driverRating = 0;
			if (profileNumber >= 1000000)
			{
				GetProfileDetails getProfileDetails = new GetProfileDetails();
				string content = getProfileDetails.Get(profileNumber);

				if (!string.IsNullOrEmpty(content))
				{
					try
					{
						ConvertToProfileStats ctps = new ConvertToProfileStats();
						ProfileStats ps = ctps.Convert(content);

						driverRating = Int64.Parse(ps.Stats.driver_point.ToString());
					}
					catch (Exception ex)
					{
						EventWriter writer = new EventWriter();
						writer.Write(ex.ToString());
					}
				}
			}
			return driverRating;
		}
	}
}
