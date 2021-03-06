﻿using HangmanData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanLogic
{
    public class Controller
    {
        /// <summary>
        /// entities containing words, players and games
        /// </summary>
        public static HangmanEntities entities = new HangmanEntities();

        /// <summary>
        /// singleton instance
        /// </summary>
        private static Controller instance = null;

        /// <summary>
        /// returns existing instance or creates new if none exists
        /// </summary>
        /// <returns></returns>
        public static Controller GetInstance()
        {
            if (instance == null)
            {
                instance = new Controller();
            }
            return instance;
        }

        /// <summary>
        /// returns a list of all players in alphabetical order
        /// </summary>
        /// <returns></returns>
        public List<Player> GetPlayerList()
        {
            return entities.Player.OrderBy(x => x.name).ToList();
        }

        /// <summary>
        /// adds a player to the database
        /// </summary>
        /// <param name="nameString"></param>
        /// <returns></returns>
        public bool AddPlayer(string nameString)
        {
            try
            {
                entities.Player.Add(new Player() { name = nameString });
                entities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddWord(string wordString)
        {
            var diff = "";
            if (wordString.Length < 10)
            {
                diff = "E";
            }
            else if (wordString.Length > 9 && wordString.Length < 15)
            {
                diff = "N";
            }
            else
            {
                diff = "H";
            }
            try
            {
                entities.Word.Add(new Word() { text = wordString, difficulty = diff });
                entities.SaveChanges();
                return true;
            } 
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Game> GetFilteredGames(string orderMode, string difficulty)
        {
            var list = new List<Game>();
            if (orderMode == "Mistakes")
            {
                list = entities.Game.Where(x => x.difficulty == difficulty.Substring(0, 1)).
                    Where(x => x.won == true).OrderBy(x => x.mistakes).Take(10).ToList();
            }
            else if (orderMode == "Duration")
            {
                list = entities.Game.Where(x => x.difficulty == difficulty.Substring(0, 1)).
                    Where(x => x.won == true).OrderBy(x => x.duration).Take(10).ToList();
            }
            return list;
        }

        public List<List<string>> GetDisplayList(List<Game> games)
        {
            List<List<string>> list = new List<List<string>>();
            foreach (var game in games)
            {
                Player player = entities.Player.Where(x => x.id == game.player_id).FirstOrDefault();
                string dateString = game.date.ToString("dd/MM/yyyy");
                list.Add(new List<string>() { player.name, game.mistakes.ToString(),
                    game.duration.ToString(), dateString});
            }
            return list;
        }
    }
}
