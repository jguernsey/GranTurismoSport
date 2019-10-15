namespace Jjg.GtsData.Profiles
{
    public class GetEndPoint
    {
        public long Get(long profileNumber)
        {
            long lastProfileNumber = profileNumber;
            lastProfileNumber = new ValidateProfileNumber().Validate(profileNumber, 1000000);
            lastProfileNumber = new ValidateProfileNumber().Validate(profileNumber, 500000);
            lastProfileNumber = new ValidateProfileNumber().Validate(profileNumber, 100000);
            lastProfileNumber = new ValidateProfileNumber().Validate(lastProfileNumber, 10000);
            lastProfileNumber = new ValidateProfileNumber().Validate(lastProfileNumber, 1000);
            lastProfileNumber = new ValidateProfileNumber().Validate(lastProfileNumber, 100);
            lastProfileNumber = new ValidateProfileNumber().Validate(lastProfileNumber, 10);
            return new ValidateProfileNumber().Validate(lastProfileNumber, 1);
        }
    }
}
