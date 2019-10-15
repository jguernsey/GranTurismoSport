using System.ServiceProcess;

namespace SvcDriverRatingUpdates
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ServiceBase[] servicesToRun = new ServiceBase[]
			{
				new DriverRatingService()
			};
			ServiceBase.Run(servicesToRun);
		}
	}
}
