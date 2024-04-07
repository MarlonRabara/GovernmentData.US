using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovernmentData.US.Models.FEMA
{
    public class Metadata
    {
        public int skip { get; set; }
        public string filter { get; set; }
        public string orderby { get; set; }
        public object select { get; set; }
        public DateTime rundate { get; set; }
        public int top { get; set; }
        public string format { get; set; }
        public bool metadata { get; set; }
        public string entityname { get; set; }
        public string version { get; set; }
        public string url { get; set; }
        public int count { get; set; }
    }
}
