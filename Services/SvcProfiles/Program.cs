using System.ServiceProcess;

namespace SvcProfiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceBase[] servicesToRun = new ServiceBase[]
{
                new ProfileService()
};
            ServiceBase.Run(servicesToRun);
        }
    }
}
