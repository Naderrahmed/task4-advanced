using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.Models
{
    public class patiant
    {
        public int p_id { get; set; }
        public string p_name { get; set; }
        public int age { get; set; }
        public int phone { get; set; }
        public bill _bill { get; set; }
        public List<doctor> _doctor { get; set; }
        public Room _room { get; set; }
    }
}
