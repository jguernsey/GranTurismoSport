using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ImageUploader
{
	public partial class FrmMain : Form
	{
		private string sourceFolder = @"C:\GTS\images\";
		public FrmMain()
		{
			InitializeComponent();
		}

		private void ClickedStart(object sender, System.EventArgs e)
		{
			string[] images = Directory.GetFiles(sourceFolder, "*.png", SearchOption.TopDirectoryOnly);
			foreach(string image in images)
			{
				FileInfo fileInfo = new FileInfo(image);
				string name = fileInfo.Name.Replace(".png", string.Empty);
				byte[] imageData = ImageToBase64(image);
				InsertImage(imageData, Int64.Parse(name));
			}
		}
		private void InsertImage(byte[] imageData, Int64 countryId)
		{
			using (SqlConnection conn = new SqlConnection(DbConn.Get()))
			{
				SqlCommand cmd = new SqlCommand("GTS_UpdateManufacturerImage", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add("@PDCode", SqlDbType.BigInt).Value = countryId;
				cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = imageData;
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}
		private byte[] ImageToBase64(string imagePath)
		{
			byte[] imageBytes = null;
			try
			{
				using (FileStream fs = new FileStream(imagePath, FileMode.Open))
				{
					imageBytes = new Byte[fs.Length];
					fs.Read(imageBytes, 0, imageBytes.Length);
				}
			}
			catch (Exception ex)
			{

			}
			return imageBytes;
		}
	}
}
