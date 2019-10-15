using System;
using System.Data;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.DriverRating
{
	public partial class View : DriverRatingModuleBase, IActionable
	{
		public void UpdateCharts(object sender, EventArgs e)
		{
			string startDate = txtStartDate.Text.ToString();
			string endDate = txtEndDate.Text.ToString();
			EventWriter writer = new EventWriter();
			writer.Write(string.Format("StartDate: {0} End Date {1}", startDate, endDate));

			DateTime sd = DateTime.Now;
			DateTime ed = DateTime.Now;

			bool isValid = ValidateDate(startDate, endDate, out sd, out ed);

			if (!isValid)
			{
				DateTime c = DateTime.Now;
				sd = new DateTime(c.Year, c.Month, c.Day, 0, 0, 0);
				ed = sd.Add(TimeSpan.FromDays(1)).Subtract(TimeSpan.FromSeconds(1));
			}
			LoadData(sd, ed);
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				if(!IsPostBack)
				{
					DateTime c = DateTime.Now;
					txtStartDate.Text = c.ToString("yyyy-MM-dd");
					txtEndDate.Text = c.ToString("yyyy-MM-dd");

					DateTime sd = new DateTime(c.Year, c.Month, c.Day, 0, 0, 0);
					DateTime ed = sd.Add(TimeSpan.FromDays(1)).Subtract(TimeSpan.FromSeconds(1));

					EventWriter writer = new EventWriter();
					writer.Write(string.Format("StartDate: {0} End Date {1}", sd.ToString(), ed.ToString()));

					LoadData(sd, ed);
				}
			}
			catch (Exception exc)
			{
				Exceptions.ProcessModuleLoadException(this, exc);
			}
		}

		private void LoadData(DateTime sd, DateTime ed)
		{
			string psnLogin = GetUserProfilePropertyValue("PSN Name");
			if (!string.IsNullOrEmpty(psnLogin))
			{
				GetRealTimeDriverRating grtdr = new GetRealTimeDriverRating();
				DataTable ratings = grtdr.Get(psnLogin, sd, ed);

				if (ratings.Rows.Count > 0)
				{
					string[] x = new string[ratings.Rows.Count];
					decimal[] y = new decimal[ratings.Rows.Count];
					for(int i = 0;i<ratings.Rows.Count;i++)
					{
						x[i] = ratings.Rows[i][3].ToString();
						y[i] = Convert.ToInt32(ratings.Rows[i][1]);
					}
					chartChanges.Series.Add(new AjaxControlToolkit.BarChartSeries { Data = y });
					chartChanges.CategoriesAxis = string.Join(",", x);
					chartChanges.ChartTitle = "Driver Rating Changes";

					string[] x2 = new string[ratings.Rows.Count];
					decimal[] y2 = new decimal[ratings.Rows.Count];
					for(int i2 = 0;i2<ratings.Rows.Count;i2++)
					{
						x2[i2] = ratings.Rows[i2][3].ToString();
						y2[i2] = Convert.ToInt32(ratings.Rows[i2][0]);
					}
					chartDr.Series.Add(new AjaxControlToolkit.AreaChartSeries { Data = y2 });
					chartDr.CategoriesAxis = string.Join(",", x2);
					chartDr.ChartTitle = "Driver Rating";
				}
			}
		}
		private bool ValidateDate(string start, string end, out DateTime sdValue, out DateTime edValue)
		{
			bool isValid = false;
			sdValue = DateTime.Now;
			edValue = DateTime.Now;
			try
			{
				bool sdValid = DateTime.TryParse(start, out sdValue);
				bool edValid = DateTime.TryParse(end, out edValue);
				if(sdValid && edValid)
				{
					if(sdValue > edValue)
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
