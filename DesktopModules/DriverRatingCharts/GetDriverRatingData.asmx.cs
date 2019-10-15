using System;
using System.Collections.Generic;
using System.Web.Services;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.DriverRatingCharts
{
	[WebService(Namespace = "http://jasonguernsey.net/gts/webservices/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	[System.Web.Script.Services.ScriptService]
	public class GetDriverRatingData : System.Web.Services.WebService
	{
		[WebMethod]
		public string GetChartData(string ed, string sd, string username)
		{
			string chartData = string.Empty;
			if (!string.IsNullOrEmpty(username))
			{
				DateTime tempDateTime = DateTime.Now;
				if (string.IsNullOrEmpty(ed))
				{
					ed = DateTime.Now.Add(TimeSpan.FromDays(1)).ToString();
				}
				else
				{
					bool edValid = DateTime.TryParse(ed, out tempDateTime);
					if(!edValid)
					{
						ed = DateTime.Now.Add(TimeSpan.FromDays(1)).ToString();
					}
				}
				if (string.IsNullOrEmpty(sd))
				{
					sd = DateTime.Now.Subtract(TimeSpan.FromDays(1)).ToString();
				}
				else
				{
					bool sdValid = DateTime.TryParse(sd, out tempDateTime);
					if (!sdValid)
					{
						sd = DateTime.Now.Subtract(TimeSpan.FromDays(1)).ToString();
					}
				}

				GetDriverRatingLists lists = new GetDriverRatingLists();
                List<object> chartDataB = lists.Get(username, DateTime.Parse(sd), DateTime.Parse(ed));
			}
			return chartData;
		}
	}
}
