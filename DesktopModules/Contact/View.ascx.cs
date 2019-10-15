using System;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.Contact
{
	public partial class View : ContactModuleBase, IActionable
	{
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
		public void SendMessage(object sender, EventArgs e)
		{
			if(txtMessage.Text.Length > 0)
			{
				string message = txtMessage.Text.ToString();
				UserInfo currentUser = DotNetNuke.Entities.Users.UserController.Instance.GetCurrentUserInfo();
				Int64 userId = Int64.Parse(currentUser.UserID.ToString());

				InsertMessageText imt = new InsertMessageText();
				imt.Insert(userId, message);

				txtMessage.Text = string.Empty;
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
