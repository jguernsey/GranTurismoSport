using System;
using System.Data;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.RaceCalendar
{
	public partial class View : RaceCalendarModuleBase, IActionable
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
			catch (Exception exc)
			{
				Exceptions.ProcessModuleLoadException(this, exc);
			}
		}
		private void LoadData()
		{
			string username = GetUserName();
			if (!string.IsNullOrEmpty(username))
			{
				GetUserDailyRaceCalendar gudrc = new GetUserDailyRaceCalendar();
				DataTable dt = gudrc.Get(username);
				if (dt.Rows.Count > 0)
				{
					dgvRaces.DataSource = dt;
					dgvRaces.DataBind();
				}
			}
		}
		protected void OnDataBound(object sender, EventArgs e)
		{
			for (int i = 0; i < dgvRaces.Rows.Count; i++)
			{
				GridViewRow row = dgvRaces.Rows[i];
				if (row.Cells.Count > 1)
				{
					string fs = row.Cells[0].Text.ToString();
					if (fs.StartsWith("Daily") || fs.StartsWith("FIA") || fs.StartsWith("24"))
					{
						row.Cells[0].ColumnSpan = 6;
						if (row.Cells.Count > 1)
						{
							do
							{
								row.Cells.RemoveAt(1);
							} while (row.Cells.Count > 1);
						}
						row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
						row.Cells[0].Attributes.Add("Style", "text-align: center; background-color: #487BFF; background: #487BFF url(../img/blueHeader.png) repeat-x; background-size: 150px 100%; color: white; font-family: RobotoMedium;");
					}
				}
			}
		}
		private string GetUserName()
		{
			string userName = string.Empty;
			try
			{
				userName = GetUserProfilePropertyValue("PSN Name");
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return userName;
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
