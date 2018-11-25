using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hospital.Models;

namespace hospital.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "welcome in our hospital";
        }

        public string About()
        {
          
            return "hospital management system  ";
        }

       
    }
}
