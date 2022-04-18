using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuWeekN
{
    public partial class FormRules : Form
    {
        public FormRules()
        {
            InitializeComponent();
        }

        private void pictureBoxClose1_Click(object sender, EventArgs e)
        {
            FormLevel Level = new FormLevel();
            Level.Show();
            this.Hide();
        }

        private void FormRules_Load(object sender, EventArgs e)
        {

        }
    }
}
