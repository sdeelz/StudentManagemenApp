using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagemenApp.Controllers
{
    public class MarkController : Controller
    {
        public MarkController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
