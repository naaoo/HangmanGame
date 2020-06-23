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

namespace FormAdd
{
    public partial class FormAdd : Form
    {
        Controller controller = Controller.GetInstance();
        Action showParentForm;
        public FormAdd(Action action)
        {
            InitializeComponent();
            showParentForm = action;
        }

        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var name = tbPlayer.Text;
            bool success = controller.AddPlayer(name);
            TestSuccess(success);
            tbPlayer.Text = "";
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            var word = tbWord.Text;
            bool success = controller.AddWord(word);
            TestSuccess(success);
            tbWord.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            showParentForm.Invoke();
            Close();
        }

        private void TestSuccess(bool success)
        {
            if (success)
            {
                MessageBox.Show("Added successfully");
            }
            else
            {
                MessageBox.Show("Sorry, something went wrong");
            }
        }
    }
}
