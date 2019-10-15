using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Jjg.GtsCollector.Common;
using Jjg.GtsCollector.RaceEvents;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.QualifyingTimes
{
	public partial class View : QualifyingTimesModuleBase, IActionable
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
			Int64 regionId = 1;
			string psnLogin = string.Empty;
			if (HttpContext.Current.User.Identity.IsAuthenticated)
			{
				psnLogin = GetUserProfilePropertyValue("PSN Name");
				if (!string.IsNullOrEmpty(psnLogin))
				{
					GetRegionId getRegionId = new GetRegionId();
					regionId = getRegionId.Get(psnLogin);

					LoadDailyRaces(regionId);
				}
			}

			string raceA = "Daily Race A";
			string raceB = "Daily Race B";
			string raceC = "Daily Race C";
			string raceN = "FIA GT Nations Cup";
			string raceM = "FIA GT Manufacturer Series";

			GetRaceTimes ra = new GetRaceTimes();
			DataTable regionA = ra.Get(regionId, raceA);
			dgvRegionA.DataSource = regionA;
			dgvRegionA.DataBind();

			GetWorldRankingsByTitle ga = new GetWorldRankingsByTitle();
			DataTable worldA = ga.Get(raceA);
			dgvWorldA.DataSource = worldA;
			dgvWorldA.DataBind();

			GetRaceTimes rb = new GetRaceTimes();
			DataTable regionB = rb.Get(regionId, raceB);
			dgvRegionB.DataSource = regionB;
			dgvRegionB.DataBind();

			GetWorldRankingsByTitle gb = new GetWorldRankingsByTitle();
			DataTable worldB = gb.Get(raceB);
			dgvWorldB.DataSource = worldB;
			dgvWorldB.DataBind();

			GetRaceTimes rc = new GetRaceTimes();
			DataTable regionC = rc.Get(regionId, raceC);
			dgvRegionC.DataSource = regionC;
			dgvRegionC.DataBind();

			GetWorldRankingsByTitle gc = new GetWorldRankingsByTitle();
			DataTable worldC = gc.Get(raceC);
			dgvWorldC.DataSource = worldC;
			dgvWorldC.DataBind();

			GetRaceTimes rn = new GetRaceTimes();
			DataTable regionN = rn.Get(regionId, raceN);
			dgvRegionN.DataSource = regionN;
			dgvRegionN.DataBind();

			GetWorldRankingsByTitle gn = new GetWorldRankingsByTitle();
			DataTable worldN = gn.Get(raceN);
			dgvWorldN.DataSource = worldN;
			dgvWorldN.DataBind();

			GetRaceTimes rm = new GetRaceTimes();
			DataTable regionM = rm.Get(regionId, raceM);
			dgvRegionM.DataSource = regionM;
			dgvRegionM.DataBind();

			GetWorldRankingsByTitle gm = new GetWorldRankingsByTitle();
			DataTable worldM = gm.Get(raceM);
			dgvWorldM.DataSource = worldM;
			dgvWorldM.DataBind();

			GetUserTimes(regionId);
		}
		private void GetUserTimes(Int64 regionId)
		{
			string psnLogin = GetUserProfilePropertyValue("PSN Name");
			if (!string.IsNullOrEmpty(psnLogin))
			{
				GetDailyRaces gdr = new GetDailyRaces();
				DataTable dt = gdr.Get(regionId);

				if (HttpContext.Current.User.Identity.IsAuthenticated)
				{
					List<RankingInfo> boardIds = new List<RankingInfo>();
					foreach (DataRow dr in dt.Rows)
					{
						RankingInfo ri = new RankingInfo();
						ri.BoardId = Int64.Parse(dr[14].ToString());
						ri.RaceTitle = dr[0].ToString();
						boardIds.Add(ri);
					}
					GetBoardRankings getBoardRankings = new GetBoardRankings();
					DataTable dtr = getBoardRankings.Get(boardIds, psnLogin);
					if (dt.Rows.Count > 0)
					{
						dgvTimes.DataSource = dtr;
						dgvTimes.DataBind();
					}
				}

			}
		}
		private void LoadDailyRaces(Int64 regionId)
		{
			GetDailyRaces gdr = new GetDailyRaces();
			DataTable dt = gdr.Get(regionId);
			dgvRaces.DataSource = dt;
			dgvRaces.DataBind();
		}
		public string GetUserProfilePropertyValue(string propertyName)
		{
			string value = null;
			ProfilePropertyDefinition ppd = UserInfo.Profile.GetProperty(propertyName);

			if (ppd == null)
			{
				value = string.Empty;
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
