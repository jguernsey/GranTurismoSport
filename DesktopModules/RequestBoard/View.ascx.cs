using System;
using System.Data;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.RequestBoard
{
	public partial class View : RequestBoardModuleBase, IActionable
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				if (!IsPostBack)
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
			LoadRequestTypes();
			LoadGrid();
		}
		public void FeatureRowCommand(object sender, GridViewCommandEventArgs e)
		{
			if(e.CommandName.Equals("VoteFeature"))
			{
				Int64 requestId = Int64.Parse(e.CommandArgument.ToString());
				UserInfo currentUser = DotNetNuke.Entities.Users.UserController.Instance.GetCurrentUserInfo();
				Int64 currentUserId = Int64.Parse(currentUser.UserID.ToString());

				InsertRequestVote irv = new InsertRequestVote();
				irv.Insert(requestId, currentUserId);

				LoadGrid();
			}
		}
		protected void ClickedCancel(object sender, EventArgs e)
		{
			cboRequestType.SelectedIndex = 0;
			txtRequestTitle.Text = string.Empty;
			txtDescription.Text = string.Empty;
		}
		protected void ClickedSubmit(object sender, EventArgs e)
		{
			if(cboRequestType.SelectedIndex > 0 && txtDescription.Text.Length > 0 && txtRequestTitle.Text.Length > 0)
			{
				UserInfo currentUser = DotNetNuke.Entities.Users.UserController.Instance.GetCurrentUserInfo();
				
				Int64 userId = Int64.Parse(currentUser.UserID.ToString());
				string title = txtRequestTitle.Text.ToString();
				string description = txtDescription.Text.ToString();
				string requestType = cboRequestType.SelectedItem.ToString();

				InsertFeatureRequest ifr = new InsertFeatureRequest();
				ifr.Insert(userId, requestType, title, description);

				LoadGrid();
			}
		}

		private void LoadRequestTypes()
		{
			GetRequestTypes getStatTypes = new GetRequestTypes();
			DataTable dt = getStatTypes.Get();

			cboRequestType.DataTextField = "RequestType";
			cboRequestType.DataValueField = "Id";

			cboRequestType.DataSource = dt;
			cboRequestType.DataBind();

			cboRequestType.Items.Insert(0, "-- Request Type --");
			cboRequestType.SelectedIndex = 0;
		}

		private void LoadGrid()
		{
			GetFeatureRequests gfr = new GetFeatureRequests();
			DataTable dt = gfr.Get();

			dgvRequests.DataSource = dt;
			dgvRequests.DataBind();
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
