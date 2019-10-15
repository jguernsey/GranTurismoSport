using System;
using System.Data;
using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.RaceEvents
{
	public class GetCurrentDriverRating
	{
		public void Get(DataTable dt, string updateType)
		{
			foreach (DataRow dr in dt.Rows)
			{
				Int64 profileId = Int64.Parse(dr[0].ToString());
				Int64 profileNumber = Int64.Parse(dr[1].ToString());

				GetProfileDetails gpd = new GetProfileDetails();
				string content = gpd.Get(profileNumber);
				try
				{
					if (!string.IsNullOrEmpty(content))
					{
						ConvertToProfileStats ps = new ConvertToProfileStats();
						ProfileStats stats = ps.Convert(content);

						Int64 driverRating = 0;
						bool isValid = Int64.TryParse(stats.Stats.driver_point, out driverRating);

						if(isValid && driverRating > 0)
						{
							UpdateDriverRating udr = new UpdateDriverRating();
							udr.Update(profileId, driverRating, updateType);
						}
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
