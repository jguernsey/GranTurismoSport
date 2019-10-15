using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Jjg.GtsCollector.Common;
using Jjg.GtsCollector.RaceEvents;
using Jjg.GtsData.ImageReader;
using Newtonsoft.Json;

namespace Tester
{
	public partial class FrmMain : Form
	{
		private string jsonFile = @"D:\GTS\json\seasoninformation.json";
		
		public FrmMain()
		{
			InitializeComponent();
		}

		private void ClickedTestJsonStringReader(object sender, EventArgs e)
		{
			using (StreamReader reader = new StreamReader(jsonFile))
			{
				string line = string.Empty;
				while ((line = reader.ReadLine()) != null)
				{
					if (!string.IsNullOrEmpty(line))
					{
						try
						{


							SeasonInformation si = JsonConvert.DeserializeObject<SeasonInformation>(line);

							foreach (Season s in si.seasons)
							{
								try
								{

								}
								catch(Exception ex)
								{
									MessageBox.Show(ex.ToString());
								}
							}
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString());
						}
					}
				}
			}
		}

		private void ClickedTestRaceEventReader(object sender, EventArgs e)
		{
			GetDailyRaceData gdr = new GetDailyRaceData();
			gdr.Get();
		}

		private void ClickedGetRankings(object sender, EventArgs e)
		{
			Int64 regionId = 3;

			List<RankingInfo> boardIds = new List<RankingInfo>();

			RankingInfo ri = new RankingInfo();
			ri.BoardId = 1001719;
			ri.RaceTitle = "Daily Race A";
			boardIds.Add(ri);

			RankingInfo ri2 = new RankingInfo();
			ri2.BoardId = 1001720;
			ri2.RaceTitle = "Daily Race B";
			boardIds.Add(ri2);

			RankingInfo ri3 = new RankingInfo();
			ri3.BoardId = 1001721;
			ri3.RaceTitle = "Daily Race C";
			boardIds.Add(ri3);

			RankingInfo ri4 = new RankingInfo();
			ri4.BoardId = 1005375;
			ri4.RaceTitle = "FIA GT Nations Cup";
			boardIds.Add(ri4);

			RankingInfo ri5 = new RankingInfo();
			ri5.BoardId = 1005376;
			ri5.RaceTitle = "FIA GT Manufacturer Series";
			boardIds.Add(ri5);
			
			GetUserRankings(boardIds, regionId);
		}
		public void GetUserRankings(List<RankingInfo> boardIds, Int64 regionId)
		{
			string psnLogin = "lowlyfe45";
			if (!string.IsNullOrEmpty(psnLogin))
			{
				GetBoardRankings getBoardRankings = new GetBoardRankings();
				DataTable dt = getBoardRankings.Get(boardIds, psnLogin);
				if (dt.Rows.Count > 0)
				{

				}
			}
		}

