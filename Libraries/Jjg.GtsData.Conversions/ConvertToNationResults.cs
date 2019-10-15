using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToNationResults
	{
		public NationResultsArray Convert(string content)
		{
			NationResultsArray nra = new NationResultsArray();
			if (!string.IsNullOrEmpty(content))
			{
				try
				{
					nra = JsonConvert.DeserializeObject<NationResultsArray>(content);
				}
				catch (Exception ex)
				{
					EventWriter writer = new EventWriter();
					writer.Write(ex.ToString());
				}
			}
			return nra;
		}
	}
}
