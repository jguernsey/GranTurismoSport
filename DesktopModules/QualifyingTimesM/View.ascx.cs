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
using Jjg.GtsData.RaceEvents;
using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.QualifyingTimesM
{
	public partial class View : QualifyingTimesMModuleBase, IActionable
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
                    GetFiaRegionId getRegionId = new GetFiaRegionId();
                    regionId = getRegionId.Get(psnLogin);
                }
            }

            string raceA = "FIA Gran Turismo Championship // Manufacturer Series";

            GetRaceTimes ra = new GetRaceTimes();
            DataTable regionA = ra.Get(regionId, raceA);
            dgvRegionM.DataSource = regionA;
            dgvRegionM.DataBind();

            GetWorldRankingsByTitle ga = new GetWorldRankingsByTitle();
            DataTable worldA = ga.Get(raceA);
            dgvWorldM.DataSource = worldA;
            dgvWorldM.DataBind();

            GetUserTimes(regionId);
            LoadRaceData(psnLogin, regionId);
        }
		private void LoadRaceData(string username, long regionId)
		{
			GetFiaManufacturerRaces gudrc = new GetFiaManufacturerRaces();
			DataTable dt = gudrc.Get();
			if (dt.Rows.Count > 0)
			{
				dgvRaces.DataSource = dt;
				dgvRaces.DataBind();
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
                        RankingInfo ri = new RankingInfo
                        {
                            BoardId = long.Parse(dr[14].ToString()),
                            RaceTitle = dr[0].ToString()
                        };
                        boardIds.Add(ri);
					}
					GetBoardRankings getBoardRankings = new GetBoardRankings();
					DataTable dtr = getBoardRankings.Get(boardIds, psnLogin);
					if (dtr.Rows.Count > 0)
					{
						DataTable userM = new DataTable();
						userM.Columns.Add("Region", typeof(string));
						userM.Columns.Add("World", typeof(string));
						userM.Columns.Add("Time", typeof(string));
						userM.Columns.Add("RegionGap", typeof(string));
						userM.Columns.Add("WorldGap", typeof(string));
						userM.Columns.Add("RegionNext", typeof(string));
						userM.Columns.Add("WorldNext", typeof(string));

						foreach (DataRow d in dtr.Rows)
						{
							string raceTitle = d[0].ToString();
							switch (raceTitle)
							{
								case "FIA Gran Turismo Championship // Manufacturer Series":
									userM.Rows.Add(string.Format("{0}/{1}", d[1].ToString(), d[2].ToString()), string.Format("{0}/{1}", d[3].ToString(), d[4].ToString()), d[5].ToString(), d[6].ToString(), d[7].ToString(), d[8].ToString(), d[9].ToString());
									break;
							}
						}
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
