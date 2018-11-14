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
        public HomeController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Player(string _user)
        {
            var _hand = new List<Card>();
            var _foot = new List<Card>();
            var Player = new Player(_hand, _foot, _user);

            //grabs username from page, creates player, sends player object to game create page
            return RedirectToAction("Index", "GameTable", Player);//create game or join game page, send the player object
        }
    }
}