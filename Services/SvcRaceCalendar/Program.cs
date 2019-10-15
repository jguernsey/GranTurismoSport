using System.ServiceProcess;

namespace SvcRaceCalendar
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ServiceBase[] servicesToRun = new ServiceBase[]
			{
				new CalendarService()
			};
			ServiceBase.Run(servicesToRun);
		}
	}
}
