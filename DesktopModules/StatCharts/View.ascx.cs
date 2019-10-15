using System;
using System.Data;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.StatCharts
{
	public partial class View : StatChartsModuleBase, IActionable
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				if(!IsPostBack)
				{
					LoadData();
				}
			}
			catch (Exception exc) //Module failed to load
			{
				Exceptions.ProcessModuleLoadException(this, exc);
			}
		}
		public void LoadData()
		{
			string psnLogin = GetUserProfilePropertyValue("PSN Name");
			if (!string.IsNullOrEmpty(psnLogin))
			{
				GetDailyDistanceChart getDistance = new GetDailyDistanceChart();
				DataTable dt = getDistance.Get(psnLogin);

				chtDailyMeter.Series["Kilometers"].XValueMember = "HistoryDate";
				chtDailyMeter.Series["Kilometers"].YValueMembers = "Kilometers";

				chtDailyMeter.DataSource = dt;
				chtDailyMeter.DataBind();

				chtTotalMeters.Series["RunningTotal"].XValueMember = "HistoryDate";
				chtTotalMeters.Series["RunningTotal"].YValueMembers = "RunningTotal";

				chtTotalMeters.DataSource = dt;
				chtTotalMeters.DataBind();

				GetDriverRatingPointsChart getDriver = new GetDriverRatingPointsChart();
				DataTable drT = getDriver.Get(psnLogin);

				chtDriverPoints.Series["DriverRating"].XValueMember = "HistoryDate";
				chtDriverPoints.Series["DriverRating"].YValueMembers = "DriverPoints";

				chtDriverPoints.DataSource = drT;
				chtDriverPoints.DataBind();
			}
		}
		public string GetUserProfilePropertyValue(string propertyName)
		{
			string value = null;
			ProfilePropertyDefinition ppd = UserInfo.Profile.GetProperty(propertyName);

			if (ppd == null)
			{
				value = "";
			}
			else
			{
				value = ppd.PropertyValue;
				if (value == null)
				{
					if (string.IsNullOrEmpty(ppd.DefaultValue))
					{
						value = string.Empty;
					}
					else
					{
						value = ppd.DefaultValue;
					}
				}
			}
			return value;
		}
		public ModuleActionCollection ModuleActions
		{
			get
			{
				var actions = new ModuleActionCollection
                    {
                        {
                            GetNextActionID(), Localization.GetString("EditModule", LocalResourceFile), "", "", "",
                            EditUrl(), false, SecurityAccessLevel.Edit, true, false
                        }
                    };
				return actions;
			}
		}
	}
}