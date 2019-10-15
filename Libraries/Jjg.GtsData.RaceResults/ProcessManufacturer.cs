using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class ProcessManufacturer
    {
        public void Process(string region, long seasonId, long manufacturer)
        {
            new RequestManufacturerResultsLoop().Request(region, seasonId, manufacturer);
        }
    }
}
