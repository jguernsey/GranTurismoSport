using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToGtsEvent
	{
		public GtsEvent Convert(string content)
		{
			GtsEvent gtsEvent = new GtsEvent();
			try
			{
				gtsEvent = JsonConvert.DeserializeObject<GtsEvent>(content);
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return gtsEvent;
		}
	}
}
