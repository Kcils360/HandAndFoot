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
        public GameTable gameTable = new GameTable(new GameDeck(), new DiscardPile(new List<Card>()));
        public GameTableController(HandAndFootDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string _user)
        {
            string user = _user;
            return View();
        }
        [HttpPost]
        public IActionResult CreateGame(string _user)
        {
            void MakeNewGameTable()
            {
                //create a new GameTable
                //GameTable gameTable = new GameTable(new GameDeck(), new DiscardPile(new List<Card>()));
                gameTable.Players = new List<Player>();
                gameTable.GameID = gameTable.MakeNewGameId();
                string GT = gameTable.GameDeck.SerializeDeck();
                //create new player and add player data
                var player = new Player();
                //set the new gameID to the player.gameID
                player.Name = _user;
                player.GameID = gameTable.GameID;
                player.Hand = new Hand(new List<Card>());
                player.Foot = new Hand(new List<Card>());
                player.LayOnTable = new List<Book>();
                string plaYA = player.SerializePlayer();
                //send the gameTable data to the db
                

                //add the user as Player to gametable
                gameTable.Players.Add(player);
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
            G = gameTable;
            return View(G);
        }
    }
}