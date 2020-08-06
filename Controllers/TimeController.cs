using Microsoft.AspNetCore.Mvc;
using System;

namespace TimeDisplay
{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime currenttime = DateTime.Now;
            System.Console.WriteLine(currenttime);
            ViewBag.Time = currenttime.ToString("h:mm tt");
            ViewBag.Date = currenttime.ToString("MMM d, yyyy");
            return View("Index");
        }
    }
}