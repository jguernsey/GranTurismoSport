using System;
using System.Data;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.NationsCupSummary
{
	public partial class View : NationsCupSummaryModuleBase, IActionable
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				if(!IsPostBack)
				{
					LoadSeasons();
				}
			}
			catch (Exception exc)
			{
				Exceptions.ProcessModuleLoadException(this, exc);
			}
		}
		public void StatIndexChanging(object sender, GridViewPageEventArgs e)
		{
			dgvSummary.PageIndex = e.NewPageIndex;
			Int64 regionId = 0;
			string season = string.Empty;
			if (Session["RegionId"] != null)
			{
				if (!Int64.TryParse(Session["RegionId"].ToString(), out regionId))
				{
					regionId = GetUserRegionId();
				}
			}
			else
			{
				regionId = GetUserRegionId();
			}
			if (Session["Season"] != null)
			{
				season = Session["Season"].ToString();
			}
			else
			{
				if (cboSeasons.SelectedIndex > 0)
				{
					season = cboSeasons.SelectedItem.ToString();
				}
			}

			Int64 countryId = 0;
			if (cboCountry.SelectedIndex > 1)
			{
				countryId = Int64.Parse(cboCountry.SelectedItem.Value.ToString());
			}

			LoadGridData(e.NewPageIndex, regionId, season, countryId);
		}
		private void LoadGridData(Int64 pageNumber, Int64 regionId, string season, Int64 countryId)
		{
			if(pageNumber == 0)
			{
				SetVirtualItemCount(regionId, season, countryId);
			}
			if((regionId == 1 || regionId == 2 || regionId == 3) && (!string.IsNullOrEmpty(season)))
			{
				if (countryId == 0)
				{
					GetNationsCupSummaryPaged gncsp = new GetNationsCupSummaryPaged();
					DataTable dt = gncsp.Get(pageNumber + 1, regionId, season);
					dgvSummary.DataSource = dt;
					dgvSummary.DataBind();
				}
				else
				{
					GetNationsCupSummaryByCountry gncsbc = new GetNationsCupSummaryByCountry();
					DataTable dt = gncsbc.Get(pageNumber + 1, regionId, season, countryId);
					dgvSummary.DataSource = dt;
					dgvSummary.DataBind();
				}
			}
		}
		private void SetVirtualItemCount(Int64 regionId, string season, Int64 countryId)
		{
			Int64 count = 0;
			if(countryId == 0)
			{
				GetNationsCupSummaryCount gncsc = new GetNationsCupSummaryCount();
				count = gncsc.Get(season, regionId);
			}
			else
			{
				GetNationsCupSummaryCountByCountry gncscbc = new GetNationsCupSummaryCountByCountry();
				count = gncscbc.Get(season, regionId, countryId);
			}
			dgvSummary.VirtualItemCount = int.Parse(count.ToString());
		}
		private void LoadSeasons()
		{
			Int64 regionId = GetUserRegionId();

			GetSeasonList gsl = new GetSeasonList();
			DataTable dt = gsl.Get(11, regionId);
			cboSeasons.DataTextField = "EventTarget";
			cboSeasons.DataValueField = "EventTarget";
			cboSeasons.DataSource = dt;
			cboSeasons.DataBind();
			cboSeasons.Items.Insert(0, "-- Select A Season --");
			cboSeasons.SelectedIndex = 0;
		}
		public void SeasonChanged(object sender, EventArgs e)
		{
			if (cboSeasons.SelectedIndex > 0)
			{
				Int64 regionId = GetUserRegionId();
				string season = cboSeasons.SelectedItem.ToString();
				Session["RegionId"] = regionId;
				Session["Season"] = season;

				LoadGridData(0, regionId, season, 0);
				LoadCountries(season, regionId);
			}
		}
		private void LoadCountries(string season, Int64 regionId)
		{
			GetSeasonDriverCountries gsdc = new GetSeasonDriverCountries();
			DataTable dt = gsdc.Get(season, regionId);
			cboCountry.DataTextField = "CountryName";
			cboCountry.DataValueField = "CountryId";
			cboCountry.DataSource = dt;
			cboCountry.DataBind();
			cboCountry.Items.Insert(0, "--- Filter By Country ---");
			cboCountry.Items.Insert(1, "All");
			cboCountry.SelectedIndex = 0;
		}
		public void CountryChanged(object sender, EventArgs e)
		{
			if(cboCountry.SelectedIndex > 0)
			{
				Int64 regionId = 0;
				string season = string.Empty;
				if (Session["RegionId"] != null)
				{
					if (!Int64.TryParse(Session["RegionId"].ToString(), out regionId))
					{
						regionId = GetUserRegionId();
					}
				}
				else
				{
					regionId = GetUserRegionId();
				}
				if (Session["Season"] != null)
				{
					season = Session["Season"].ToString();
				}
				else
				{
					if (cboSeasons.SelectedIndex > 0)
					{
						season = cboSeasons.SelectedItem.ToString();
					}
				}

				if(cboCountry.SelectedIndex == 1)
				{
					LoadGridData(0, regionId, season, 0);
				}
				else
				{
					Int64 countryId = Int64.Parse(cboCountry.SelectedItem.Value.ToString());
					LoadGridData(0, regionId, season, countryId);
				}
			}
		}
		protected void GridDataBound(object sender, GridViewRowEventArgs e)
		{
			if (e.Row.RowType == DataControlRowType.DataRow)
			{
				e.Row.Attributes["onmouseover"] = "this.style.backgroundColor='gray';";
				e.Row.Attributes["onmouseout"] = "this.style.backgroundColor='white';";
				e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgvSummary, "Select$" + e.Row.RowIndex);
			}
		}
		protected void SelectedRowChanged(object sender, EventArgs e)
		{
			foreach (GridViewRow row in dgvSummary.Rows)
			{
				if (row.RowIndex == dgvSummary.SelectedIndex)
				{
					string driver = row.Cells[2].Text.ToString();
					string season = cboSeasons.SelectedItem.Text.ToString();

					GetNationsResultDetail gmrd = new GetNationsResultDetail();
					DataTable dt = gmrd.Get(season, driver);

					lblDriverName.Text = driver;
					imgDriverCountry.ImageUrl = string.Format("ImageHandler.ashx?imgId={0}", dt.Rows[0][9].ToString());

					mpeManufacturers.Show();

					dgvDetail.DataSource = dt;
					dgvDetail.DataBind();

				}
			}
		}
		public Int64 GetUserRegionId()
		{
			Int64 regionId = 0;
			string psnLogin = GetUserProfilePropertyValue("PSN Name");
			if (!string.IsNullOrEmpty(psnLogin))
			{
				GetRegionId gri = new GetRegionId();
				regionId = gri.Get(psnLogin);
			}
			return regionId;
		}
		public string GetUserProfilePropertyValue(string propertyName)
		{
			string value = string.Empty;
			ProfilePropertyDefinition ppd = UserInfo.Profile.GetProperty(propertyName);
			if (ppd == null)
			{
				value = string.Empty;
			}
			else
			{
				if (string.IsNullOrEmpty(ppd.PropertyValue))
				{
					value = string.Empty;
				}
				else
				{
					value = ppd.PropertyValue;
				}
			}
			return value;
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
