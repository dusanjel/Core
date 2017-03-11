using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Application.Interfaces;

namespace Core.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerAppService custService;

        public HomeController(ICustomerAppService custService)
        {
            this.custService = custService;
        }

        public IActionResult Customer()
        {
            var modelView = custService.getCustomer();
            return View(modelView);
        }

        public IActionResult Index()
        {
            return RedirectToAction("Customer");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
