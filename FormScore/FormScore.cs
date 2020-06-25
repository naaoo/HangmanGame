using HangmanData;
using HangmanLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormScore
{
    public partial class FormScore : Form
    {
        Action showParentForm;

        public Controller controller = Controller.GetInstance();
        List<Game> filteredGames;

        public FormScore()
        {
            InitializeComponent();
        }

        public FormScore(Action action)
        {
            InitializeComponent();
            showParentForm = action;
            cbOrder.DataSource = new List<string>() { "Mistakes", "Duration" };
            cbDifficulty.DataSource = new List<string>() { "Easy", "Normal", "Hard" };
            FillTable();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            showParentForm.Invoke();
            Hide();
        }

        private void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            filteredGames = controller.GetFilteredGames(cbOrder.Text, cbDifficulty.Text);
            List<List<string>> displayList = controller.GetDisplayList(filteredGames);
            DataTable games = new DataTable("Best Games");
            games.Columns.Add(new DataColumn("Player"));
            games.Columns.Add(new DataColumn("Mistakes"));
            games.Columns.Add(new DataColumn("Duration"));
            games.Columns.Add(new DataColumn("Date"));
            foreach (var game in displayList)
            {
                DataRow row = games.NewRow();
                row["Player"] = game[0];
                row["Mistakes"] = game[1];
                row["Duration"] = game[2];
                row["Date"] = game[3];
                games.Rows.Add(row);
            }
            dgvGames.DataSource = games;
        }

        private void cbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
