using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandAndFoot.Classes;
using Microsoft.AspNetCore.Mvc;

namespace HandAndFoot.Controllers
{
    public class GameTableController : Controller
    {
        public IActionResult Index(Player player)
        {
            return View();
        }

        public IActionResult CreateGame()
        {
            return View();
        }
    }
}