using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Timers;
using Jjg.GtsData.Common;
using Jjg.GtsData.RaceEvents;
using Jjg.GtsData.StatsData;

namespace SvcDriverRatingUpdates
{
	public class DriverRatingService : ServiceBase
	{
		private Timer svcTimer;
		public string nextUpdateType;
		public DriverRatingService()
		{
			InitializeComponent();
		}
		protected override void OnStart(string[] args)
		{
			svcTimer = new Timer();
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

			UpdateDriverRatingScore();
		}
		private void UpdateDriverRatingScore()
		{
			EventWriter writer = new EventWriter();
			writer.Write("Start UpdateDriverRatingScore");

			Int64 totalCount = 0;
			GetDriverRatingUpdateProfiles getProfiles = new GetDriverRatingUpdateProfiles();
			List<NumberGroup> numbers = getProfiles.Get(out totalCount);

			Task[] taskArray = new Task[10]
			{
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[0])),
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[1])),
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[2])),
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[3])),
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[4])),
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[5])),
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[6])),
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[7])),
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[8])),
				Task.Factory.StartNew(() => UpdateDriverRating(numbers[9]))
			};
			Task.WaitAll(taskArray);

			DriverRatingUpdateTime nextTime = GetNextCycleTime();
			TimeSpan next = nextTime.UpdateTime.Subtract(DateTime.Now);
			nextUpdateType = nextTime.TimeType;
			svcTimer.Interval = next.TotalMilliseconds;
			svcTimer.Enabled = true;
			svcTimer.Start();
		}
		private void UpdateDriverRating(NumberGroup group)
		{
			GetCurrentDriverRating gcdr = new GetCurrentDriverRating();
			gcdr.Get(group.Numbers, nextUpdateType);
		}

		private DriverRatingUpdateTime GetNextCycleTime()
		{
			DriverRatingUpdateTime nextTime = new DriverRatingUpdateTime();
			nextTime.TimeType = "Start";
			nextTime.UpdateTime = DateTime.Now.Add(TimeSpan.FromMinutes(3));
			try
			{
				GetNextUpdateTime gnut = new GetNextUpdateTime();
				nextTime = gnut.Get();
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return nextTime;
		}

		private void InitializeComponent()
		{
			this.AutoLog = false;
			this.ServiceName = "SvcDriverRatingUpdates";

		}
	}
}
