using System;
using System.Data;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.CountryStats
{
	public partial class View : CountryStatsModuleBase, IActionable
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				if(!IsPostBack)
				{
					ShowData();
				}
			}
			catch (Exception exc)
			{
				Exceptions.ProcessModuleLoadException(this, exc);
			}
		}

		public ModuleActionCollection ModuleActions
		{
			get
			{
				var actions = new ModuleActionCollection
                    {
                        {
                            GetNextActionID(), Localization.GetString("EditModule", LocalResourceFile), "", "", "", EditUrl(), false, SecurityAccessLevel.Edit, true, false
						}
                    };
				return actions;
			}
		}

		private void ShowData()
		{
			GetCountryLabelText getCountryLabelText = new GetCountryLabelText();
			string labelText = getCountryLabelText.Get();
			string[] textParts = labelText.Split('^');
			lblDateInfo.Text = textParts[0].ToString();
			lblCountInfo.Text = textParts[1].ToString();

			GetCountryStatistics getCountryData = new GetCountryStatistics();
			DataTable dt = getCountryData.Get();
			dgvCountries.DataSource = dt;
			dgvCountries.DataBind();
		}
	}
}