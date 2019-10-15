using System;
using System.Data;
using System.IO;
using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class OrphanGroupProcessor
	{
		public void Process(NumberGroup group)
		{
			foreach (DataRow dr in group.Numbers.Rows)
			{
				GetUserProfile getProfileData = new GetUserProfile();
				string content = getProfileData.Get(int.Parse(dr[1].ToString()));

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
