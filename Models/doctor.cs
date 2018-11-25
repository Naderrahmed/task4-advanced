using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.Models
{
    public class doctor
    {
        public int D_id { get; set; }
        public string d_name { get; set; }
        public int phone { get; set; }
        public decimal salary { get; set; }
        public bill _bill { get; set; }
        public List<patiant> _patiants { get; set; } 
    }
}
