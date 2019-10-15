using System;
using System.Configuration;
using System.ServiceProcess;
using System.Timers;
using Jjg.GtsData.RaceCalendar;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace SvcRaceCalendar
{
	public class CalendarService : ServiceBase
	{
		private Timer seasonsTimer;
        private Timer headerTimer;

		public CalendarService()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
            InitializeSeasonTimer();
            InitializeHeaderTimer();
		}
        private void HeaderTimerElapsed(object sender, ElapsedEventArgs e)
        {
            headerTimer.AutoReset = false;
            headerTimer.Enabled = false;
            headerTimer.Stop();

            GetRaceHeader();
            GetRaceDetails();

            headerTimer.Interval = GetTimerInterval("Headers");
            headerTimer.Enabled = true;
            headerTimer.Start();
        }
		private void SeasonsTimerElapsed(object sender, ElapsedEventArgs e)
		{
            this.seasonsTimer.AutoReset = false;
            this.seasonsTimer.Enabled = false;
            this.seasonsTimer.Stop();

            this.GetSeasonDetails();

            this.seasonsTimer.Interval = this.GetTimerInterval("Seasons");
            this.seasonsTimer.Enabled = true;
            this.seasonsTimer.Start();
        }
		private void GetSeasonDetails()
		{
            SeasonDetailsProcessor seasonDetailsProcessor = new SeasonDetailsProcessor();
            seasonDetailsProcessor.Process();
		}
		private void GetRaceHeader()
		{
            RaceHeaderProcessor raceHeader = new RaceHeaderProcessor();
            raceHeader.Process();
		}

		private void GetRaceDetails()
		{
            RaceDetailProcessor raceDetailProcessor = new RaceDetailProcessor();
            raceDetailProcessor.Process();
		}

        private double GetTimerInterval(string name)
        {
            double interval = 900000;
            try
            {
                if(!double.TryParse(ConfigurationManager.AppSettings[name].ToString(), out interval))
                {
                    interval = 900000;
                }
            }
            catch(Exception ex)
            {
                interval = 900000;
                EventWriter eventWriter = new EventWriter();
                eventWriter.Write(ex.ToString());
            }
            return interval;
        }
        private void InitializeHeaderTimer()
        {
            headerTimer = new Timer();
            headerTimer.Elapsed += new ElapsedEventHandler(HeaderTimerElapsed);
            headerTimer.Interval = 5000;
            headerTimer.Enabled = true;
            headerTimer.AutoReset = false;
            headerTimer.Start();
        }
        private void InitializeSeasonTimer()
        {
            seasonsTimer = new Timer();
            seasonsTimer.Elapsed += new ElapsedEventHandler(SeasonsTimerElapsed);
            seasonsTimer.Interval = 5000;
            seasonsTimer.Enabled = true;
            seasonsTimer.AutoReset = false;
            seasonsTimer.Start();
        }
		private double GetNextCycleTime()
		{
			double nextCycleTime = 0;
			TimeSpan ts = new TimeSpan(0);
			try
			{
				int hourToRun = int.Parse(ConfigurationManager.AppSettings["HourToRun"].ToString());
				int minuteToRun = int.Parse(ConfigurationManager.AppSettings["MinuteToRun"].ToString());

				DateTime current = DateTime.Now;
				DateTime nextRun = new DateTime(current.Year, current.Month, current.Day, hourToRun, minuteToRun, 0);

				if (current < nextRun)
				{
					ts = nextRun.Subtract(current);
				}
				else
				{
					ts = nextRun.Subtract(current).Add(new TimeSpan(24, 0, 0));
				}
				nextCycleTime = ts.TotalMilliseconds;
			}
			catch (Exception ex)
			{
				EventWriter writerE = new EventWriter();
				writerE.Write(ex.ToString());

				nextCycleTime = 86400000;
			}
			EventWriter writer = new EventWriter();
			writer.Write(string.Format("Next Cycle Time Set To: {0}", ts.ToString()));
			return nextCycleTime;
		}

		private void InitializeComponent()
		{
			// 
			// CalendarService
			// 
			this.AutoLog = false;
			this.ServiceName = "SvcRaceCalendar";

		}
	}
}
