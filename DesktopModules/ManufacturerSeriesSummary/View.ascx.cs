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

namespace Jjg.GtsStats.ManufacturerSeriesSummary
{
	public partial class View : ManufacturerSeriesSummaryModuleBase, IActionable
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
			LoadGridData(e.NewPageIndex);
		}
		public void SeasonChanged(object sender, EventArgs e)
		{
			if (cboSeasons.SelectedIndex > 0)
			{
				LoadGridData(0);
			}
		}
		protected void GridDataBound(object sender, GridViewRowEventArgs e)
		{
			if(e.Row.RowType == DataControlRowType.DataRow)
			{
				e.Row.Attributes["onmouseover"] = "this.style.backgroundColor='gray';";
				e.Row.Attributes["onmouseout"] = "this.style.backgroundColor='white';";
				e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgvSummary, "Select$" + e.Row.RowIndex);
			}
		}
		protected void SelectedRowChanged(object sender, EventArgs e)
		{
			foreach(GridViewRow row in dgvSummary.Rows)
			{
				if(row.RowIndex == dgvSummary.SelectedIndex)
				{
					string driver = row.Cells[2].Text.ToString();
					string season = cboSeasons.SelectedItem.Text.ToString();

					EventWriter writer = new EventWriter();
					writer.Write(string.Format("Season: {0} Driver: {1}", season, driver));

					GetManufacturerResultDetails gmrd = new GetManufacturerResultDetails();
					DataTable dt = gmrd.Get(season, driver);
					
					mpeManufacturers.Show();

					dgvDetail.DataSource = dt;
					dgvDetail.DataBind();
				}
			}
		}
		private void LoadGridData(Int64 pageNumber)
		{
			Int64 countryId = 0;
			Int64 manufacturerId = 0;

			string season = cboSeasons.SelectedItem.Text.ToString();
			Int64 regionId = GetUserRegionId();

			if(cboCountry.SelectedIndex > 1)
			{
				countryId = Int64.Parse(cboCountry.SelectedItem.Value.ToString());
			}
			if(cboManufacturer.SelectedIndex > 1)
			{
				manufacturerId = Int64.Parse(cboCountry.SelectedItem.Value.ToString());
			}
			if(pageNumber == 0)
			{
				SetVirtualItemCount(regionId, season, countryId, manufacturerId);
			}

			DataTable dt = new DataTable();
			GetManufacturerSeriesSummary gmrdba = new GetManufacturerSeriesSummary();
			dt = gmrdba.Get(season, regionId, countryId, manufacturerId, pageNumber);
				
			if(dt.Rows.Count > 0)
			{
				dgvSummary.DataSource = dt;
				dgvSummary.DataBind();

				LoadCountries(season, regionId);
				LoadManufacturers();
			}
		}
		private void LoadSeasons()
		{
			Int64 regionId = GetUserRegionId();

			GetSeasonList gsl = new GetSeasonList();
			DataTable dt = gsl.Get(12, regionId);
			cboSeasons.DataTextField = "EventTarget";
			cboSeasons.DataValueField = "EventTarget";
			cboSeasons.DataSource = dt;
			cboSeasons.DataBind();
			cboSeasons.Items.Insert(0, "-- Select A Season --");
			cboSeasons.SelectedIndex = 0;
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
		private void LoadManufacturers()
		{
			GetFiaManufacturers gfm = new GetFiaManufacturers();
			DataTable dt = gfm.Get();
			cboManufacturer.DataTextField = "Name";
			cboManufacturer.DataValueField = "Id";
			cboManufacturer.DataSource = dt;
			cboManufacturer.DataBind();
			cboManufacturer.Items.Insert(0, "--- Filter By Manufacturer ---");
			cboManufacturer.Items.Insert(1, "All");
			cboManufacturer.SelectedIndex = 0;
		}
		private void SetVirtualItemCount(Int64 regionId, string season, Int64 countryId, Int64 manufacturerId)
		{
			GetManufacturerSeriesSummaryCount gmssc = new GetManufacturerSeriesSummaryCount();
			Int64 count = gmssc.Get(season, regionId, countryId, manufacturerId);
			dgvSummary.VirtualItemCount = int.Parse(count.ToString());
		}
		protected void CountryChanged(object sender, EventArgs e)
		{
			LoadGridData(0);
		}
		protected void ManufacturerChanged(object sender, EventArgs e)
		{
			LoadGridData(0);
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
