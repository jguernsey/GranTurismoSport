using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.Conversions
{
	public class ConvertToManufacturerResults
	{
		public ManufacturerResultsArray Convert(string content)
		{
			ManufacturerResultsArray mra = new ManufacturerResultsArray();
			try
			{
				mra = JsonConvert.DeserializeObject<ManufacturerResultsArray>(content);
			}
			catch(Exception ex)
			{
				EventWriter w = new EventWriter();
				w.Write(ex.ToString());
			}
			return mra;
		}
	}
}
