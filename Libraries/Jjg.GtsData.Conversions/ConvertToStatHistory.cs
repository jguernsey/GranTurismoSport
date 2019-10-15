using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToStatHistory
	{
		public StatHistory Convert(string content)
		{
			StatHistory statHistory = new StatHistory();
			try
			{
				statHistory = JsonConvert.DeserializeObject<StatHistory>(content);
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return statHistory;
		}
	}
}
