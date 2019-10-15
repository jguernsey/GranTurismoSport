using System;
using System.IO;
using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class ProcessSingleProfile
	{
		public Int64 Process(Int64 profileNumber)
		{
			Int64 profileCount = 0;
			bool isValid = true;

			do
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
									profileCount++;
								}
							}
						}
					}
					catch (Exception ex)
					{
						EventWriter writer = new EventWriter();
						writer.Write(ex.ToString());
						isValid = false;
						break;
					}
				}
				else
				{
					isValid = false;
					break;
				}
				profileNumber++;

			}while(isValid == true);
			return profileCount;
		}
	}
}
