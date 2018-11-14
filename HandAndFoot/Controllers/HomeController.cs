using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandAndFoot.Classes;
using Microsoft.AspNetCore.Mvc;

namespace HandAndFoot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string user)
        {
            var Player = new Player(new List<Card>(), new List<Card>(), user);
            //grabs username from page, creates player, sends player object to game create page
            return RedirectToAction("Index", "GameTable", Player);//create game or join game page, send the player object
        }
    }
}