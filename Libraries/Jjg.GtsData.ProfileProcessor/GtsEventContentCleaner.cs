using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class GtsEventContentCleaner
	{
		public string Clean(string content)
		{
			string cleanString = string.Empty;
			try
			{
				cleanString = content.Replace("{\"event_result\":[{", "{event_results:[{");
				cleanString = cleanString.Replace("_", string.Empty);
				cleanString = cleanString.Replace("\"", string.Empty);
				cleanString = cleanString.Replace("\\", string.Empty);
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return cleanString;
		}
	}
}
