using System;
using System.Data;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.DriverRatingBrackets
{
	public partial class View : DriverRatingBracketsModuleBase, IActionable
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
			GetDriverRatingBrackets getDriverBrackets = new GetDriverRatingBrackets();
			DataTable dt = getDriverBrackets.Get();
			dgvDriverRating.DataSource = dt;
			dgvDriverRating.DataBind();

			GetSportsmanshipBrackets getSr = new GetSportsmanshipBrackets();
			DataTable sr = getSr.Get();
			dgvSportsmanship.DataSource =sr;
			dgvSportsmanship.DataBind();

			GetCombinedBrackets getCombined = new GetCombinedBrackets();
			DataTable combined = getCombined.Get();
			dgvCombined.DataSource = combined;
			dgvCombined.DataBind();
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