using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.TrackRatingByCategory
{
	public partial class View : TrackRatingByCategoryModuleBase, IActionable
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
			GetTrackDetailByCategory gtdbc = new GetTrackDetailByCategory();
			DataTable dt = gtdbc.Get();
			dgvSummary.DataSource = dt;
			dgvSummary.DataBind();
		}
		protected void OnDataBound(object sender, EventArgs e)
		{
			for (int i = 0; i < dgvSummary.Rows.Count; i++)
			{
				GridViewRow row = dgvSummary.Rows[i];
				if (row.Cells.Count > 1)
				{
					if (row.Cells[0].Text.Equals("GR1") || row.Cells[0].Text.Equals("GR3") || row.Cells[0].Text.Equals("GR4") || row.Cells[0].Text.Equals("GRB") || row.Cells[0].Text.Equals("GRX") || row.Cells[0].Text.Equals("N100") || row.Cells[0].Text.Equals("N200") || row.Cells[0].Text.Equals("N300") || row.Cells[0].Text.Equals("N400") || row.Cells[0].Text.Equals("N500") || row.Cells[0].Text.Equals("N600") || row.Cells[0].Text.Equals("N700") || row.Cells[0].Text.Equals("N800") || row.Cells[0].Text.Equals("N1000"))
					{
						decimal rating = decimal.Parse(row.Cells[4].Text);
						if(rating > 0)
						{
							row.Style.Add(HtmlTextWriterStyle.BackgroundImage, "url(../img/rowGreen.png)");
							row.Style.Add("background-repeat", "repeat-x");
						}
						else if(rating < 0)
						{
							row.Style.Add(HtmlTextWriterStyle.BackgroundImage, "url(../img/rowRed.png)");
							row.Style.Add("background-repeat", "repeat-x");
						}
					}
					else
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
						row.Cells[0].Attributes.Add("Style", "height: 50px; text-align: center; background-color: #487BFF; background: #487BFF url(../img/blueHeader.png) repeat-x; background-size: 150px 100%; color: white; font-family: Roboto; font-size: x-large;");
					}
				}
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
