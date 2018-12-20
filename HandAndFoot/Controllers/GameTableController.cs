﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandAndFoot.Classes;
using Microsoft.AspNetCore.Mvc;
using HandAndFoot.Data;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HandAndFoot.Controllers
{
    public class GameTableController : Controller
    {
        private readonly HandAndFootDbContext _context;
        public GameTableController(HandAndFootDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string _user)
        {
            int uId = Convert.ToInt32(_user);
            var user = _context.Players.Where(u => u.ID == uId).Select(n => n.Name).FirstOrDefault();
            TempData["userName"] = user;
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateGame(string _user)
        {
            int uId = Convert.ToInt32(_user);
            string GameID = "";
            MakeNewGameTable();


            void MakeNewGameTable()
            {
                //create a new serializer
                Serializer ser = new Serializer();
                //create a new GameTable and gameId
                var gameTable = new Classes.GameTable();
                gameTable.GameID = gameTable.MakeNewGameId();


                var MgameTable = new Models.GameTable()
                {
                    DiscardPile = ser.SerializeDiscard(new DiscardPile(new List<Card>())),
                    GameDeck = ser.SerializeDeck(new GameDeck()),
                    GameTableID = gameTable.GameID,
                    PlayersList = ""
                };
                
                //add the user as Player to gametable
                var User = _context.Players.Where(p => p.ID == uId).Select(u => u).FirstOrDefault().ToString();
                MgameTable.PlayersList = User;


                //send the gameTable data to the db
                _context.GameTables.Add(MgameTable);
                _context.SaveChanges();
                GameID = MgameTable.GameTableID;
            }

            return View("PlayGame");
            //return RedirectToAction("PlayGame", new { GameID });
        }

        public IActionResult AccessGame(string _user, string _gameID)
        {
            var player = new Player();
            player.Name = _user;
            player.GameID = _gameID;
            player.Hand = new Hand(new List<Card>());
            player.Foot = new Hand(new List<Card>());
            //check for a gameID in player, connect to game
            // if player.gameID is NULL, return error
            return View("PlayGame");
        }
        //Bring in a gameTable, display GameTable, check for number of players, run game
        public IActionResult PlayGame(string GameID)
        {
            var Game = _context.GameTables.Where(g => g.GameTableID == GameID).Select(t => t).FirstOrDefault();
            //make a new class GameTable
            GameTable gameTable = new GameTable();
            gameTable.GameDeck = JsonConvert.DeserializeObject<GameDeck>(Game.GameDeck);
            gameTable.DiscardPile = JsonConvert.DeserializeObject<DiscardPile>(Game.DiscardPile);

            return View("PlayGame");
        }
    }
}