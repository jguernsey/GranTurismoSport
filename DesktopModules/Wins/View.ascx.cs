using System;
using System.Data;
using System.Web;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.Wins
{
	public partial class View : WinsModuleBase, IActionable
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				if(HttpContext.Current.User.Identity.IsAuthenticated)
				{
					radCountry.Visible = true;
					radRegion.Visible = true;
					radWorld.Visible = true;
					SetUserCountry();
				}
				else
				{
					radCountry.Visible = false;
					radWorld.Visible = false;
					radRegion.Visible = false;
				}

				if (!IsPostBack)
				{
					radWorld.Checked = true;
					Session["RankType"] = RankType.World;
					LoadComboBox();
				}
			}
			catch (Exception exc)
			{
				Exceptions.ProcessModuleLoadException(this, exc);
			}
		}

		public void SelectedStatTypeChanged(object sender, EventArgs e)
		{
			if (cboStatTypes.SelectedIndex > 0)
			{
				LoadData();
				dgvStats.PageIndex = 0;
			}
		}
		
		private void LoadData()
		{
			string statType = cboStatTypes.SelectedItem.ToString();
			GetStatDetails getStatDetails = new GetStatDetails();
			DataTable details = getStatDetails.Get(statType);

			Session["DataProc"] = details.Rows[0][1].ToString();
			Session["PageProc"] = details.Rows[0][3].ToString();
			Session["Caption"] = details.Rows[0][4].ToString();
			lblGridHeader.Text = details.Rows[0][4].ToString();

			LoadGridData(Session["DataProc"].ToString(), Session["PageProc"].ToString(), Session["Caption"].ToString(), 0);
		}

		public void SetVirtualItemCount(string proc)
		{
			string country = null;
			Int64 itemCount = 0;
			RankType rankType = RankType.Unknown;

			try
			{
				rankType = (RankType)Enum.Parse(typeof(RankType),Session["RankType"].SafeToString());
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());

				rankType = RankType.Unknown;
			}

			if (rankType == RankType.Unknown)
			{
				if(radCountry.Checked)
				{
					rankType = RankType.Country;
				}
				else if(radRegion.Checked)
				{
					rankType = RankType.Region;
				}
				else
				{
					rankType = RankType.World;
				}
			}
			Int64 regionId = -99;
			switch(rankType)
			{
				case RankType.Country:
					regionId = -99;
					country = GetUserCountry();
					break;
				case RankType.Region:
					country = null;
					regionId = GetUserRegionId();
					break;
				case RankType.World:
					country = null;
					regionId = -99;
					break;
				default:
					break;
			}

			GetPageCountByCountry getByCountry = new GetPageCountByCountry();
			itemCount = getByCountry.Get(proc, country, regionId);

			dgvStats.VirtualItemCount = int.Parse(itemCount.ToString());

			int lastPageStart = Convert.ToInt32(Math.Floor(Convert.ToDecimal(itemCount) / 100) * 100) + 1;
			
			int lastPageEnd = lastPageStart + 99;

			dgvStats.PagerSettings.LastPageText = string.Format("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{0}&nbsp;-&nbsp;{1}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", lastPageStart, lastPageEnd);
		}

		public void StatIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
		{
			dgvStats.PageIndex = e.NewPageIndex;
			string country = null;
			if(HttpContext.Current.User.Identity.IsAuthenticated && radCountry.Checked)
			{
				if (Session["UserCountry"] != null)
				{
					country = Session["UserCountry"].ToString();
				}
				else
				{
					country = GetUserCountry();
					Session["UserCountry"] = country;
				}
			}
			LoadGridData(Session["DataProc"].ToString(), Session["PageProc"].ToString(), Session["Caption"].ToString(), e.NewPageIndex);
		}
		private void LoadGridData(string dataProc, string pageProc, string caption, int pageNumber)
		{
			if(pageNumber == 0)
			{
				SetVirtualItemCount(pageProc);
				Session["DataProc"] = dataProc;
			}

			lblGridHeader.Text = caption;

			Session["Caption"] = caption;
			dgvStats.PagerSettings.FirstPageText = string.Format("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{0}&nbsp;-&nbsp;{1}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", 1, 100);
			if(pageNumber == 0)
			{
				dgvStats.PagerSettings.PreviousPageText = string.Empty;
				dgvStats.PagerSettings.NextPageText = string.Format("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{0}&nbsp;-&nbsp;{1}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", 101, 200);
			}
			else
			{
				int previousPageStart = ((pageNumber - 1) * 100) + 1;
				int previousPageEnd = previousPageStart + 99;

				dgvStats.PagerSettings.PreviousPageText = string.Format("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{0}&nbsp;-&nbsp;{1}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", previousPageStart, previousPageEnd);
				dgvStats.PagerSettings.NextPageText = string.Format("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{0}&nbsp;-&nbsp;{1}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", previousPageStart + 200, previousPageEnd + 200);
			}

			string country = null;
			RankType rankType = RankType.Unknown;

			try
			{
				rankType = (RankType)Enum.Parse(typeof(RankType), Session["RankType"].SafeToString());
			}
			catch (Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());

				rankType = RankType.Unknown;
			}

			if (rankType == RankType.Unknown)
			{
				if (radCountry.Checked)
				{
					rankType = RankType.Country;
				}
				else if (radRegion.Checked)
				{
					rankType = RankType.Region;
				}
				else
				{
					rankType = RankType.World;
				}
			}
			Int64 regionId = -99;
			switch (rankType)
			{
				case RankType.Country:
					regionId = -99;
					country = GetUserCountry();
					break;
				case RankType.Region:
					country = null;
					regionId = GetUserRegionId();
					break;
				case RankType.World:
					country = null;
					regionId = -99;
					break;
				default:
					break;
			}

			GetGeneralStatsByCountry getByCountry = new GetGeneralStatsByCountry();
			DataTable dt = getByCountry.Get(dataProc, pageNumber + 1, 100, country, regionId);

			if (dataProc.Equals("GTS_WinsPerEntry_ByCountryPaged"))
			{
				dgvStats.Columns[3].ItemStyle.Width = 50;
				dgvStats.Columns[4].Visible = true;
				dgvStats.Columns[4].ItemStyle.Width = 50;
				dgvStats.Columns[5].Visible = true;
				dgvStats.Columns[5].ItemStyle.Width = 50;
			}
			else
			{
				dgvStats.Columns[3].ItemStyle.Width = 150;

				dgvStats.Columns[4].Visible = false;
				dgvStats.Columns[5].Visible = false;
			}
			dgvStats.DataSource = dt;
			dgvStats.DataBind();
		}

		public void CountryRankingChanged(object sender, EventArgs e)
		{
			if(radCountry.Checked)
			{
				Session["RankType"] = RankType.Country;

				radWorld.Checked = false;
				radRegion.Checked = false;
				
				if(string.IsNullOrEmpty(Session["UserCountry"].SafeToString()))
				{
					Session["UserCountry"] = GetUserCountry();
				}
				
				dgvStats.PageIndex = 0;
				if(cboStatTypes.SelectedIndex > 0)
				{
					LoadData();
				}
			}
		}

		public void WorldRankingChanged(object sender, EventArgs e)
		{
			if (radWorld.Checked)
			{
				Session["RankType"] = RankType.World;

				radCountry.Checked = false;
				radRegion.Checked = false;
				
				Session["UserCountry"] = null;
				dgvStats.PageIndex = 0;
				
				if(cboStatTypes.SelectedIndex > 0)
				{
					LoadData();
				}
			}
		}
		public void RegionRankingChanged(object sender, EventArgs e)
		{
			if (radRegion.Checked)
			{
				Session["RankType"] = RankType.Region;

				radCountry.Checked = false;
				radWorld.Checked = false;
				
				if (string.IsNullOrEmpty(Session["UserCountry"].SafeToString()))
				{
					Session["UserCountry"] = GetUserCountry();

				}
				dgvStats.PageIndex = 0;

				if (cboStatTypes.SelectedIndex > 0)
				{
					LoadData();
				}
			}
		}
		public void SetUserCountry()
		{
			string countryName = GetUserCountry();
			if (!string.IsNullOrEmpty(countryName))
			{
				Session["UserCountry"] = countryName;
			}
			else
			{
				Session["UserCountry"] = string.Empty;
			}
		}
		public string GetUserCountry()
		{
			string psnLogin = GetUserProfilePropertyValue("PSN Name");
			string country = string.Empty;
			if (!string.IsNullOrEmpty(psnLogin))
			{
				GetUserCountryName getCountry = new GetUserCountryName();
				country = getCountry.Get(psnLogin);
			}
			return country;
		}
		private Int64 GetUserRegionId()
		{
			Int64 regionId = 0;
			string psnLogin = GetUserProfilePropertyValue("PSN Name");
			if(!string.IsNullOrEmpty(psnLogin))
			{
				GetRegionId gri = new GetRegionId();
				regionId = gri.Get(psnLogin);
			}
			if (!(regionId == 1 || regionId == 2 || regionId == 3))
			{
				regionId = -99;
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
				if(string.IsNullOrEmpty(ppd.PropertyValue))
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
		public void LoadComboBox()
		{
			GetStatTypes getStatTypes = new GetStatTypes();
			DataTable dt = getStatTypes.Get();
			cboStatTypes.DataTextField = "StatType";
			cboStatTypes.DataValueField = "StatTypeId";
			cboStatTypes.DataSource = dt;
			cboStatTypes.DataBind();
			cboStatTypes.Items.Insert(0, "-- Stat Type --");
			cboStatTypes.SelectedIndex = 0;
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