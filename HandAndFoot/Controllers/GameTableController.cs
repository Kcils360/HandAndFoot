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
            return View(player);
        }

        public IActionResult CreateGame(Player player)
        {
            //create a new GameTable
            GameTable gameTable = new GameTable(new GameDeck(), new DiscardPile(new List<Card>()));
            var GID = gameTable.MakeNewGameId();
            //set the new gameID to the player.gameID
            player.GameID = GID;
            //add the user as Player to gametable
            gameTable.Players.Add(player);

            return RedirectToAction("PlayGame");
        }

        public IActionResult AccessGame(Player player)
        {
            //check for a gameID in player, connect to game
            // if player.gameID is NULL, return error
            return View();
        }
        //Bring in a gameTable, display GameTable, check for number of players, run game
        public IActionResult PlayGame(GameTable gameTable )
        {
            return View(gameTable);
        }
    }
}