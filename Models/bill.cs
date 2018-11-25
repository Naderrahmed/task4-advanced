using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.Models
{
    public class bill
    {
        public int b_id { get; set; }
        public string problem { get; set; }
        public DateTime Dateexamination { get; set; }
        public decimal d_Charges { get; set; }
        public decimal r_Charges { get; set; }
        public int D_id { get; set; }
        public List<doctor> _doctor { get ; set; }
        public int p_id { get; set; }
        public List<patiant> _patiant { get; set;}
    }
}
