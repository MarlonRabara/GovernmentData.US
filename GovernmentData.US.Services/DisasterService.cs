using GovernmentData.US.Models;
using GovernmentData.US.Models.FEMA;
using GovernmentData.US.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovernmentData.US.Services
{
    public class DisasterService : IDisasterService
    {
        internal DisasterService() { }


        public List<Disaster> GetDisasters(DateTime fromDate, DateTime toDate, string propertyState)
        {
            using var govApiWrapper = new GovApiWrapper("https://www.fema.gov/api/open/");

            var femaDisasterResultRoot = govApiWrapper.GetAsync<Root>("v2/DisasterDeclarationsSummaries?$filter=declarationDate%20ge%20%272010-01-01T04:00:00.000z%27%20and%20state%20eq%20%27VA%27").Result;

            return null; // todo
        }
    }
}
