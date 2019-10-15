using System;
using System.Data;
using System.Text;
using System.Web.Services;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.DriverRatingCharts
{
	public partial class View : DriverRatingChartsModuleBase, IActionable
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				string userName = GetUserProfilePropertyValue("PSN Name");
				if (!string.IsNullOrEmpty(userName))
				{
					hfUsername.Value = userName;
				}
			}
			catch (Exception exc)
			{
				Exceptions.ProcessModuleLoadException(this, exc);
			}
		}
		//protected void UpdateCharts(object sender, EventArgs e)
		//{
		//	string startDate = txtStartDate.Text.ToString();
		//	string endDate = txtEndDate.Text.ToString();

		//	DateTime sd = DateTime.Now;
		//	DateTime ed = DateTime.Now;

		//	bool isValid = ValidateDate(startDate, endDate, out sd, out ed);

		//	if (!isValid)
		//	{
		//		DateTime c = DateTime.Now;
		//		sd = new DateTime(c.Year, c.Month, c.Day, 0, 0, 0);
		//		ed = sd.Add(TimeSpan.FromDays(1)).Subtract(TimeSpan.FromSeconds(1));
		//	}
		//	LoadData(sd, ed);
		//}
		
		private bool ValidateDate(string start, string end, out DateTime sdValue, out DateTime edValue)
		{
			bool isValid = false;
			sdValue = DateTime.Now;
			edValue = DateTime.Now;
			try
			{
				bool sdValid = DateTime.TryParse(start, out sdValue);
				bool edValid = DateTime.TryParse(end, out edValue);
				if (sdValid && edValid)
				{
					if (sdValue > edValue)
					{
						isValid = false;
					}
					else
					{
						edValue = new DateTime(edValue.Year, edValue.Month, edValue.Day, 23, 59, 59);
						isValid = true;
					}
				}
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return isValid;
		}
		public string GetUserProfilePropertyValue(string propertyName)
		{
			string value = null;
			ProfilePropertyDefinition ppd = UserInfo.Profile.GetProperty(propertyName);

			if (ppd == null)
			{
				value = string.Empty;
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
				var actions = new ModuleActionCollection {{GetNextActionID(), Localization.GetString("EditModule", LocalResourceFile), "", "", "", EditUrl(), false, SecurityAccessLevel.Edit, true, false}};
				return actions;
			}
		}
	}
}
