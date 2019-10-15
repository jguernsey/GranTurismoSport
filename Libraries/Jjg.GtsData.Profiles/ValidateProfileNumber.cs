using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;
using System;

namespace Jjg.GtsData.Profiles
{
    public class ValidateProfileNumber
    {
        public long Validate(long profileNumber, long increment)
        {
            EventWriter logger = new EventWriter();
            bool writer = true;
            long valid = profileNumber;
            try
            {
                do
                {
                    writer = new CheckProfileNumber().Check(profileNumber);
                    logger.Write(string.Format("Number: {0} - Valid: {1}", profileNumber, writer.ToString()));
                    if (!writer)
                    {
                        break;
                    }
                    valid = profileNumber;
                    profileNumber += increment;
                }
                while (writer);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return valid;
        }
    }
}
