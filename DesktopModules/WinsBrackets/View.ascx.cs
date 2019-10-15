using System;
using System.Data;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.WinsBrackets
{
	public partial class View : WinsBracketsModuleBase, IActionable
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
		public void LoadData()
		{
			GetWinsBrackets getWins = new GetWinsBrackets();
			DataTable dt = getWins.Get();
			dgvWins.DataSource = dt;
			dgvWins.DataBind();
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