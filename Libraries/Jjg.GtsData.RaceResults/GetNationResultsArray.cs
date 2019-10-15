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
    public class GetNationResultsArray
    {
        public NationResultsArray Get(string content)
        {
            NationResultsArray nra = null;
            try
            {
                nra = new ConvertToNationResults().Convert(content);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            if (nra.championship_nation_user.Length < 1)
            {
                nra = null;
            }
            return nra;
        }
    }
}
