using HangmanData;
using HangmanLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGame
{
    public partial class FormGame : Form
    {
        Action showParentForm;

        GameController gameController = null;
        string picPath;
        List<char> enteredChars = new List<char>();

        public FormGame()
        {
            InitializeComponent();
        }

        public FormGame(Action action, Player player, string diff, string picPath)
        {
            this.picPath = picPath;
            gameController = new GameController(player, diff);
            gameController.GetActions(UpdateFields, EndGame);
            InitializeComponent();
            showParentForm = action;
            UpdateFields(gameController.displayWord, gameController.mistakes);

        }

        private void UpdateFields(string word, int mistakes)
        {
            ChangeTries(mistakes);
            ChangePic(mistakes);
            ChangeWord(word);
            ChangeEntered();
        }

        private void ChangePic(int mistakes)
        {
            pbHangman.Image = Image.FromFile(picPath + "hangman" + mistakes + ".jpg");
        }

        private void ChangeTries(int mistakes)
        {
            lblTries.Text = (10 - mistakes).ToString();
        }

        private void ChangeEntered()
        {
            string entered = "";
            for (int i = 0; i < enteredChars.Count; i++)
            {
                if (i == 10 || i == 20)
                {
                    entered += "\n";
                }
                entered += enteredChars[i] + " ";
            }
            lblAlready.Text = entered;
        }

        private void ChangeWord(string word)
        {
            lblWord.Text = word;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            EnterLetter();
        }

        private void tbLetter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterLetter();
            }
        }

        public void EndGame(bool won, Game game)
        {
            if (won)
            {
                MessageBox.Show("Congratulations!\nTime: " + game.duration + "\nMistakes: " + game.mistakes);
            }
            else
            {
                MessageBox.Show("Game over!\nTime: " + game.duration + "s\nMistakes: " + game.mistakes);
            }
            showParentForm.Invoke();
            Close();
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Too bad...");
            showParentForm.Invoke();
            Close();
        }

        private void EnterLetter()
        {
            char enteredChar = tbLetter.Text.ToLower().ToCharArray()[0];
            try
            {
                if (!Regex.IsMatch(enteredChar.ToString(), @"[a-zäöü]"))
                {
                    throw new NoLetterException("not a letter");
                }
                else
                {
                    enteredChars.Add(enteredChar);
                    gameController.CheckLetter(enteredChar);
                    tbLetter.Text = null;
                }
            }
            catch (NoLetterException ex)
            {
                MessageBox.Show("Please enter a letter");
                tbLetter.Text = null;
            }
            
        }
    }
}
