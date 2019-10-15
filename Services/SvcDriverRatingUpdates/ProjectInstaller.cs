using System;
using System.ComponentModel;
using System.Linq;

namespace SvcDriverRatingUpdates
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer
	{
		public ProjectInstaller()
		{
			InitializeComponent();
		}
	}
}
