using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class RequestManufacturerResultsLoop
    {
        public void Request(string region, long seasonId, long manufacturerId)
        {
            bool isEmpty = false;
            long startNumber = 1;
            long endNumber = 1000;
            long interval = 1000;
            do
            {
                try
                {
                    GetManufacturersContent gmc = new GetManufacturersContent();
                    string content = gmc.Get(region, seasonId, startNumber, endNumber, manufacturerId);
                    if (string.IsNullOrEmpty(content))
                    {
                        isEmpty = true;
                        break;
                    }
                    else
                    {
                        ManufacturerResultsArray mra = new GetManufacturerResultsArray().Get(content);
                        if (mra == null)
                        {
                            isEmpty = true;
                            break;
                        }
                        else
                        {
                            ManufacturerResults[] championshipManufacturerUser = mra.championship_manufacturer_user;
                            for (int i = 0; i < championshipManufacturerUser.Length; i++)
                            {
                                ManufacturerResults mr = championshipManufacturerUser[i];
                                new ProcessManufacturerResults().Process(mr);
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
