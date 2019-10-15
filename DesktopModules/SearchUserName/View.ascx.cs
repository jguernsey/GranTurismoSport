using System;
using System.Data;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.SearchUserName
{
	public partial class View : SearchUserNameModuleBase, IActionable
	{
		public void ClickedSearch(object sender, EventArgs e)
		{
			if(txtUsername.Text.Length > 0)
			{
				UserInfo currentUser = DotNetNuke.Entities.Users.UserController.Instance.GetCurrentUserInfo();
				Int64 currentUserId = Int64.Parse(currentUser.UserID.ToString());

				string username = txtUsername.Text.ToString();
				UsernameSearch search = new UsernameSearch();
				DataTable dt = search.Search(username, currentUserId);
				if(dt.Rows.Count > 0)
				{
					lblNotFound.Visible = false;
					lblLastUpdate.Visible = true;
					lblLastUpdate.Text = string.Format("Statistics last updated at {0}.", dt.Rows[0][5].ToString());
					dgvPlayerStats.DataSource = dt;
					dgvPlayerStats.DataBind();
				}
				else
				{
					dgvPlayerStats.Visible = false;
					lblLastUpdate.Visible = false;
					lblNotFound.Text = string.Format("Sorry, player name {0} either does not exist or statistics are currently not available.", username);
					lblNotFound.Visible = true;
				}
			}
		}
		public void ClickedExclude(object sender, EventArgs e)
		{
			if(txtExclude.Text.Length > 0)
			{
				if(!string.IsNullOrEmpty(txtExclude.Text.ToString()))
				{
					InsertExcludedUsername ieu = new InsertExcludedUsername();
					ieu.Insert(txtExclude.Text.ToString());
					txtExclude.Text = string.Empty;
				}
			}
		}
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{

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
                            GetNextActionID(), Localization.GetString("EditModule", LocalResourceFile), "", "", "",
                            EditUrl(), false, SecurityAccessLevel.Edit, true, false
                        }
                    };
				return actions;
			}
		}
	}
}