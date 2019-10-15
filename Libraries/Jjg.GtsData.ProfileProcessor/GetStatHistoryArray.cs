using System;
using System.IO;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;

namespace Jjg.GtsData.ProfileProcessor
{
	public class GetStatHistoryArray
	{
		public StatHistory Get(string content)
		{
			StatHistory stats = new StatHistory();
			if (!string.IsNullOrEmpty(content))
			{
				using (StringReader reader = new StringReader(content))
				{
					string line = string.Empty;
					while ((line = reader.ReadLine()) != null)
					{
						if (!string.IsNullOrEmpty(line))
						{
							try
							{
								stats = JsonConvert.DeserializeObject<StatHistory>(line);
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
			return stats;
		}
	}
}
