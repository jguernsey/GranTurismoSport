using Jjg.GtsData.Common;
using Jjg.GtsData.Requester;

namespace Jjg.GtsData.Profiles
{
    public class ProfileGroupProcessor
    {
        public void Process(NumberGroup group)
        {
            for (int i = 0; i < group.Numbers.Rows.Count; i++)
            {
                long profileNumber = long.Parse(group.Numbers.Rows[i][0].ToString());
                if (profileNumber >= 1000000)
                {
                    string content = new GetUserProfile().Get(profileNumber);
                    new ProfileContentReader().Read(content);
                }
            }
        }
    }
}
