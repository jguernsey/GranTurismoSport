using System;
using System.Data;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.FinishSummary
{
	public partial class View : FinishSummaryModuleBase, IActionable
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
		private void LoadData()
		{
			string psnLogin = GetUserProfilePropertyValue("PSN Name");
			if (!string.IsNullOrEmpty(psnLogin))
			{
				GetRaceResultsSummary grrs = new GetRaceResultsSummary();
				DataTable rs = grrs.Get(psnLogin);
				dgvSummary.DataSource = rs;
				dgvSummary.DataBind();

				GetRaceResultsSummaryByTrack grrsbt = new GetRaceResultsSummaryByTrack();
				DataTable rsbt = grrsbt.Get(psnLogin);
				dgvSummaryByTrack.DataSource = rsbt;
				dgvSummaryByTrack.DataBind();
			}
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
	}
}
