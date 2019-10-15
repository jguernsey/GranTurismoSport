using System;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class GetStatStartDate
	{
		public StatDate Get(DateTime lastUpdate)
		{
			StatDate startDate = new StatDate();
			startDate.StatYear = 2017;
			startDate.StatMonth = 10;

			try
			{
				if (lastUpdate.Year > 1753)
				{
					if (DateTime.Now.Day == 1)
					{
						if (DateTime.Now.Month == 1)
						{
							startDate.StatMonth = 12;
							startDate.StatYear = lastUpdate.Year - 1;
						}
						else
						{
							startDate.StatMonth = lastUpdate.Month - 1;
							startDate.StatYear = lastUpdate.Year;
						}
					}
					else
					{
						startDate.StatMonth = lastUpdate.Month;
						startDate.StatYear = lastUpdate.Year;
					}
				}
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return startDate;
		}
	}
}
