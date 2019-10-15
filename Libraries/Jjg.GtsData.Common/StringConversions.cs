using System;

namespace Jjg.GtsData.Common
{
	public static class StringConversions
	{
        public static double SafeToDouble(this object inobj)
        {
            double outval = 0;
            try
            {
                if (inobj != null && !double.TryParse(inobj.ToString(), out outval))
                {
                    outval = 0;
                }
            }
            catch
            {
                outval = 0;
            }
            return outval;
        }

        public static long SafeToInt(this object inObj)
        {
            long outVal = 0;
            try
            {
                if (inObj == null)
                {
                    outVal = 0;
                }
                else
                {
                    long.TryParse(inObj.ToString(), out outVal);
                }
            }
            catch
            {
                outVal = 0;
            }
            return outVal;
        }

        public static string SafeToString(this object inObj)
        {
            string outVal = string.Empty;
            try
            {
                outVal = inObj == null ? string.Empty : inObj.ToString();
            }
            catch
            {
                outVal = string.Empty;
            }
            return outVal;
        }
    }
}
