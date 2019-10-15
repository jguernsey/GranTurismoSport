using System.ServiceProcess;

namespace SvcStats
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ServiceBase[] servicesToRun = new ServiceBase[]
			{
				new CollectorService()
			};
			ServiceBase.Run(servicesToRun);
		}
	}
}
