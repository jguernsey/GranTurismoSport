using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToSeasonInformation
	{
		public SeasonInformation Convert(string content)
		{
			SeasonInformation si = new SeasonInformation();
			if (!string.IsNullOrEmpty(content))
			{
				try
				{
					si = JsonConvert.DeserializeObject<SeasonInformation>(content);
				}
				catch (Exception ex)
				{
					EventWriter writer = new EventWriter();
					writer.Write(ex.ToString());
				}
			}
			return si;
		}
	}
}
