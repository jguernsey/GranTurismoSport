﻿/*
' Copyright (c) 2018  JasonGuernsey.net
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Services.Localization;

namespace Jjg.GtsStats.ServerMaintenance
{
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// The View class displays the content
	/// 
	/// Typically your view control would be used to display content or functionality in your module.
	/// 
	/// View may be the only control you have in your project depending on the complexity of your module
	/// 
	/// Because the control inherits from ServerMaintenanceModuleBase you have access to any custom properties
	/// defined there, as well as properties from DNN such as PortalId, ModuleId, TabId, UserId and many more.
	/// 
	/// </summary>
	/// -----------------------------------------------------------------------------
	public partial class View : ServerMaintenanceModuleBase, IActionable
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{

			}
			catch (Exception exc) //Module failed to load
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