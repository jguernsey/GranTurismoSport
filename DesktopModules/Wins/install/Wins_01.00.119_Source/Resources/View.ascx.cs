using System;
using System.Data;
using System.Web;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.Wins
{
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// The View class displays the content
	/// 
	/// Typically your view control would be used to display content or functionality in your module.
	/// 
	/// View may be the only control you have in your project depending on the complexity of your module
	/// 
	/// Because the control inherits from WinsModuleBase you have access to any custom properties
	/// defined there, as well as properties from DNN such as PortalId, ModuleId, TabId, UserId and many more.
	/// 
	/// </summary>
	/// -----------------------------------------------------------------------------
	public partial class View : WinsModuleBase, IActionable
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				radCountry.Visible = HttpContext.Current.User.Identity.IsAuthenticated;
				radWorld.Visible = HttpContext.Current.User.Identity.IsAuthenticated;
				if (HttpContext.Current.User.Identity.IsAuthenticated)
				{
					Session["UserCountry"] = GetUserCountry();
				}
				else
				{
					Session["UserCountry"] = "World";
				}
				if(!IsPostBack)
				{
					Session["RankingType"] = "World";
				}
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

		public void ClickedCarCount(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if(rankingType.Equals("Country"))
			{
				proc = "PagedRankedCarCountByCountry";
				caption = string.Format("{0} Players By Car Count", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedCarCount";
				caption = "GT Sport Players By Car Count";
			}
			LoadGridData(proc, 0, caption);
		}
		public void ClickedCarsPurchased(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedCarsPurchasedByCountry";
				caption = string.Format("{0} Players By Cars Purchased", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedCarsPurchased";
				caption = "GT Sport Players By Cars Purchased";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedCreditEarned(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedCreditEarnedByCountry";
				caption = string.Format("{0} Players By Credits Earned", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedCreditEarned";
				caption = "GT Sport Players By Credits Earned";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedDriverRating(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedDriverRatingByCountry";
				caption = string.Format("{0} Players By Driver Rating", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedDriverRating";
				caption = "GT Sport Players By Driver Rating";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedExperience(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedExperienceByCountry";
				caption = string.Format("{0} Players By Experience", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedExperience";
				caption = "GT Sport Players By Experience";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedFastestLaps(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedFastestLapsByCountry";
				caption = string.Format("{0} Players By Fastest Laps", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedFastestLaps";
				caption = "GT Sport Players By Fastest Laps";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedFuelConsumed(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedFuelConsumedByCountry";
				caption = string.Format("{0} Players By Fuel Consumed", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedFuelConsumed";
				caption = "GT Sport Players By Fuel Consumed";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedLevel(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedLevelByCountry";
				caption = string.Format("{0} Players By Level", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedLevel";
				caption = "GT Sport Players By Level";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedLoginCount(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedLoginCountByCountry";
				caption = string.Format("{0} Players By Login Count", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedLoginCount";
				caption = "GT Sport Players By Login Count";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedPolePositions(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedPolePositionsByCountry";
				caption = string.Format("{0} Players By Pole Positions", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedPolePositions";
				caption = "GT Sport Players By Pole Positions";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedRaceCount(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedRaceCountByCountry";
				caption = string.Format("{0} Players By Race Count", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedRaceCount";
				caption = "GT Sport Players By Race Count";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedRaces(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedRacesFinishedByCountry";
				caption = string.Format("{0} Players By Races Finished", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedRacesFinished";
				caption = "GT Sport Players By Races Finished";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedTimeDriven(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedTimeDrivenByCountry";
				caption = string.Format("{0} Players By Time Driven", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedTimeDriven";
				caption = "GT Sport Players By Time Driven";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedTimePlayed(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedTimePlayedByCountry";
				caption = string.Format("{0} Players By Time Played", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedTimePlayed";
				caption = "GT Sport Players By Time Played";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedTotalDistance(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedTotalDistanceByCountry";
				caption = string.Format("{0} Players By Total Distance", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedTotalDistance";
				caption = "GT Sport Players By Total Distance";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedWins(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedRankedWinsByCountry";
				caption = string.Format("{0} Players By Wins", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedRankedWins";
				caption = "GT Sport Players By Wins";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedPolesPerEntry(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedPolesPerEntryByCountry";
				caption = string.Format("{0} Players By Poles Per Entry", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedPolesPerEntry";
				caption = "GT Sport Players By Poles Per Entry";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedFinishesPerEntry(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedFinishesPerEntryByCountry";
				caption = string.Format("{0} Players By Finishes Per Entry", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedFinishesPerEntry";
				caption = "GT Sport Players By Finishes Per Entry";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void ClickedWinsPerEntry(object sender, EventArgs e)
		{
			string rankingType = Session["RankingType"].ToString();
			string proc = string.Empty;
			string caption = string.Empty;

			if (rankingType.Equals("Country"))
			{
				proc = "PagedWinsPerEntryByCountry";
				caption = string.Format("{0} Players By Wins Per Entry", Session["UserCountry"].ToString());
			}
			else
			{
				proc = "PagedWinsPerEntry";
				caption = "GT Sport Players By Wins Per Entry";
			}
			
			LoadGridData(proc, 0, caption);
		}
		public void SetVirtualItemCount(string proc)
		{
			int itemCount = 0;
			string rankType = Session["RankingType"].ToString();
			if (rankType.Equals("Country"))
			{
				string country = Session["UserCountry"].ToString();
				GetPageCountByCountry getByCountry = new GetPageCountByCountry();
				itemCount = getByCountry.Get(proc, country);
			}
			else
			{
				GetPageCount getPageCount = new GetPageCount();
				itemCount = getPageCount.Get(proc);
			}

			dgvStats.VirtualItemCount = itemCount;
			int lastPageStart = Convert.ToInt32(Math.Floor((Convert.ToDecimal(itemCount) / 100)) * 100) + 1;
			int lastPageEnd = lastPageStart + 99;

			dgvStats.PagerSettings.LastPageText = string.Format("     {0}   -   {1}     ", lastPageStart, lastPageEnd);
		}
		public void StatIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
		{
			dgvStats.PageIndex = e.NewPageIndex;
			LoadGridData(Session["ProcName"].ToString(), e.NewPageIndex, Session["Caption"].ToString());
		}
		private void LoadGridData(string proc, int pageNumber, string caption)
		{
			if (dgvStats.DataSource != null)
			{
				dgvStats.DataSource = null;
			}

			if(pageNumber == 0)
			{
				SetVirtualItemCount(proc);
				Session["ProcName"] = proc;
			}

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

			DataTable dt;
			string rankType = Session["RankingType"].ToString();
			if (rankType.Equals("Country"))
			{
				string country = Session["UserCountry"].ToString();
				GetGeneralStatsByCountry getByCountry = new GetGeneralStatsByCountry();
				dt = getByCountry.Get(proc, pageNumber + 1, 100, country);
			}
			else
			{
				GetGeneralStats getGeneralStats = new GetGeneralStats();

				dt = getGeneralStats.Get(proc, pageNumber + 1, 100);
			}

			if (proc.Equals("PagedWinsPerEntry") || proc.Equals("PagedWinsPerEntryByCountry"))
			{
				dgvStats.Columns[5].Visible = true;
				dgvStats.Columns[6].Visible = true;
			}
			else
			{
				dgvStats.Columns[5].Visible = false;
				dgvStats.Columns[6].Visible = false;
			}
			
			dgvStats.Caption = caption;
			dgvStats.DataSource = dt;
			dgvStats.DataBind();


		}
		public void CountryRankingChanged(object sender, EventArgs e)
		{
			if(radCountry.Checked)
			{
				radWorld.Checked = false;
				Session["RankingType"] = "Country";
			}
		}
		public void WorldRankingChanged(object sender, EventArgs e)
		{
			if (radWorld.Checked)
			{
				radCountry.Checked = false;
				Session["RankingType"] = "World";
			}
		}
		public string GetUserCountry()
		{
			string psnLogin = GetUserProfilePropertyValue("PSN Name");
			GetUserCountryName getCountry = new GetUserCountryName();
			string country = getCountry.Get(psnLogin);
			return country;
		}
		public string GetUserProfilePropertyValue(string propertyName)
		{
			string value = null;
			ProfilePropertyDefinition ppd = UserInfo.Profile.GetProperty(propertyName);

			if (ppd == null)
			{
				value = "";
			}
			else
			{
				value = ppd.PropertyValue;
				if (value == null)
				{
					if (string.IsNullOrEmpty(ppd.DefaultValue))
					{
						value = string.Empty;
					}
					else
					{
						value = ppd.DefaultValue;
					}
				}
			}
			return value;
		}
	}
}