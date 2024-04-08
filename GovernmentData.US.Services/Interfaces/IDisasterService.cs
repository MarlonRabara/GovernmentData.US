using GovernmentData.US.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovernmentData.US.Services.Interfaces
{
    public interface IDisasterService : IGovernmentService
    {
        List<Disaster> GetDisasters(DateTime fromDate, DateTime toDate, string propertyState);
    }
}
