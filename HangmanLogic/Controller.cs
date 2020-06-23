using HangmanData;
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
            if (wordString.Length < 8)
            {
                diff = "E";
            }
            else if (wordString.Length > 7 && wordString.Length < 12)
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
    }
}
