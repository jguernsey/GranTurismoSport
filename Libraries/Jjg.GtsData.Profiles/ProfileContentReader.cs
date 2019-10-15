using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.StatsData;
using System;

namespace Jjg.GtsData.Profiles
{
    public class ProfileContentReader
    {
        public void Read(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                try
                {
                    UserProfile profile = new ToProfile().Convert(content);
                    new InsertPlayerProfile().Insert(profile.Profile);
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
            }
        }
    }
}
