using Jjg.GtsData.Profiles;
using System.Configuration;
using System.ServiceProcess;
using System.Timers;

namespace SvcProfiles
{
    public class ProfileService : ServiceBase
    {
        private Timer svcTimer;

        public ProfileService()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            base.AutoLog = false;
            base.ServiceName = "SvcProfiles";
        }

        protected override void OnStart(string[] args)
        {
            this.svcTimer = new Timer();
            this.svcTimer.Elapsed += new ElapsedEventHandler(this.ServiceTimerElapsed);
            this.svcTimer.Interval = 1000;
            this.svcTimer.Enabled = true;
            this.svcTimer.AutoReset = false;
            this.svcTimer.Start();
        }

        private void ServiceTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.svcTimer.AutoReset = false;
            this.svcTimer.Enabled = false;
            this.svcTimer.Stop();
            new GetNewProfiles().Get();
            this.svcTimer.Interval = int.Parse(ConfigurationManager.AppSettings["ServiceInterval"].ToString());
            this.svcTimer.Enabled = true;
            this.svcTimer.Start();
        }
    }
}
