using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGame
{
    public partial class FormGame : Form
    {
        Action showParentForm;
        public FormGame(Action action)
        {
            InitializeComponent();
            showParentForm = action;
        }

        public FormGame()
        {
            InitializeComponent();
        }
    }
}
