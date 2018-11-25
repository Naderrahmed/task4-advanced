using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hospital.Controllers
{
    public class advController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}