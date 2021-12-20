using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WhirlClone.Data;
using WhirlClone.Models;

namespace WhirlClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
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
            TopicDisplay topicDisplay = new TopicDisplay();

            // TODO: Change topicId == 1 to equal the id passed into this function as an argument
            // like in the Thread(int id) action.
            topicDisplay.Threads = _context.Threads.Where(x => x.TopicId == 1).ToList();

            return View(topicDisplay);
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

        public IActionResult DesktopThread1(int id)
        {
            ThreadDisplay threadDisplay = new ThreadDisplay();
            threadDisplay.NewMessage = new Message { ThreadId = id };
            threadDisplay.Messages = _context.Messages.Where(x => x.ThreadId == id).ToList();

            return View(threadDisplay);
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
            _context.Messages.Add(message);
            _context.SaveChanges();

            return RedirectToAction("DesktopThread1", new { id = message.ThreadId });
        }

        public IActionResult Thread(int id)
        {
            ThreadDisplay threadDisplay = new ThreadDisplay();

            threadDisplay.NewMessage = new Message { ThreadId = id };
            threadDisplay.Messages = _context.Messages.Where(x => x.ThreadId == id).ToList();  
            threadDisplay.Thread = _context.Threads.FirstOrDefault(x => x.Id == id);

            return View(threadDisplay);
        }

        public IActionResult CreateThread()
        {
            return View();
        }

        public IActionResult PostThread(Thread thread)
        {
            //TODO: Change so this isn't hardcoded. This is just a test value for now.
            thread.TopicId = 1;

            _context.Threads.Add(thread);
            _context.SaveChanges();

            return RedirectToAction("CreateThread");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
