using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HangmanLogic;
using HangmanData;

namespace Hangman
{
    public partial class Main : Form
    {
        static string picPath = ConfigurationManager.AppSettings.Get("PicPath");

        Controller controller = Controller.GetInstance();
        public Main()
        {
            InitializeComponent();
            FillBoxes();
           
        }

        private void FillBoxes()
        {
            FillPictureBox();
            FillPlayers();
            FillDifficulties();
        }

        private void FillPictureBox()
        {
            pbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMenu.Image = Image.FromFile(picPath + "hangman10.jpg");
        }

        private void FillPlayers()
        {
            cbPlayer.DataSource = controller.GetPlayerList();
        }
        private void FillDifficulties()
        {
            cbDifficulty.DataSource = new List<string>() { "Easy", "Normal", "Hard" };
        }

        /// <summary>
        /// Play a game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            var player = cbPlayer.SelectedItem as Player;
            var diff = cbDifficulty.SelectedItem.ToString().Substring(0, 1).ToUpper();
            FormGame.FormGame formGame = new FormGame.FormGame(Show, player, diff, picPath);
            formGame.Show();
            Hide();
        }

        /// <summary>
        /// Add Players or words
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddClick(object sender, EventArgs e)
        {
            FormAdd.FormAdd formAdd = new FormAdd.FormAdd(Show, FillPlayers);
            formAdd.Show();
            Hide();
        }

        /// <summary>
        /// Shows Highscores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            FormScore.FormScore formScore = new FormScore.FormScore(Show);
            formScore.Show();
            Hide();
        }
    }
}
