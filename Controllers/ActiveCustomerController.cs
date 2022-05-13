using HisandHers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HisandHers.Controllers
{
    public class ActiveCustomerController : Controller
    {
        public IActionResult MakeAppointment()
        {
            return View();
        }

        public IActionResult ManageAppointment()
        {
            return View();
        }

        public IActionResult PastAppointment()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
