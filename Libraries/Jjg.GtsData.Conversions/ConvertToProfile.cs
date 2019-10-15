using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToProfile
	{
		public UserProfile Convert(string content)
		{
			UserProfile up = new UserProfile();
			try
			{
				up = JsonConvert.DeserializeObject<UserProfile>(content);
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return up;
		}
	}
}
