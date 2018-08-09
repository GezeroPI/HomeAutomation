using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HomeAutomations.Controllers
{
    [Route("api/[controller]")]
    public class DayStatsController : Controller
    {
        // GET api/DayStats
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }
    }
}