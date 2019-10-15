using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToRaceCalendarArray
	{
		public RaceCalendarArray Convert(string content)
		{
			RaceCalendarArray rca = new RaceCalendarArray();
			try
			{
				rca = JsonConvert.DeserializeObject<RaceCalendarArray>(content);
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return rca;
		}
	}
}
