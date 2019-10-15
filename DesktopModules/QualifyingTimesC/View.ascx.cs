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

namespace Jjg.GtsStats.QualifyingTimesC
{
	public partial class View : QualifyingTimesCModuleBase, IActionable
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

			string raceC = "Daily Race C";

			GetRaceTimes rc = new GetRaceTimes();
			DataTable regionC = rc.Get(regionId, raceC);
			dgvRegionC.DataSource = regionC;
			dgvRegionC.DataBind();

			GetWorldRankingsByTitle gc = new GetWorldRankingsByTitle();
			DataTable worldC = gc.Get(raceC);
			dgvWorldC.DataSource = worldC;
			dgvWorldC.DataBind();

			GetUserTimes(regionId);
			LoadRaceData(psnLogin);
		}
		private void LoadRaceData(string username)
		{
			if (!string.IsNullOrEmpty(username))
			{
				GetRaceInfoByRaceType gudrc = new GetRaceInfoByRaceType();
				DataTable dt = gudrc.Get(username, "Daily Race C");
				if (dt.Rows.Count > 0)
				{
					dgvRaces.DataSource = dt;
					dgvRaces.DataBind();
				}
			}
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
						DataTable userC = new DataTable();
						userC.Columns.Add("Region", typeof(string));
						userC.Columns.Add("World", typeof(string));
						userC.Columns.Add("Time", typeof(string));
						userC.Columns.Add("RegionGap", typeof(string));
						userC.Columns.Add("WorldGap", typeof(string));
						userC.Columns.Add("RegionNext", typeof(string));
						userC.Columns.Add("WorldNext", typeof(string));

						foreach (DataRow d in dtr.Rows)
						{
							string raceTitle = d[0].ToString();
							switch (raceTitle)
							{
								case "Daily Race C":
									userC.Rows.Add(string.Format("{0}/{1}", d[1].ToString(), d[2].ToString()), string.Format("{0}/{1}", d[3].ToString(), d[4].ToString()), d[5].ToString(), d[6].ToString(), d[7].ToString(), d[8].ToString(), d[9].ToString());
									break;
							}
						}
						dgvUserC.DataSource = userC;
						dgvUserC.DataBind();
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
