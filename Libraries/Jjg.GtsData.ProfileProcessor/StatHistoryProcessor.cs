using System;
using System.Data;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class StatHistoryProcessor
	{
		public void Process(NumberGroup group)
		{
			DataTable dt = group.Numbers;
			foreach (DataRow dr in dt.Rows)
			{
				try
				{
					Int64 profileId = Int64.Parse(dr[0].ToString());
					Int64 profileNumber = Int64.Parse(dr[1].ToString());
					DateTime lastUpdate = new DateTime(1753, 1, 1, 0, 0, 0);
					bool isValid = DateTime.TryParse(lastUpdate.ToString(), out lastUpdate);
					if (!isValid)
					{
						lastUpdate = new DateTime(1753, 1, 1, 0, 0, 0);
					}

					if (profileId != 0 && profileNumber >= 1000000)
					{

						UpdateStatsHistory ush = new UpdateStatsHistory();
						ush.Update(profileId, profileNumber, lastUpdate);
					}
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
