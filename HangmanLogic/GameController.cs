using HangmanData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HangmanLogic
{
    public class GameController
    {
        HangmanEntities entities = new HangmanEntities();
        Action<string, int> updateForm;
        Action<bool, Game> endGame;
        Player player;
        string diff;
        Word word;
        public string displayWord;
        bool won = false;
        public int mistakes = 0;
        Stopwatch time = new Stopwatch();

        public GameController(Player player, string diff)
        {
            this.player = player;
            this.diff = diff;
            word = GetWord(diff);
            displayWord = CreateDisplayWord(word);
            time.Start();
        }

        public void GetActions(Action<string, int> updateForm, Action<bool, Game> endGame)
        {
            this.updateForm = updateForm;
            this.endGame = endGame;
        }

        private Word GetWord(string diff)
        {
            var list = entities.Word.Where(x => x.difficulty == diff).ToList();
            Random random = new Random();
            var index = random.Next(0, list.Count);
            return list[index];
        }

        private string CreateDisplayWord(Word word)
        {
            var disp = word.text.Substring(0, 1);
            var charArr = word.text.ToCharArray();
            for (int i = 1; i < charArr.Length; i++)
            {
                disp = disp + "_ ";
            }
            displayWord = disp;
            return disp;
        }

        public void CheckLetter(char enteredChar)
        {
            bool correct = false;
            foreach (var letter in word.text.ToCharArray())
            {
                if (letter == enteredChar)
                {
                    correct = true;
                    UpdateDisplayWord(enteredChar);
                }
            }
            if (!correct)
            {
                mistakes++;
            }
            updateForm.Invoke(displayWord, mistakes);
            if (CheckWin() || CheckLoss())
            {
                EndProcess();
            }
        }

        public void UpdateDisplayWord(char enteredChar)
        {
            var originalArr = word.text.ToCharArray();
            var displayArr = displayWord.Replace(" ", "").ToCharArray();
            for (int i = 0; i < originalArr.Length; i++)
            {
                if (originalArr[i] == enteredChar && displayArr[i] == '_')
                {
                    displayArr[i] = enteredChar;
                }
            }
            var newDisplay = "";
            foreach (var letter in displayArr)
            {
                if (letter == '_')
                {
                    newDisplay = newDisplay + "_ ";
                }
                else
                {
                    newDisplay = newDisplay + letter;
                }
            }
            displayWord = newDisplay;
        }

        private bool CheckWin()
        {
            bool win = true;
            var displayArr = displayWord.Replace(" ", "").ToCharArray();
            foreach (var letter in displayArr)
            {
                if (letter == '_')
                {
                    win = false;
                }
            }
            if (win)
            {
                won = true;
            }
            return win;
        }

        private bool CheckLoss()
        {
            if (mistakes == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EndProcess()
        {
            time.Stop();
            Game game = new Game()
            {
                player_id = player.id,
                difficulty = diff,
                mistakes = this.mistakes,
                won = this.won,
                date = DateTime.Now,
                duration = (int)Math.Round(time.Elapsed.TotalSeconds + 0.5)
            };
            entities.Game.Add(game);
            entities.SaveChanges();
            endGame.Invoke(won, game);
        }




    }
}
