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
using Jjg.GtsData.Common;
using Jjg.GtsData.RaceEvents;
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
					if (dtr.Rows.Count > 0)
					{
						DataTable userA = new DataTable();
						userA.Columns.Add("RegionRank", typeof(string));
						userA.Columns.Add("RegionTotal", typeof(string));
						userA.Columns.Add("WorldRank", typeof(string));
						userA.Columns.Add("WorldTotal", typeof(string));
						userA.Columns.Add("Time", typeof(string));
						userA.Columns.Add("RegionGap", typeof(string));
						userA.Columns.Add("WorldGap", typeof(string));
						userA.Columns.Add("RegionNext", typeof(string));
						userA.Columns.Add("WorldNext", typeof(string));

						DataTable userB = new DataTable();
						userB.Columns.Add("RegionRank", typeof(string));
						userB.Columns.Add("RegionTotal", typeof(string));
						userB.Columns.Add("WorldRank", typeof(string));
						userB.Columns.Add("WorldTotal", typeof(string));
						userB.Columns.Add("Time", typeof(string));
						userB.Columns.Add("RegionGap", typeof(string));
						userB.Columns.Add("WorldGap", typeof(string));
						userB.Columns.Add("RegionNext", typeof(string));
						userB.Columns.Add("WorldNext", typeof(string));

						DataTable userC = new DataTable();
						userC.Columns.Add("RegionRank", typeof(string));
						userC.Columns.Add("RegionTotal", typeof(string));
						userC.Columns.Add("WorldRank", typeof(string));
						userC.Columns.Add("WorldTotal", typeof(string));
						userC.Columns.Add("Time", typeof(string));
						userC.Columns.Add("RegionGap", typeof(string));
						userC.Columns.Add("WorldGap", typeof(string));
						userC.Columns.Add("RegionNext", typeof(string));
						userC.Columns.Add("WorldNext", typeof(string));

						DataTable userN = new DataTable();
						userN.Columns.Add("RegionRank", typeof(string));
						userN.Columns.Add("RegionTotal", typeof(string));
						userN.Columns.Add("WorldRank", typeof(string));
						userN.Columns.Add("WorldTotal", typeof(string));
						userN.Columns.Add("Time", typeof(string));
						userN.Columns.Add("RegionGap", typeof(string));
						userN.Columns.Add("WorldGap", typeof(string));
						userN.Columns.Add("RegionNext", typeof(string));
						userN.Columns.Add("WorldNext", typeof(string));

						DataTable userM = new DataTable();
						userM.Columns.Add("RegionRank", typeof(string));
						userM.Columns.Add("RegionTotal", typeof(string));
						userM.Columns.Add("WorldRank", typeof(string));
						userM.Columns.Add("WorldTotal", typeof(string));
						userM.Columns.Add("Time", typeof(string));
						userM.Columns.Add("RegionGap", typeof(string));
						userM.Columns.Add("WorldGap", typeof(string));
						userM.Columns.Add("RegionNext", typeof(string));
						userM.Columns.Add("WorldNext", typeof(string));

						foreach(DataRow d in dtr.Rows)
						{
							string raceTitle = d[0].ToString();
							switch(raceTitle)
							{
								case "Daily Race A":
									userA.Rows.Add(d[1].ToString(), d[2].ToString(), d[3].ToString(), d[4].ToString(), d[5].ToString(), d[6].ToString(), d[7].ToString(), d[8].ToString(), d[9].ToString());
									break;
								case "Daily Race B":
									userB.Rows.Add(d[1].ToString(), d[2].ToString(), d[3].ToString(), d[4].ToString(), d[5].ToString(), d[6].ToString(), d[7].ToString(), d[8].ToString(), d[9].ToString());
									break;
								case "Daily Race C":
									userC.Rows.Add(d[1].ToString(), d[2].ToString(), d[3].ToString(), d[4].ToString(), d[5].ToString(), d[6].ToString(), d[7].ToString(), d[8].ToString(), d[9].ToString());
									break;
								case "FIA GT Nations Cup":
									userN.Rows.Add(d[1].ToString(), d[2].ToString(), d[3].ToString(), d[4].ToString(), d[5].ToString(), d[6].ToString(), d[7].ToString(), d[8].ToString(), d[9].ToString());
									break;
								case "FIA GT Manufacturer Series":
									userM.Rows.Add(d[1].ToString(), d[2].ToString(), d[3].ToString(), d[4].ToString(), d[5].ToString(), d[6].ToString(), d[7].ToString(), d[8].ToString(), d[9].ToString());
									break;
							}
						}
						dgvUserA.DataSource = userA;
						dgvUserA.DataBind();

						dgvUserB.DataSource = userB;
						dgvUserB.DataBind();

						dgvUserC.DataSource = userC;
						dgvUserC.DataBind();

						dgvUserN.DataSource = userN;
						dgvUserN.DataBind();

						dgvUserM.DataSource = userM;
						dgvUserM.DataBind();
					}
				}
			}
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
