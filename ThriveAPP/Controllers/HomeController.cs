using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ThriveAPP.Contracts;
using ThriveAPP.Models;

namespace ThriveAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailServices _emailService;
        private readonly IMessengerServices _messengerService;
        private readonly ISchoolServices _schoolService;

        public HomeController(ILogger<HomeController> logger, IEmailServices emailServices, IMessengerServices messengerServices, ISchoolServices schoolServices )
        {
            _logger = logger;
            _emailService = emailServices;
            _messengerService = messengerServices;
            _schoolService = schoolServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ScanSystem()
        {
            var students = _schoolService.


            return View(nameof(Index));
        }

        public IActionResult Privacy()
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
