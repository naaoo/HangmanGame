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

        Controller controller = Controller.GetInstance();
        List<Game> filteredGames;

        public FormScore()
        {
            InitializeComponent();
        }

        public FormScore(Action action)
        {
            InitializeComponent();
            showParentForm = action;
            cbOrder.DataSource = new List<string>() { "mistakes", "duration" };
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
            filteredGames = controller.GetFilteredGames(cbOrder.Text);
            DataTable games = new DataTable("Best Games");
            games.Columns.Add(new DataColumn("Player"));
            games.Columns.Add(new DataColumn("Mistakes"));
            games.Columns.Add(new DataColumn("Duration"));
            games.Columns.Add(new DataColumn("Date"));
            foreach (var game in filteredGames)
            {
                DataRow row = games.NewRow();
                row["Best Games"] = Controller.entities.Where
            }


            List<object> displayList = controller.GetDisplayList(filteredGames);
            dgvGames.DataSource = displayList;
        }


    }
}
