using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandAndFoot.Classes;
using Microsoft.AspNetCore.Mvc;
using HandAndFoot.Data;
using System.IO;
using Microsoft.EntityFrameworkCore;

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
            void MakeNewGameTable()
            {
                //create a new GameTable
                var gameTable = new Classes.GameTable
                {
                    Players = new List<Player>(),
                    DiscardPile = new DiscardPile(new List<Card>()),
                    GameDeck = new GameDeck()
                };
                gameTable.GameID = gameTable.MakeNewGameId();
                //make a new Class.Player to handle to Model.Player info
                Player player = new Player
                {
                    Name = _user,
                    Hand = new Hand(new List<Card>()),
                    Foot = new Hand(new List<Card>()),
                    GameID = gameTable.GameID,
                    LayOnTable = new List<Book>()
                };
                //string GTdeck = gameTable.GameDeck.SerializeDeck();
                var User = _context.Players.Where(p => p.Name == _user).Select(u => u).FirstOrDefault();
                


                //send the gameTable data to the db


                //add the user as Player to gametable
                //gameTable.Players.Add(player);
            }
            MakeNewGameTable();


            return RedirectToAction("PlayGame");
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
            return View();
        }
        //Bring in a gameTable, display GameTable, check for number of players, run game
        public IActionResult PlayGame(GameTable G)
        {
            return View(G);
        }
    }
}