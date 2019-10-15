using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class RequestNationsResultsLoop
    {
        public void Request(string region, long seasonId)
        {
            bool isEmpty = false;
            long startNumber = 1;
            long endNumber = 1000;
            long interval = 1000;
            do
            {
                try
                {
                    string content = new GetNationsContent().Get(region, seasonId, startNumber, endNumber);
                    if (string.IsNullOrEmpty(content))
                    {
                        isEmpty = true;
                        break;
                    }
                    else
                    {
                        NationResultsArray results = new GetNationResultsArray().Get(content);
                        if (results == null)
                        {
                            isEmpty = true;
                            break;
                        }
                        else
                        {
                            NationResults[] championshipNationUser = results.championship_nation_user;
                            for (int i = 0; i < championshipNationUser.Length; i++)
                            {
                                NationResults nr = championshipNationUser[i];
                                new ProcessNationsResults().Process(nr);
                            }
                            startNumber += interval;
                            endNumber += interval;
                        }
                    }
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                    isEmpty = true;
                    break;
                }
            }
            while (!isEmpty);
        }
    }
}
