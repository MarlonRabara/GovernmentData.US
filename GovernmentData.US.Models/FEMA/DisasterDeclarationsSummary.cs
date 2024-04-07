using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovernmentData.US.Models.FEMA
{
    public class DisasterDeclarationsSummary
    {
        public string femaDeclarationString { get; set; }
        public int disasterNumber { get; set; }
        public string state { get; set; }
        public string declarationType { get; set; }
        public DateTime declarationDate { get; set; }
        public int fyDeclared { get; set; }
        public string incidentType { get; set; }
        public string declarationTitle { get; set; }
        public bool ihProgramDeclared { get; set; }
        public bool iaProgramDeclared { get; set; }
        public bool paProgramDeclared { get; set; }
        public bool hmProgramDeclared { get; set; }
        public DateTime incidentBeginDate { get; set; }
        public DateTime? incidentEndDate { get; set; }
        public DateTime? disasterCloseoutDate { get; set; }
        public bool tribalRequest { get; set; }
        public string fipsStateCode { get; set; }
        public string fipsCountyCode { get; set; }
        public string placeCode { get; set; }
        public string designatedArea { get; set; }
        public string declarationRequestNumber { get; set; }
        public DateTime? lastIAFilingDate { get; set; }
        public DateTime lastRefresh { get; set; }
        public string hash { get; set; }
        public string id { get; set; }
    }
}
