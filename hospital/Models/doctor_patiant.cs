using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.Models
{
    public class doctor_patiant
    {
        public int D_id { get; set; }
        public doctor _doctor { get; set; }
        public int p_id { get; set; }
        public patiant _patiant { get; set; }

      }
}