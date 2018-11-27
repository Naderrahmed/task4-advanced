using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.Models
{
    public class Room
    {
        public int r_id { get; set; }
        public string Type { get; set; }
        public int p_id { get; set; }
        public patiant _patiant { get; set; }
    }
}
