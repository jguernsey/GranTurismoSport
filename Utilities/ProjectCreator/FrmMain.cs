using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectCreator
{
	public partial class FrmMain : Form
	{
        string rootFolder = @"C:\dev\GTS\GtsStats\";
        string templateFolder = @"C:\dev\GTS\GtsStats\Template\";
		public FrmMain()
		{
			InitializeComponent();
		}

		private void ClickedCreateProject(object sender, System.EventArgs e)
		{
			string moduleName = txtModuleName.Text.ToString();
			string friendlyName = txtFriendlyName.Text.ToString();
			if(moduleName.Length > 0 && friendlyName.Length > 0)
			{
				string newDirectory = string.Format("{0}{1}\\", rootFolder, moduleName);
				if(!Directory.Exists(newDirectory))
				{
					Directory.CreateDirectory(newDirectory);
				}
				SearchFolder(templateFolder, moduleName, friendlyName);
			}
			MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void SearchFolder(string folder, string moduleName, string friendlyName)
		{
			string[] files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
			foreach(string file in files)
			{
				FileInfo fileInfo = new FileInfo(file);
				string folderName = fileInfo.DirectoryName;
				folderName = folderName.Replace("Template", moduleName);
				if(!Directory.Exists(folderName))
				{
					try
					{
						Directory.CreateDirectory(folderName);
					}
					catch(Exception ex)
					{

					}
				}
				string fileName = fileInfo.Name;
				if(fileName.StartsWith("MODULENAME"))
				{
					fileName = fileName.Replace("MODULENAME", moduleName);
				}
				string newFile = Path.Combine(folderName, fileName);
				try
				{
					using(StreamReader reader = new StreamReader(fileInfo.FullName))
					{
						string line = string.Empty;
						while((line = reader.ReadLine()) != null)
						{
							if(line.Contains("!MODULENAME!"))
							{
								line = line.Replace("!MODULENAME!", moduleName);
							}
							if(line.Contains("!FRIENDLYNAME!"))
							{
								line = line.Replace("!FRIENDLYNAME!", friendlyName);
							}
							using(StreamWriter writer = new StreamWriter(newFile, true))
							{
								writer.WriteLine(line);
							}
						}
					}
				}
				catch(Exception ex)
				{

				}
			}
		}
	}
}
