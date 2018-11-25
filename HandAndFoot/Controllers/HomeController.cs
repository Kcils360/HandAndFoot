using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandAndFoot.Classes;
using HandAndFoot.Models;
using HandAndFoot.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HandAndFoot.Controllers
{
    public class HomeController : Controller
    {
        private readonly HandAndFootDbContext _context;
        public HomeController(HandAndFootDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Player(string _user)
        {            
            var Player = new Classes.Player();
            Player.Hand = new Hand(new List<Card>());
            Player.Foot = new Hand(new List<Card>());

            var plaYA = new Models.Player();
            plaYA.Name = _user;
            plaYA.Hand = Player.Hand.SerializeHand();
            plaYA.Foot = Player.Foot.SerializeHand();
            plaYA.Books = "";
            //send this player to the Players table pass on username
            _context.Players.Add(plaYA);
            _context.SaveChanges();

            return RedirectToAction("Index", "GameTable", _user);//create game or join game page, send the player object
        }

        //---------------Helper Methods----------------------

        public string Serialize(object s)
        {
            string name = JsonConvert.SerializeObject(s);            
            return name;
        }
    }
}