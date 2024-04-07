using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovernmentData.US.Models.FEMA
{
    public class Root
    {
        public Metadata metadata { get; set; }
        public List<DisasterDeclarationsSummary> DisasterDeclarationsSummaries { get; set; }
    }
}