		private void ClickedTestImageReader(object sender, EventArgs e)
		{
			string testImage = @"D:\GTS\json\images\testGrid.jpg";
			string outputImage = @"D:\GTS\json\images\testGridOut.jpg";
			Bitmap workBmp = new Bitmap(testImage);
			Bitmap testBmp = workBmp.Clone(new Rectangle(0, 0, workBmp.Width, workBmp.Height), PixelFormat.Format16bppRgb555);

			int x = testBmp.Width;
			int y = testBmp.Height;

			Bitmap outBmp = new Bitmap(x, y);

			for (int yi = 0; yi < y; yi++)
			{
				int blackCount = 0;
				int whiteCount = 0;
				for (int xi = 0; xi < x; xi++)
				{
					if(yi < 50)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if(yi >= 150 && yi <= 200)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 300 && yi <= 350)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 450 && yi <= 500)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 600 && yi <= 650)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 750 && yi <= 800)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 900 && yi <= 950)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 1050 && yi <= 1100)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 1200 && yi <= 1250)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 1350 && yi <= 1400)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 1500 && yi <= 1550)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 1650 && yi <= 1700)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 1800 && yi <= 1850)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else if (yi >= 1950 && yi <= 2000)
					{
						outBmp.SetPixel(xi, yi, Color.White);
					}
					else
					{
						if (xi < 200)
						{
							outBmp.SetPixel(xi, yi, Color.White);
						}
						else if (xi >= 900 && xi <= 2150)
						{
							outBmp.SetPixel(xi, yi, Color.White);
						}
						else if (xi >= 2725)
						{
							outBmp.SetPixel(xi, yi, Color.White);
						}
						else
						{
							Color pColor = testBmp.GetPixel(xi, yi);
							if ((pColor.R >= 230 && pColor.G >= 230 && pColor.B >= 230) || (pColor.R >= 222 && pColor.G >= 235 && pColor.B >= 235) || (pColor.R >= 235 && pColor.G >= 222 && pColor.B >= 235) || (pColor.R >= 235 && pColor.G >= 235 && pColor.B >= 222))
							{
								outBmp.SetPixel(xi, yi, Color.Black);
								blackCount++;
								if (blackCount >= 40)
								{
									outBmp.SetPixel(xi, yi, Color.White);
									outBmp.SetPixel(xi - 1, yi, Color.White);
									outBmp.SetPixel(xi - 2, yi, Color.White);
									outBmp.SetPixel(xi - 3, yi, Color.White);
									outBmp.SetPixel(xi - 4, yi, Color.White);
									outBmp.SetPixel(xi - 5, yi, Color.White);
									outBmp.SetPixel(xi - 6, yi, Color.White);
									outBmp.SetPixel(xi - 7, yi, Color.White);
									outBmp.SetPixel(xi - 8, yi, Color.White);
									outBmp.SetPixel(xi - 9, yi, Color.White);
									outBmp.SetPixel(xi - 10, yi, Color.White);
									outBmp.SetPixel(xi - 11, yi, Color.White);
									outBmp.SetPixel(xi - 12, yi, Color.White);
									outBmp.SetPixel(xi - 13, yi, Color.White);
									outBmp.SetPixel(xi - 14, yi, Color.White);
									outBmp.SetPixel(xi - 15, yi, Color.White);
									outBmp.SetPixel(xi - 16, yi, Color.White);
									outBmp.SetPixel(xi - 17, yi, Color.White);
									outBmp.SetPixel(xi - 18, yi, Color.White);
									outBmp.SetPixel(xi - 19, yi, Color.White);
									outBmp.SetPixel(xi - 20, yi, Color.White);
									outBmp.SetPixel(xi - 21, yi, Color.White);
									outBmp.SetPixel(xi - 22, yi, Color.White);
									outBmp.SetPixel(xi - 23, yi, Color.White);
									outBmp.SetPixel(xi - 24, yi, Color.White);
									outBmp.SetPixel(xi - 25, yi, Color.White);
									outBmp.SetPixel(xi - 26, yi, Color.White);
									outBmp.SetPixel(xi - 27, yi, Color.White);
									outBmp.SetPixel(xi - 28, yi, Color.White);
									outBmp.SetPixel(xi - 29, yi, Color.White);
									outBmp.SetPixel(xi - 30, yi, Color.White);
									outBmp.SetPixel(xi - 31, yi, Color.White);
									outBmp.SetPixel(xi - 32, yi, Color.White);
									outBmp.SetPixel(xi - 33, yi, Color.White);
									outBmp.SetPixel(xi - 34, yi, Color.White);
									outBmp.SetPixel(xi - 35, yi, Color.White);
									outBmp.SetPixel(xi - 36, yi, Color.White);
									outBmp.SetPixel(xi - 37, yi, Color.White);
									outBmp.SetPixel(xi - 38, yi, Color.White);
									outBmp.SetPixel(xi - 39, yi, Color.White);
									blackCount = 0;
								}
							}
							else
							{
								if(blackCount < 4 && xi > 4)
								{
									outBmp.SetPixel(xi - 1, yi, Color.White);
									outBmp.SetPixel(xi - 2, yi, Color.White);
									outBmp.SetPixel(xi - 3, yi, Color.White);
									outBmp.SetPixel(xi - 4, yi, Color.White);
								}
								outBmp.SetPixel(xi, yi, Color.White);
								whiteCount++;
								blackCount = 0;
							}
						}
					}
				}
			}
			outBmp.Save(@"D:\GTS\json\images\blacktest.jpg");
			decimal scale = 1;
			int maxSize = 2100;
			if (x > maxSize)
			{
				if (x > y)
				{
					scale = (Convert.ToDecimal(maxSize) / Convert.ToDecimal(x));
					x = maxSize;
					y = Convert.ToInt32(Convert.ToDecimal(y) * scale);
				}
				else if (y > x)
				{
					scale = (Convert.ToDecimal(maxSize) / Convert.ToDecimal(y));
					y = maxSize;
					x = Convert.ToInt32(Convert.ToDecimal(x) * scale);
				}
			}
			Bitmap resizedImage = ResizeImage(outBmp, x, y);
			if(File.Exists(outputImage))
			{
				File.Delete(outputImage);
			}
			resizedImage.Save(outputImage);

			ReadImageText rit = new ReadImageText();
			string message = rit.Read(outputImage);
			using(StreamWriter writer = new StreamWriter(@"D:\GTS\json\images\textOutput.txt"))
			{
				writer.WriteLine(message);
			}
			MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public Bitmap ResizeImage(Image image, int width, int height)
		{
			var destRect = new Rectangle(0, 0, width, height);
			var destImage = new Bitmap(width, height);

			destImage.SetResolution(96, 96);

			using (var graphics = Graphics.FromImage(destImage))
			{
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

				using (var wrapMode = new ImageAttributes())
				{
					wrapMode.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
				}
			}

			return destImage;
		}
	}
}
