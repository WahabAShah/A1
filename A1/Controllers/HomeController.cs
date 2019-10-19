using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using A1.Models;
using Microsoft.AspNetCore.Mvc;
//using A1.Models;

namespace A1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult EquipmentRequestForm()
        {
            return View();
        }


        public ViewResult AllEquipment()
        {
            return View(Repository.Tools);
        }

        public ViewResult AvailableEquipment()
        {
            return View(Repository.Tools.Where(r => r.Availbility == true));
        }


        [HttpPost]
        public IActionResult EquipmentRequestForm(ToolsRequest request)
        {
            if(ModelState.IsValid)
            {
                Repository.AddResponse(request);
                return View("ThankYouPage", request);
            }
            else
            {
                return View();
            }
        }

    }
}