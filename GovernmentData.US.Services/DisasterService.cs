using GovernmentData.US.Models;
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


        public List<Disaster> GetDisasters(DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }
    }
}
