using System;
using System.Configuration;
using System.ServiceProcess;
using System.Timers;
using Jjg.GtsData.LapTimes;
using Jjg.GtsData.StatsData;

namespace SvcLapTimes
{
	public class LapTimeService : ServiceBase
	{
        private const double DefaultInterval = 300000;

        private Timer qualifyingTimer;

        private double interval;

        public LapTimeService()
        {
            this.InitializeComponent();
        }

        private double GetTimerInterval()
        {
            double interval = 300000;
            try
            {
                interval = !double.TryParse(ConfigurationManager.AppSettings["ServiceInterval"].ToString(), out interval) || interval <= 10000 ? 300000 : double.Parse(ConfigurationManager.AppSettings["ServiceInterval"].ToString());
            }
            catch (Exception exception)
            {
                Exception ex = exception;
                interval = 300000;
                new EventWriter().Write(ex.ToString());
            }
            return interval;
        }

        private void InitializeComponent()
        {
            base.AutoLog = false;
            base.ServiceName = "SvcLapTimes";
        }

        protected override void OnStart(string[] args)
        {
            this.interval = this.GetTimerInterval();
            this.qualifyingTimer = new Timer();
            this.qualifyingTimer.Elapsed += new ElapsedEventHandler(this.QualifyingTimerElapsed);
            this.qualifyingTimer.Interval = 5000;
            this.qualifyingTimer.Enabled = true;
            this.qualifyingTimer.AutoReset = false;
            this.qualifyingTimer.Start();
        }

        private void QualifyingTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.qualifyingTimer.AutoReset = false;
            this.qualifyingTimer.Enabled = false;
            this.qualifyingTimer.Stop();
            this.UpdateQualifyingTimes();
            this.qualifyingTimer.Interval = this.interval;
            this.qualifyingTimer.Enabled = true;
            this.qualifyingTimer.Start();
        }

        private void UpdateQualifyingTimes()
        {
            new GetUpdatedQualifyingTimes().Get();
        }
    }
}
