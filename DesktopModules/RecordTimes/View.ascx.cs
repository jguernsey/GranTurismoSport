using System;
using System.Data;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.RecordTimes
{
	public partial class View : RecordTimesModuleBase, IActionable
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
			GetTrackRecords gtr = new GetTrackRecords();
			DataTable dt = gtr.Get();
			if (dt.Rows.Count > 0)
			{
				dgvTrackRecords.DataSource = dt;
				dgvTrackRecords.DataBind();
			}
		}
		protected void OnDataBound(object sender, EventArgs e)
		{
			for(int i = 0;i < dgvTrackRecords.Rows.Count;i++)
			{
				GridViewRow row = dgvTrackRecords.Rows[i];
				if (row.Cells.Count > 1)
				{
					if(row.Cells.Count >= 5)
					{
						DateTime current = DateTime.Now;
						DateTime record = DateTime.Now;
						bool isValid = DateTime.TryParse(row.Cells[4].Text.ToString(), out record);
						if(isValid)
						{
							if(record.Year == current.Year && record.Month == current.Month && record.Day == current.Day)
							{
								for(int k = 0;k < row.Cells.Count;k++)
								{
									row.Cells[k].Attributes.Add("Style", "background-color: #8EAD90; background: #8EAD90;");
								}
							}
						}
					}
					if (row.Cells[0].Text.Equals("GR1") || row.Cells[0].Text.Equals("GR3") || row.Cells[0].Text.Equals("GR4") || row.Cells[0].Text.Equals("GRB") || row.Cells[0].Text.Equals("GRX") || row.Cells[0].Text.Equals("N100") || row.Cells[0].Text.Equals("N200") || row.Cells[0].Text.Equals("N300") || row.Cells[0].Text.Equals("N400") || row.Cells[0].Text.Equals("N500") || row.Cells[0].Text.Equals("N600") || row.Cells[0].Text.Equals("N700") || row.Cells[0].Text.Equals("N800") || row.Cells[0].Text.Equals("N1000"))
					{

					}
					else
					{
						row.Cells[0].ColumnSpan = 5;
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
