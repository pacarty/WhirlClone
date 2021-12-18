using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WhirlClone.Models;

namespace WhirlClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Desktops()
        {
            return View();
        }

        public IActionResult Monitors_GPUs()
        {
            return View();
        }

        public IActionResult Mobile_Carriers()
        {
            return View();
        }

        public IActionResult Wireless_ISPs()
        {
            return View();
        }

        public IActionResult DesktopThread1()
        {
            return View();
        }

        public IActionResult DesktopThread2()
        {
            return View();
        }

        public IActionResult Mobile_CarriersThread1()
        {
            return View();
        }

        public IActionResult Mobile_CarriersThread2()
        {
            return View();
        }

        public IActionResult Monitors_GPUsThread1()
        {
            return View();
        }

        public IActionResult Monitors_GPUsThread2()
        {
            return View();
        }

        public IActionResult Wireless_ISPsThread1()
        {
            return View();
        }

        public IActionResult Wireless_ISPsThread2()
        {
            return View();
        }

        public IActionResult PostMessage(Message message)
        {
            Console.WriteLine(message.Id);
            Console.WriteLine(message.Content);

            return RedirectToAction("DesktopThread1");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
