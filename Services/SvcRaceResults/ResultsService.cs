using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Timers;
using Jjg.GtsData.Common;
using Jjg.GtsData.ProfileProcessor;
using Jjg.GtsData.RaceEvents;
using Jjg.GtsData.RaceResults;
using Jjg.GtsData.StatsData;

namespace SvcRaceResults
{
	public class ResultsService : ServiceBase
	{
        private Timer manufacturersTimer;

        private Timer nationsTimer;

        private Timer registeredTimer;

        private Timer activeTimer;

        public ResultsService()
        {
            this.InitializeComponent();
        }

        private void ActiveTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.activeTimer.AutoReset = false;
            this.activeTimer.Enabled = false;
            this.activeTimer.Stop();
            this.GetActiveRaceResults();
            this.activeTimer.Interval = this.GetInterval("ActiveInterval");
            this.activeTimer.Enabled = true;
            this.activeTimer.Start();
        }

        private void GetActiveRaceResults()
        {
            new ActiveRaceResults().Get();
        }

        private void GetDailyRaceResults()
        {
            new DailyRaceResults().Get();
        }

        private double GetInterval(string name)
        {
            double interval = 0;
            try
            {
                if (!double.TryParse(ConfigurationManager.AppSettings[name].ToString(), out interval))
                {
                    interval = 900000;
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
                interval = 900000;
            }
            return interval;
        }

        private void GetManufacturerSeriesResults()
        {
            new GetManufacturerSeriesResults().Get();
        }

        private void GetNationsCupResults()
        {
            new GetNationsCupResults().Get();
        }

        private void InitalizeNationsTimer()
        {
            this.nationsTimer = new Timer();
            this.nationsTimer.Elapsed += new ElapsedEventHandler(this.NationsTimerElapsed);
            this.nationsTimer.Interval = 5000;
            this.nationsTimer.Enabled = true;
            this.nationsTimer.AutoReset = false;
            this.nationsTimer.Start();
        }

        private void InitializeActiveTimer()
        {
            this.activeTimer = new Timer();
            this.activeTimer.Elapsed += new ElapsedEventHandler(this.ActiveTimerElapsed);
            this.activeTimer.Interval = 5000;
            this.activeTimer.Enabled = true;
            this.activeTimer.AutoReset = false;
            this.activeTimer.Start();
        }

        private void InitializeComponent()
        {
            base.AutoLog = false;
            base.ServiceName = "SvcResultsService";
        }

        private void InitializeManufacturerTimer()
        {
            this.manufacturersTimer = new Timer();
            this.manufacturersTimer.Elapsed += new ElapsedEventHandler(this.ManufacturerTimerElapsed);
            this.manufacturersTimer.Interval = 5000;
            this.manufacturersTimer.Enabled = true;
            this.manufacturersTimer.AutoReset = false;
            this.manufacturersTimer.Start();
        }

        private void InitializeRegisteredTimer()
        {
            this.registeredTimer = new Timer();
            this.registeredTimer.Elapsed += new ElapsedEventHandler(this.RegisteredTimerElapsed);
            this.registeredTimer.Interval = 5000;
            this.registeredTimer.Enabled = true;
            this.registeredTimer.AutoReset = false;
            this.registeredTimer.Start();
        }

        private void ManufacturerTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.manufacturersTimer.AutoReset = false;
            this.manufacturersTimer.Enabled = false;
            this.manufacturersTimer.Stop();
            this.GetManufacturerSeriesResults();
            this.manufacturersTimer.Interval = this.GetInterval("ManInterval");
            this.manufacturersTimer.Enabled = true;
            this.manufacturersTimer.Start();
        }

        private void NationsTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.nationsTimer.AutoReset = false;
            this.nationsTimer.Enabled = false;
            this.nationsTimer.Stop();
            this.GetNationsCupResults();
            this.nationsTimer.Interval = this.GetInterval("NatInterval");
            this.nationsTimer.Enabled = true;
            this.nationsTimer.Start();
        }

        protected override void OnStart(string[] args)
        {
            this.InitializeManufacturerTimer();
            this.InitalizeNationsTimer();
            this.InitializeRegisteredTimer();
            this.InitializeActiveTimer();
        }

        private void RegisteredTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.registeredTimer.AutoReset = false;
            this.registeredTimer.Enabled = false;
            this.registeredTimer.Stop();
            this.GetDailyRaceResults();
            this.registeredTimer.Interval = this.GetInterval("RegisteredInterval");
            this.registeredTimer.Enabled = true;
            this.registeredTimer.Start();
        }
    }
}
