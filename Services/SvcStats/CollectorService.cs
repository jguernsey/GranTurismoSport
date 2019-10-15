using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Timers;
using Jjg.GtsData.Common;
using Jjg.GtsData.ProfileProcessor;
using Jjg.GtsData.StatsData;

namespace SvcStats
{
	public class CollectorService : ServiceBase
	{
		private System.Timers.Timer svcTimer;

		public CollectorService()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
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

			UpdateRegisteredUsers();

			UpdateActivePlayers();

			UpdateOther();

			svcTimer.Interval = int.Parse(ConfigurationManager.AppSettings["ServiceInterval"].ToString());
			svcTimer.Enabled = true;
			svcTimer.Start();
		}
		private void UpdateRegisteredUsers()
		{
			Int64 totalCount = 0;

			EventWriter writer = new EventWriter();
			writer.Write(string.Format("Start: UpdateRegisteredUsers - {0}", DateTime.Now.ToString()));
			
			GetRegisteredUsers gru = new GetRegisteredUsers();
			List<NumberGroup> numbers = gru.Get(out totalCount);
			
			writer.Write(string.Format("Progress: UpdateRegisteredUsers - {0} - Profiles: {1}", DateTime.Now.ToString(), totalCount));

			DateTime start = DateTime.Now;
			Task[] taskArray = new Task[15]
			{
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[0])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[1])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[2])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[3])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[4])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[5])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[6])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[7])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[8])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[9])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[10])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[11])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[12])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[13])),
				Task.Factory.StartNew(() => ProcessProfileGroup(numbers[14]))
			};
			Task.WaitAll(taskArray);

			TimeSpan timeSpan = DateTime.Now.Subtract(start);
			decimal ps = Convert.ToDecimal(totalCount) / Convert.ToDecimal(timeSpan.TotalSeconds);
			writer.Write(string.Format("End: UpdateRegisteredUsers - Time:\t{0}\tDuration:\t{1}:Count:{2:N0}\tPerSecond:{3:N6}", DateTime.Now.ToString(), timeSpan.ToString(), totalCount, ps));
		}
		private void UpdateActivePlayers()
		{
			GetCountryList gcl = new GetCountryList();
			DataTable dt = gcl.Get();
			foreach(DataRow dr in dt.Rows)
			{
				Int64 totalCount = 0;

				EventWriter writer = new EventWriter();
				writer.Write(string.Format("Start: UpdateActivePlayers - {0}", DateTime.Now.ToString()));

				Int64 countryId = Int64.Parse(dr[0].ToString());

				GetActiveUsers gau = new GetActiveUsers();
				List<NumberGroup> numbers = gau.Get(countryId, out totalCount);
				writer.Write(string.Format("Progress: UpdateActivePlayers - {0} - CountryId: {1} - Profiles: {2}", DateTime.Now.ToString(), countryId, totalCount));

				DateTime start = DateTime.Now;

				Task[] taskArray = new Task[15]
				{
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[0])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[1])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[2])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[3])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[4])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[5])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[6])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[7])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[8])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[9])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[10])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[11])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[12])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[13])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[14]))
				};
				Task.WaitAll(taskArray);

				TimeSpan timeSpan = DateTime.Now.Subtract(start);
				decimal ps = Convert.ToDecimal(totalCount) / Convert.ToDecimal(timeSpan.TotalSeconds);
				writer.Write(string.Format("End: UpdateActivePlayers - Time:\t{0}\tDuration:\t{1}:CountryId:{2}:Count:{3:N0}\tPerSecond:{4:N6}", DateTime.Now.ToString(), timeSpan.ToString(), countryId, totalCount, ps));
			}
		}
		private void UpdateOther()
		{
			GetCountryList gcl = new GetCountryList();
			DataTable dt = gcl.Get();
			foreach (DataRow dr in dt.Rows)
			{
				Int64 totalCount = 0;
				
				EventWriter writer = new EventWriter();
				writer.Write(string.Format("Start: UpdateOther - {0}", DateTime.Now.ToString()));

				Int64 countryId = Int64.Parse(dr[0].ToString());

				GetOtherUsers gou = new GetOtherUsers();
				List<NumberGroup> numbers = gou.Get(countryId, out totalCount);
				writer.Write(string.Format("Progress: UpdateOther - {0} - CountryId: {1} - Profiles: {2}", DateTime.Now.ToString(), countryId, totalCount));
				
				DateTime start = DateTime.Now;

				Task[] taskArray = new Task[15]
				{
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[0])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[1])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[2])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[3])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[4])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[5])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[6])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[7])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[8])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[9])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[10])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[11])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[12])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[13])),
					Task.Factory.StartNew(() => ProcessProfileGroup(numbers[14]))
				};
				Task.WaitAll(taskArray);

				TimeSpan timeSpan = DateTime.Now.Subtract(start);
				decimal ps = Convert.ToDecimal(totalCount) / Convert.ToDecimal(timeSpan.TotalSeconds);
				writer.Write(string.Format("End: UpdateOther - Time:\t{0}\tDuration:\t{1}:CountryId:{2}:Count:{3:N0}\tPerSecond:{4:N6}", DateTime.Now.ToString(), timeSpan.ToString(), countryId, totalCount, ps));
			}
		}
		
		private void ProcessProfileGroup(NumberGroup numberGroup)
		{
			NumberGroupProcessor ngp = new NumberGroupProcessor();
			ngp.Process(numberGroup);
		}
		
		private void InitializeComponent()
		{
			this.AutoLog = false;
			this.ServiceName = "SvcStats";
		}
	}
}
