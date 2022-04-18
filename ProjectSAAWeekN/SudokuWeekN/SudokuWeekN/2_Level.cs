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
    public partial class FormLevel : Form
    {
        public FormLevel()
        {
            InitializeComponent();
        }

        public static int level = 0;

        public void pictureBoxEasy_Click(object sender, EventArgs e)
        {
            level = 30;
            FormGame Game = new FormGame();
            Game.Show();
            this.Hide();
        }

        public void pictureBoxMedium_Click(object sender, EventArgs e)
        {
            level = 38;
            FormGame Game = new FormGame();
            Game.Show();
            this.Hide();
        }

        public void pictureBoxHard_Click(object sender, EventArgs e)
        {
            level = 45;
            FormGame Game = new FormGame();
            Game.Show();
            this.Hide();
        }

        private void pictureBoxRules_Click(object sender, EventArgs e)
        {
            FormRules rules = new FormRules();
            rules.Show();
            this.Hide();
        }

        private void FormLevel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxLevel_Click(object sender, EventArgs e)
        {

        }
    }
}
