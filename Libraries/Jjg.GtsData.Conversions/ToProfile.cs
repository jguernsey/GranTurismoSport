using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using Newtonsoft.Json;
using System;

namespace Jjg.GtsData.Conversions
{
    public class ToProfile
    {
        public UserProfile Convert(string content)
        {
            UserProfile up = new UserProfile();
            try
            {
                up = JsonConvert.DeserializeObject<UserProfile>(content);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return up;
        }
    }
}
