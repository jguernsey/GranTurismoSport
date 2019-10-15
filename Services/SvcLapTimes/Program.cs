using System.ServiceProcess;

namespace SvcLapTimes
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ServiceBase[] servicesToRun = new ServiceBase[]
			{
				new LapTimeService()
			};
			ServiceBase.Run(servicesToRun);
		}
	}
}
