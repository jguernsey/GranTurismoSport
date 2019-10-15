using System;
using System.Collections.Generic;
using System.Configuration;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Timers;
using Jjg.GtsData.Common;
using Jjg.GtsData.ProfileProcessor;
using Jjg.GtsData.StatsData;

namespace SvcUserProfiles
{
	public class ProfileService : ServiceBase
	{
		private System.Timers.Timer svcTimer;
		public ProfileService()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			EventWriter writer = new EventWriter();
			writer.Write(string.Format("Service Started at: {0}", DateTime.Now.ToString()));

			svcTimer = new System.Timers.Timer();
			svcTimer.Elapsed += new ElapsedEventHandler(ServiceTimerElapsed);
			svcTimer.Interval = 5000;
			svcTimer.Enabled = true;
			svcTimer.AutoReset = false;
			svcTimer.Start();
		}

		private void ServiceTimerElapsed(object sender, ElapsedEventArgs e)
		{
			svcTimer.AutoReset = false;
			svcTimer.Enabled = false;
			svcTimer.Stop();

			GetNewProfiles();

			svcTimer.Interval = int.Parse(ConfigurationManager.AppSettings["ServiceInterval"].ToString()); 
			svcTimer.Enabled = true;
			svcTimer.Start();
		}

		private void GetNewProfiles()
		{
			Int64 totalCount = 0;
			InitializeProfiles ip = new InitializeProfiles();
			ip.Initialize();
			GetProfileGroups gpg = new GetProfileGroups();
			List<NumberGroup> groups = gpg.Get(out totalCount);

			DateTime start = DateTime.Now;
			LogEvent("Start", string.Format("ProcessProfileGroups - {0:N0} Profiles", totalCount));
			Task[] taskArray = new Task[15]
			{
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[0])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[1])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[2])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[3])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[4])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[5])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[6])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[7])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[8])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[9])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[10])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[11])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[12])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[13])),
				Task.Factory.StartNew(() => ProcessProfileGroup(groups[14])),
			};
			Task.WaitAll(taskArray);

			TimeSpan ts = DateTime.Now.Subtract(start);
			decimal perSecond = (Convert.ToDecimal(totalCount) / Convert.ToDecimal(ts.TotalSeconds));
			LogEvent("End", string.Format("GetNewProfiles::TC:{0}::T:{1}::PS:{2}", totalCount, ts.ToString(), perSecond));
		}
		private void ProcessProfileGroup(NumberGroup group)
		{
			ProfileGroupProcessor pgp = new ProfileGroupProcessor();
			pgp.Process(group);
		}
		private void LogEvent(string type, string method)
		{
			DateTime eventTime = DateTime.Now;
			string message = string.Format("{0}:{1}:{2}", type, method, eventTime.ToString());

			EventWriter writer = new EventWriter();
			writer.Write(message);
		}

		private void InitializeComponent()
		{
			this.AutoLog = false;
			this.ServiceName = "SvcUserProfiles";
		}
	}
}
