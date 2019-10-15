using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class GetManufacturerResultsArray
    {
        public ManufacturerResultsArray Get(string content)
        {
            ManufacturerResultsArray mra = null;
            try
            {
                mra = new ConvertToManufacturerResults().Convert(content);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            if (mra.championship_manufacturer_user.Length < 1)
            {
                mra = null;
            }
            return mra;
        }
    }
}
