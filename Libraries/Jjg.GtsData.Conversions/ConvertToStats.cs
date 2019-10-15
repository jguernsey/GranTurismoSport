using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToStats
	{
		public UserStats Convert(string content)
		{
			UserStats stats = null;
			try
			{
				stats = JsonConvert.DeserializeObject<UserStats>(content);
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return stats;
		}
	}
}
