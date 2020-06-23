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
        public FormScore()
        {
            InitializeComponent();
        }

        public FormScore(Action action)
        {
            InitializeComponent();
            showParentForm = action;
        }
    }
}
