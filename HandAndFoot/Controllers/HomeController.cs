﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandAndFoot.Classes;
using HandAndFoot.Data;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public IActionResult Player(string _user)
        {
            //TODO
            //add a check db for name already exists
            var t = (_context.Players.Where(n => n.Name.Contains(_user)).Select(u => u.ID).FirstOrDefault().ToString());
            if ( t != "0" )
            {
                //if exists grab ID and move on
                _user = t;
            }
            else
            {
                CreatePlayer(_user);
                _user = (_context.Players.Where(n => n.Name.Contains(_user)).Select(u => u.ID).FirstOrDefault().ToString());
            }

            return RedirectToAction("Index", "GameTable", new { _user });//create game or join game page, send the userId
        }        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async void CreatePlayer(string _user)
        {
            //e create a serializers
            var ser = new Serializer();
            //create a model player
            var plaYA = new Models.Player();
            plaYA.Name = _user;
            plaYA.Hand = ser.SerializeHand(new Hand(new List<Card>()));
            plaYA.Foot = ser.SerializeHand(new Hand(new List<Card>()));
            plaYA.Books = ser.SerialzeBook(new Book(new List<Card>()));
            //send this player to the Players table pass on userId
            _context.Players.Add(plaYA);
            await _context.SaveChangesAsync();
        }
    }
}