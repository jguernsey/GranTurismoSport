using System;
using System.Data;
using System.IO;
using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class ProfileGroupProcessor
	{
		public void Process(NumberGroup group)
		{
			foreach(DataRow dr in group.Numbers.Rows)
			{
				Int64 profileNumber = Int64.Parse(dr[0].ToString());
				if (profileNumber >= 1000000)
				{
					GetUserProfile getProfileData = new GetUserProfile();
					string content = getProfileData.Get(profileNumber);

					if (!string.IsNullOrEmpty(content))
					{
						try
						{
							using (StringReader reader = new StringReader(content))
							{
								string line = string.Empty;
								while ((line = reader.ReadLine()) != null)
								{
									if (!string.IsNullOrEmpty(line))
									{
										ConvertToProfile converter = new ConvertToProfile();
										UserProfile profile = converter.Convert(content);

										InsertPlayerProfile insertPlayer = new InsertPlayerProfile();
										insertPlayer.Insert(profile.Profile);
									}
								}
							}
						}
						catch (Exception ex)
						{
							EventWriter writer = new EventWriter();
							writer.Write(ex.ToString());
						}
					}
				}
			}
		}
	}
}
