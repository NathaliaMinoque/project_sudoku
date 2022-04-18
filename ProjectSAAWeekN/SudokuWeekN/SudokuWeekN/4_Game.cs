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
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        public TextBox[,] tbox = new TextBox[9, 9];
        public string[,] soal = new string[9, 9];
        public static int benar = 0;
        public static int salah = 0;
        public static int hint = 0;
        public static int score = 100;
        public static int giveup = 0;
        public int sumbux = 0;
        public int sumbuy = 0;


        private void FormGame_Load(object sender, EventArgs e)
        {
            score = 100;
            benar = 0;
            salah = 0;
            hint = 0;
            //LIVIA Code buat nentuin paket soal           
            Random random = new Random();
            int tempsoal = random.Next(1, 10);

            if (tempsoal == 1)
            {
                soal[0, 0] = "5";
                soal[0, 1] = "3";
                soal[0, 2] = "1";
                soal[0, 3] = "8";
                soal[0, 4] = "9";
                soal[0, 5] = "4";
                soal[0, 6] = "7";
                soal[0, 7] = "6";
                soal[0, 8] = "2";
                soal[1, 0] = "6";
                soal[1, 1] = "4";
                soal[1, 2] = "9";
                soal[1, 3] = "5";
                soal[1, 4] = "2";
                soal[1, 5] = "7";
                soal[1, 6] = "3";
                soal[1, 7] = "8";
                soal[1, 8] = "1";
                soal[2, 0] = "8";
                soal[2, 1] = "2";
                soal[2, 2] = "7";
                soal[2, 3] = "1";
                soal[2, 4] = "6";
                soal[2, 5] = "3";
                soal[2, 6] = "4";
                soal[2, 7] = "5";
                soal[2, 8] = "9";
                soal[3, 0] = "4";
                soal[3, 1] = "9";
                soal[3, 2] = "6";
                soal[3, 3] = "3";
                soal[3, 4] = "8";
                soal[3, 5] = "2";
                soal[3, 6] = "5";
                soal[3, 7] = "1";
                soal[3, 8] = "7";
                soal[4, 0] = "2";
                soal[4, 1] = "1";
                soal[4, 2] = "8";
                soal[4, 3] = "4";
                soal[4, 4] = "7";
                soal[4, 5] = "5";
                soal[4, 6] = "9";
                soal[4, 7] = "3";
                soal[4, 8] = "6";
                soal[5, 0] = "7";
                soal[5, 1] = "5";
                soal[5, 2] = "3";
                soal[5, 3] = "9";
                soal[5, 4] = "1";
                soal[5, 5] = "6";
                soal[5, 6] = "8";
                soal[5, 7] = "2";
                soal[5, 8] = "4";
                soal[6, 0] = "3";
                soal[6, 1] = "7";
                soal[6, 2] = "4";
                soal[6, 3] = "6";
                soal[6, 4] = "5";
                soal[6, 5] = "1";
                soal[6, 6] = "2";
                soal[6, 7] = "9";
                soal[6, 8] = "8";
                soal[7, 0] = "9";
                soal[7, 1] = "6";
                soal[7, 2] = "2";
                soal[7, 3] = "7";
                soal[7, 4] = "3";
                soal[7, 5] = "8";
                soal[7, 6] = "1";
                soal[7, 7] = "4";
                soal[7, 8] = "5";
                soal[8, 0] = "1";
                soal[8, 1] = "8";
                soal[8, 2] = "5";
                soal[8, 3] = "2";
                soal[8, 4] = "4";
                soal[8, 5] = "9";
                soal[8, 6] = "6";
                soal[8, 7] = "7";
                soal[8, 8] = "3";
            }

            else if (tempsoal == 2)
            {
                soal[0, 0] = "1";
                soal[0, 1] = "2";
                soal[0, 2] = "5";
                soal[0, 3] = "4";
                soal[0, 4] = "8";
                soal[0, 5] = "3";
                soal[0, 6] = "6";
                soal[0, 7] = "9";
                soal[0, 8] = "7";
                soal[1, 0] = "7";
                soal[1, 1] = "4";
                soal[1, 2] = "8";
                soal[1, 3] = "1";
                soal[1, 4] = "6";
                soal[1, 5] = "9";
                soal[1, 6] = "2";
                soal[1, 7] = "3";
                soal[1, 8] = "5";
                soal[2, 0] = "9";
                soal[2, 1] = "6";
                soal[2, 2] = "3";
                soal[2, 3] = "2";
                soal[2, 4] = "5";
                soal[2, 5] = "7";
                soal[2, 6] = "4";
                soal[2, 7] = "1";
                soal[2, 8] = "8";
                soal[3, 0] = "4";
                soal[3, 1] = "3";
                soal[3, 2] = "7";
                soal[3, 3] = "8";
                soal[3, 4] = "2";
                soal[3, 5] = "1";
                soal[3, 6] = "5";
                soal[3, 7] = "6";
                soal[3, 8] = "9";
                soal[4, 0] = "8";
                soal[4, 1] = "5";
                soal[4, 2] = "6";
                soal[4, 3] = "9";
                soal[4, 4] = "3";
                soal[4, 5] = "4";
                soal[4, 6] = "1";
                soal[4, 7] = "7";
                soal[4, 8] = "2";
                soal[5, 0] = "2";
                soal[5, 1] = "1";
                soal[5, 2] = "9";
                soal[5, 3] = "6";
                soal[5, 4] = "7";
                soal[5, 5] = "5";
                soal[5, 6] = "8";
                soal[5, 7] = "4";
                soal[5, 8] = "3";
                soal[6, 0] = "5";
                soal[6, 1] = "8";
                soal[6, 2] = "4";
                soal[6, 3] = "3";
                soal[6, 4] = "9";
                soal[6, 5] = "6";
                soal[6, 6] = "7";
                soal[6, 7] = "2";
                soal[6, 8] = "1";
                soal[7, 0] = "6";
                soal[7, 1] = "9";
                soal[7, 2] = "2";
                soal[7, 3] = "7";
                soal[7, 4] = "1";
                soal[7, 5] = "8";
                soal[7, 6] = "3";
                soal[7, 7] = "5";
                soal[7, 8] = "4";
                soal[8, 0] = "3";
                soal[8, 1] = "7";
                soal[8, 2] = "1";
                soal[8, 3] = "5";
                soal[8, 4] = "4";
                soal[8, 5] = "2";
                soal[8, 6] = "9";
                soal[8, 7] = "8";
                soal[8, 8] = "6";
            }

            else if (tempsoal == 3)
            {
                soal[0, 0] = "2";
                soal[0, 1] = "3";
                soal[0, 2] = "5";
                soal[0, 3] = "1";
                soal[0, 4] = "4";
                soal[0, 5] = "7";
                soal[0, 6] = "9";
                soal[0, 7] = "8";
                soal[0, 8] = "6";
                soal[1, 0] = "4";
                soal[1, 1] = "1";
                soal[1, 2] = "8";
                soal[1, 3] = "9";
                soal[1, 4] = "6";
                soal[1, 5] = "5";
                soal[1, 6] = "7";
                soal[1, 7] = "2";
                soal[1, 8] = "3";
                soal[2, 0] = "6";
                soal[2, 1] = "9";
                soal[2, 2] = "7";
                soal[2, 3] = "2";
                soal[2, 4] = "8";
                soal[2, 5] = "3";
                soal[2, 6] = "1";
                soal[2, 7] = "4";
                soal[2, 8] = "5";
                soal[3, 0] = "9";
                soal[3, 1] = "8";
                soal[3, 2] = "6";
                soal[3, 3] = "5";
                soal[3, 4] = "7";
                soal[3, 5] = "4";
                soal[3, 6] = "2";
                soal[3, 7] = "3";
                soal[3, 8] = "1";
                soal[4, 0] = "5";
                soal[4, 1] = "7";
                soal[4, 2] = "3";
                soal[4, 3] = "8";
                soal[4, 4] = "1";
                soal[4, 5] = "2";
                soal[4, 6] = "4";
                soal[4, 7] = "6";
                soal[4, 8] = "9";
                soal[5, 0] = "1";
                soal[5, 1] = "4";
                soal[5, 2] = "2";
                soal[5, 3] = "6";
                soal[5, 4] = "3";
                soal[5, 5] = "9";
                soal[5, 6] = "8";
                soal[5, 7] = "5";
                soal[5, 8] = "7";
                soal[6, 0] = "7";
                soal[6, 1] = "5";
                soal[6, 2] = "9";
                soal[6, 3] = "3";
                soal[6, 4] = "2";
                soal[6, 5] = "8";
                soal[6, 6] = "6";
                soal[6, 7] = "1";
                soal[6, 8] = "4";
                soal[7, 0] = "8";
                soal[7, 1] = "6";
                soal[7, 2] = "4";
                soal[7, 3] = "7";
                soal[7, 4] = "5";
                soal[7, 5] = "1";
                soal[7, 6] = "3";
                soal[7, 7] = "9";
                soal[7, 8] = "2";
                soal[8, 0] = "3";
                soal[8, 1] = "2";
                soal[8, 2] = "1";
                soal[8, 3] = "4";
                soal[8, 4] = "9";
                soal[8, 5] = "6";
                soal[8, 6] = "5";
                soal[8, 7] = "7";
                soal[8, 8] = "8";
            }

            else if (tempsoal == 4)
            {
                soal[0, 0] = "5";
                soal[0, 1] = "3";
                soal[0, 2] = "4";
                soal[0, 3] = "6";
                soal[0, 4] = "7";
                soal[0, 5] = "8";
                soal[0, 6] = "9";
                soal[0, 7] = "1";
                soal[0, 8] = "2";
                soal[1, 0] = "6";
                soal[1, 1] = "7";
                soal[1, 2] = "2";
                soal[1, 3] = "1";
                soal[1, 4] = "9";
                soal[1, 5] = "5";
                soal[1, 6] = "3";
                soal[1, 7] = "4";
                soal[1, 8] = "8";
                soal[2, 0] = "1";
                soal[2, 1] = "9";
                soal[2, 2] = "8";
                soal[2, 3] = "3";
                soal[2, 4] = "4";
                soal[2, 5] = "2";
                soal[2, 6] = "5";
                soal[2, 7] = "6";
                soal[2, 8] = "7";
                soal[3, 0] = "8";
                soal[3, 1] = "5";
                soal[3, 2] = "9";
                soal[3, 3] = "7";
                soal[3, 4] = "6";
                soal[3, 5] = "1";
                soal[3, 6] = "4";
                soal[3, 7] = "2";
                soal[3, 8] = "3";
                soal[4, 0] = "4";
                soal[4, 1] = "2";
                soal[4, 2] = "6";
                soal[4, 3] = "8";
                soal[4, 4] = "5";
                soal[4, 5] = "3";
                soal[4, 6] = "7";
                soal[4, 7] = "9";
                soal[4, 8] = "1";
                soal[5, 0] = "7";
                soal[5, 1] = "1";
                soal[5, 2] = "3";
                soal[5, 3] = "9";
                soal[5, 4] = "2";
                soal[5, 5] = "4";
                soal[5, 6] = "8";
                soal[5, 7] = "5";
                soal[5, 8] = "6";
                soal[6, 0] = "9";
                soal[6, 1] = "6";
                soal[6, 2] = "1";
                soal[6, 3] = "5";
                soal[6, 4] = "3";
                soal[6, 5] = "7";
                soal[6, 6] = "2";
                soal[6, 7] = "8";
                soal[6, 8] = "4";
                soal[7, 0] = "2";
                soal[7, 1] = "8";
                soal[7, 2] = "7";
                soal[7, 3] = "4";
                soal[7, 4] = "1";
                soal[7, 5] = "9";
                soal[7, 6] = "6";
                soal[7, 7] = "3";
                soal[7, 8] = "5";
                soal[8, 0] = "3";
                soal[8, 1] = "4";
                soal[8, 2] = "5";
                soal[8, 3] = "2";
                soal[8, 4] = "8";
                soal[8, 5] = "6";
                soal[8, 6] = "1";
                soal[8, 7] = "7";
                soal[8, 8] = "9";
            }

            else if (tempsoal == 5)
            {
                soal[0, 0] = "1";
                soal[0, 1] = "7";
                soal[0, 2] = "5";
                soal[0, 3] = "2";
                soal[0, 4] = "9";
                soal[0, 5] = "4";
                soal[0, 6] = "8";
                soal[0, 7] = "3";
                soal[0, 8] = "6";
                soal[1, 0] = "6";
                soal[1, 1] = "2";
                soal[1, 2] = "3";
                soal[1, 3] = "1";
                soal[1, 4] = "8";
                soal[1, 5] = "7";
                soal[1, 6] = "9";
                soal[1, 7] = "4";
                soal[1, 8] = "5";
                soal[2, 0] = "8";
                soal[2, 1] = "9";
                soal[2, 2] = "4";
                soal[2, 3] = "5";
                soal[2, 4] = "6";
                soal[2, 5] = "3";
                soal[2, 6] = "2";
                soal[2, 7] = "7";
                soal[2, 8] = "1";
                soal[3, 0] = "5";
                soal[3, 1] = "1";
                soal[3, 2] = "9";
                soal[3, 3] = "7";
                soal[3, 4] = "3";
                soal[3, 5] = "2";
                soal[3, 6] = "4";
                soal[3, 7] = "6";
                soal[3, 8] = "8";
                soal[4, 0] = "3";
                soal[4, 1] = "4";
                soal[4, 2] = "7";
                soal[4, 3] = "8";
                soal[4, 4] = "5";
                soal[4, 5] = "6";
                soal[4, 6] = "1";
                soal[4, 7] = "2";
                soal[4, 8] = "9";
                soal[5, 0] = "2";
                soal[5, 1] = "8";
                soal[5, 2] = "6";
                soal[5, 3] = "9";
                soal[5, 4] = "4";
                soal[5, 5] = "1";
                soal[5, 6] = "7";
                soal[5, 7] = "5";
                soal[5, 8] = "3";
                soal[6, 0] = "9";
                soal[6, 1] = "3";
                soal[6, 2] = "8";
                soal[6, 3] = "4";
                soal[6, 4] = "2";
                soal[6, 5] = "5";
                soal[6, 6] = "6";
                soal[6, 7] = "1";
                soal[6, 8] = "7";
                soal[7, 0] = "4";
                soal[7, 1] = "6";
                soal[7, 2] = "1";
                soal[7, 3] = "3";
                soal[7, 4] = "7";
                soal[7, 5] = "9";
                soal[7, 6] = "5";
                soal[7, 7] = "8";
                soal[7, 8] = "2";
                soal[8, 0] = "7";
                soal[8, 1] = "5";
                soal[8, 2] = "2";
                soal[8, 3] = "6";
                soal[8, 4] = "1";
                soal[8, 5] = "8";
                soal[8, 6] = "3";
                soal[8, 7] = "9";
                soal[8, 8] = "4";
            }

            else if (tempsoal == 6)
            {
                soal[0, 0] = "9";
                soal[0, 1] = "4";
                soal[0, 2] = "8";
                soal[0, 3] = "5";
                soal[0, 4] = "7";
                soal[0, 5] = "2";
                soal[0, 6] = "6";
                soal[0, 7] = "3";
                soal[0, 8] = "1";
                soal[1, 0] = "2";
                soal[1, 1] = "1";
                soal[1, 2] = "5";
                soal[1, 3] = "6";
                soal[1, 4] = "8";
                soal[1, 5] = "3";
                soal[1, 6] = "7";
                soal[1, 7] = "4";
                soal[1, 8] = "9";
                soal[2, 0] = "7";
                soal[2, 1] = "3";
                soal[2, 2] = "6";
                soal[2, 3] = "4";
                soal[2, 4] = "1";
                soal[2, 5] = "9";
                soal[2, 6] = "2";
                soal[2, 7] = "5";
                soal[2, 8] = "8";
                soal[3, 0] = "4";
                soal[3, 1] = "6";
                soal[3, 2] = "7";
                soal[3, 3] = "8";
                soal[3, 4] = "5";
                soal[3, 5] = "1";
                soal[3, 6] = "3";
                soal[3, 7] = "9";
                soal[3, 8] = "2";
                soal[4, 0] = "3";
                soal[4, 1] = "8";
                soal[4, 2] = "9";
                soal[4, 3] = "7";
                soal[4, 4] = "2";
                soal[4, 5] = "4";
                soal[4, 6] = "5";
                soal[4, 7] = "1";
                soal[4, 8] = "6";
                soal[5, 0] = "1";
                soal[5, 1] = "5";
                soal[5, 2] = "2";
                soal[5, 3] = "3";
                soal[5, 4] = "9";
                soal[5, 5] = "6";
                soal[5, 6] = "4";
                soal[5, 7] = "8";
                soal[5, 8] = "7";
                soal[6, 0] = "6";
                soal[6, 1] = "9";
                soal[6, 2] = "4";
                soal[6, 3] = "1";
                soal[6, 4] = "3";
                soal[6, 5] = "7";
                soal[6, 6] = "8";
                soal[6, 7] = "2";
                soal[6, 8] = "5";
                soal[7, 0] = "5";
                soal[7, 1] = "2";
                soal[7, 2] = "3";
                soal[7, 3] = "9";
                soal[7, 4] = "6";
                soal[7, 5] = "8";
                soal[7, 6] = "1";
                soal[7, 7] = "7";
                soal[7, 8] = "4";
                soal[8, 0] = "8";
                soal[8, 1] = "7";
                soal[8, 2] = "1";
                soal[8, 3] = "2";
                soal[8, 4] = "4";
                soal[8, 5] = "5";
                soal[8, 6] = "9";
                soal[8, 7] = "6";
                soal[8, 8] = "3";

            }

            else if (tempsoal == 7)
            {
                soal[0, 0] = "4";
                soal[0, 1] = "6";
                soal[0, 2] = "2";
                soal[0, 3] = "3";
                soal[0, 4] = "7";
                soal[0, 5] = "5";
                soal[0, 6] = "8";
                soal[0, 7] = "1";
                soal[0, 8] = "9";
                soal[1, 0] = "5";
                soal[1, 1] = "9";
                soal[1, 2] = "1";
                soal[1, 3] = "8";
                soal[1, 4] = "6";
                soal[1, 5] = "4";
                soal[1, 6] = "7";
                soal[1, 7] = "3";
                soal[1, 8] = "2";
                soal[2, 0] = "7";
                soal[2, 1] = "3";
                soal[2, 2] = "8";
                soal[2, 3] = "2";
                soal[2, 4] = "9";
                soal[2, 5] = "1";
                soal[2, 6] = "5";
                soal[2, 7] = "4";
                soal[2, 8] = "6";
                soal[3, 0] = "9";
                soal[3, 1] = "4";
                soal[3, 2] = "7";
                soal[3, 3] = "6";
                soal[3, 4] = "3";
                soal[3, 5] = "8";
                soal[3, 6] = "1";
                soal[3, 7] = "2";
                soal[3, 8] = "5";
                soal[4, 0] = "1";
                soal[4, 1] = "2";
                soal[4, 2] = "6";
                soal[4, 3] = "5";
                soal[4, 4] = "4";
                soal[4, 5] = "7";
                soal[4, 6] = "9";
                soal[4, 7] = "8";
                soal[4, 8] = "3";
                soal[5, 0] = "3";
                soal[5, 1] = "8";
                soal[5, 2] = "5";
                soal[5, 3] = "9";
                soal[5, 4] = "1";
                soal[5, 5] = "2";
                soal[5, 6] = "4";
                soal[5, 7] = "6";
                soal[5, 8] = "7";
                soal[6, 0] = "6";
                soal[6, 1] = "5";
                soal[6, 2] = "4";
                soal[6, 3] = "7";
                soal[6, 4] = "8";
                soal[6, 5] = "3";
                soal[6, 6] = "2";
                soal[6, 7] = "9";
                soal[6, 8] = "1";
                soal[7, 0] = "2";
                soal[7, 1] = "1";
                soal[7, 2] = "9";
                soal[7, 3] = "4";
                soal[7, 4] = "5";
                soal[7, 5] = "6";
                soal[7, 6] = "3";
                soal[7, 7] = "7";
                soal[7, 8] = "8";
                soal[8, 0] = "8";
                soal[8, 1] = "7";
                soal[8, 2] = "3";
                soal[8, 3] = "1";
                soal[8, 4] = "2";
                soal[8, 5] = "9";
                soal[8, 6] = "6";
                soal[8, 7] = "5";
                soal[8, 8] = "4";
            }

            else if (tempsoal == 8)
            {
                soal[0, 0] = "9";
                soal[0, 1] = "7";
                soal[0, 2] = "4";
                soal[0, 3] = "1";
                soal[0, 4] = "2";
                soal[0, 5] = "3";
                soal[0, 6] = "6";
                soal[0, 7] = "8";
                soal[0, 8] = "5";
                soal[1, 0] = "2";
                soal[1, 1] = "6";
                soal[1, 2] = "1";
                soal[1, 3] = "5";
                soal[1, 4] = "8";
                soal[1, 5] = "9";
                soal[1, 6] = "7";
                soal[1, 7] = "3";
                soal[1, 8] = "4";
                soal[2, 0] = "8";
                soal[2, 1] = "3";
                soal[2, 2] = "5";
                soal[2, 3] = "7";
                soal[2, 4] = "4";
                soal[2, 5] = "6";
                soal[2, 6] = "2";
                soal[2, 7] = "1";
                soal[2, 8] = "9";
                soal[3, 0] = "3";
                soal[3, 1] = "1";
                soal[3, 2] = "9";
                soal[3, 3] = "4";
                soal[3, 4] = "7";
                soal[3, 5] = "2";
                soal[3, 6] = "5";
                soal[3, 7] = "6";
                soal[3, 8] = "8";
                soal[4, 0] = "7";
                soal[4, 1] = "8";
                soal[4, 2] = "6";
                soal[4, 3] = "9";
                soal[4, 4] = "5";
                soal[4, 5] = "1";
                soal[4, 6] = "3";
                soal[4, 7] = "4";
                soal[4, 8] = "2";
                soal[5, 0] = "4";
                soal[5, 1] = "5";
                soal[5, 2] = "2";
                soal[5, 3] = "6";
                soal[5, 4] = "3";
                soal[5, 5] = "8";
                soal[5, 6] = "1";
                soal[5, 7] = "9";
                soal[5, 8] = "7";
                soal[6, 0] = "5";
                soal[6, 1] = "4";
                soal[6, 2] = "3";
                soal[6, 3] = "8";
                soal[6, 4] = "1";
                soal[6, 5] = "7";
                soal[6, 6] = "9";
                soal[6, 7] = "2";
                soal[6, 8] = "6";
                soal[7, 0] = "6";
                soal[7, 1] = "2";
                soal[7, 2] = "7";
                soal[7, 3] = "3";
                soal[7, 4] = "9";
                soal[7, 5] = "4";
                soal[7, 6] = "8";
                soal[7, 7] = "5";
                soal[7, 8] = "1";
                soal[8, 0] = "1";
                soal[8, 1] = "9";
                soal[8, 2] = "8";
                soal[8, 3] = "2";
                soal[8, 4] = "6";
                soal[8, 5] = "5";
                soal[8, 6] = "4";
                soal[8, 7] = "7";
                soal[8, 8] = "3";
            }

            else if (tempsoal == 9)
            {
                soal[0, 0] = "1";
                soal[0, 1] = "4";
                soal[0, 2] = "5";
                soal[0, 3] = "2";
                soal[0, 4] = "3";
                soal[0, 5] = "6";
                soal[0, 6] = "7";
                soal[0, 7] = "8";
                soal[0, 8] = "9";
                soal[1, 0] = "6";
                soal[1, 1] = "2";
                soal[1, 2] = "7";
                soal[1, 3] = "1";
                soal[1, 4] = "8";
                soal[1, 5] = "9";
                soal[1, 6] = "3";
                soal[1, 7] = "4";
                soal[1, 8] = "5";
                soal[2, 0] = "8";
                soal[2, 1] = "9";
                soal[2, 2] = "3";
                soal[2, 3] = "4";
                soal[2, 4] = "5";
                soal[2, 5] = "7";
                soal[2, 6] = "1";
                soal[2, 7] = "2";
                soal[2, 8] = "6";
                soal[3, 0] = "2";
                soal[3, 1] = "1";
                soal[3, 2] = "4";
                soal[3, 3] = "3";
                soal[3, 4] = "6";
                soal[3, 5] = "5";
                soal[3, 6] = "8";
                soal[3, 7] = "9";
                soal[3, 8] = "7";
                soal[4, 0] = "3";
                soal[4, 1] = "5";
                soal[4, 2] = "8";
                soal[4, 3] = "7";
                soal[4, 4] = "9";
                soal[4, 5] = "1";
                soal[4, 6] = "2";
                soal[4, 7] = "6";
                soal[4, 8] = "4";
                soal[5, 0] = "7";
                soal[5, 1] = "6";
                soal[5, 2] = "9";
                soal[5, 3] = "8";
                soal[5, 4] = "2";
                soal[5, 5] = "4";
                soal[5, 6] = "5";
                soal[5, 7] = "1";
                soal[5, 8] = "3";
                soal[6, 0] = "4";
                soal[6, 1] = "3";
                soal[6, 2] = "1";
                soal[6, 3] = "6";
                soal[6, 4] = "7";
                soal[6, 5] = "2";
                soal[6, 6] = "9";
                soal[6, 7] = "5";
                soal[6, 8] = "8";
                soal[7, 0] = "5";
                soal[7, 1] = "7";
                soal[7, 2] = "2";
                soal[7, 3] = "9";
                soal[7, 4] = "4";
                soal[7, 5] = "8";
                soal[7, 6] = "6";
                soal[7, 7] = "3";
                soal[7, 8] = "1";
                soal[8, 0] = "9";
                soal[8, 1] = "8";
                soal[8, 2] = "6";
                soal[8, 3] = "5";
                soal[8, 4] = "1";
                soal[8, 5] = "3";
                soal[8, 6] = "4";
                soal[8, 7] = "7";
                soal[8, 8] = "2";
            }

            else if (tempsoal == 10)
            {
                soal[0, 0] = "3";
                soal[0, 1] = "6";
                soal[0, 2] = "5";
                soal[0, 3] = "7";
                soal[0, 4] = "4";
                soal[0, 5] = "2";
                soal[0, 6] = "8";
                soal[0, 7] = "1";
                soal[0, 8] = "9";
                soal[1, 0] = "8";
                soal[1, 1] = "4";
                soal[1, 2] = "2";
                soal[1, 3] = "3";
                soal[1, 4] = "1";
                soal[1, 5] = "9";
                soal[1, 6] = "7";
                soal[1, 7] = "5";
                soal[1, 8] = "6";
                soal[2, 0] = "9";
                soal[2, 1] = "7";
                soal[2, 2] = "1";
                soal[2, 3] = "8";
                soal[2, 4] = "5";
                soal[2, 5] = "6";
                soal[2, 6] = "3";
                soal[2, 7] = "4";
                soal[2, 8] = "2";
                soal[3, 0] = "4";
                soal[3, 1] = "5";
                soal[3, 2] = "6";
                soal[3, 3] = "9";
                soal[3, 4] = "7";
                soal[3, 5] = "8";
                soal[3, 6] = "1";
                soal[3, 7] = "2";
                soal[3, 8] = "3";
                soal[4, 0] = "1";
                soal[4, 1] = "3";
                soal[4, 2] = "9";
                soal[4, 3] = "4";
                soal[4, 4] = "2";
                soal[4, 5] = "5";
                soal[4, 6] = "6";
                soal[4, 7] = "7";
                soal[4, 8] = "8";
                soal[5, 0] = "2";
                soal[5, 1] = "8";
                soal[5, 2] = "7";
                soal[5, 3] = "6";
                soal[5, 4] = "3";
                soal[5, 5] = "1";
                soal[5, 6] = "5";
                soal[5, 7] = "9";
                soal[5, 8] = "4";
                soal[6, 0] = "6";
                soal[6, 1] = "1";
                soal[6, 2] = "4";
                soal[6, 3] = "5";
                soal[6, 4] = "9";
                soal[6, 5] = "3";
                soal[6, 6] = "2";
                soal[6, 7] = "8";
                soal[6, 8] = "7";
                soal[7, 0] = "5";
                soal[7, 1] = "9";
                soal[7, 2] = "3";
                soal[7, 3] = "2";
                soal[7, 4] = "8";
                soal[7, 5] = "7";
                soal[7, 6] = "4";
                soal[7, 7] = "6";
                soal[7, 8] = "1";
                soal[8, 0] = "7";
                soal[8, 1] = "2";
                soal[8, 2] = "8";
                soal[8, 3] = "1";
                soal[8, 4] = "6";
                soal[8, 5] = "4";
                soal[8, 6] = "9";
                soal[8, 7] = "3";
                soal[8, 8] = "5";
            }

            //VANYA Ini codingan bikin textbox array   
            string nama;
            int counter = 0;
            
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    tbox[x, y] = new TextBox();
                    nama = Convert.ToString(x) + Convert.ToString(y);
                    tbox[x, y].Name = nama;
                    tbox[x, y].Location = new Point((x + 3) * 26, (y + 2) * 26);
                    tbox[x, y].Visible = true;
                    tbox[x, y].Size = new Size(20, 20);
                    tbox[x, y].MaxLength = 1;
                    tbox[x, y].TextAlign = HorizontalAlignment.Center;
                    this.Controls.Add(tbox[x, y]);
                    //ini code mewarnai textbox
                    if (x < 3 && y > 5 || x < 3 && y < 3 || x > 2 && x < 6 && y > 2 && y < 6 || x > 5 && y > 5 || x > 5 && y < 3)
                    {
                        tbox[x, y].BackColor = Color.SkyBlue;
                        tbox[x, y].ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        tbox[x, y].BackColor = Color.Orchid;
                        tbox[x, y].ForeColor = Color.DarkSlateGray;
                    }                  
                    tbox[x, y].KeyUp += new KeyEventHandler(textbox_KeyUp);
                    tbox[x, y].KeyPress += new KeyPressEventHandler(textbox_KeyPress);
                    tbox[x, y].Enter += new EventHandler(simpanposisiTboxHint_Enter);
                   
                }
            }

            // WEDHANA INI CODE BUAT LEVEL
            while (counter != FormLevel.level)
            {              
                counter = 0;
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        int randoms = random.Next(0, 2);
                        tbox[x, y].Tag = randoms;
                        
                        if (tbox[x, y].Tag.ToString() == "1")
                        {
                            tbox[x, y].Enabled = true;
                            counter++;
                            tbox[x, y].Text = "";
                        }
                        else
                        {
                            tbox[x, y].Enabled = false;
                            tbox[x, y].Text = soal[x, y];
                        }
                    }
                }
            }
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //INEZ ini code biar yg masuk angka doang
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }


        private void textbox_KeyUp(object sender, KeyEventArgs e)
        {
            score = 100;
            benar = 0;
            //hint = 0;
            //
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    //MINOQ INI CODE CEK WIN
                    if (tbox[x, y].Text == soal[x, y])
                    {
                        benar++;
                    }
                    //ini code mewarnai textbox ulang
                    if (x < 3 && y > 5 || x < 3 && y < 3 || x > 2 && x < 6 && y > 2 && y < 6 || x > 5 && y > 5 || x > 5 && y < 3)
                    {
                        tbox[x, y].BackColor = Color.SkyBlue;
                        tbox[x, y].ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        tbox[x, y].BackColor = Color.Orchid;
                        tbox[x, y].ForeColor = Color.DarkSlateGray;
                    }
                }
            }
            //INI CODE WIN
            if (benar == 81)
            {
                if (giveup == 1)
                {
                    score = score - salah - hint;
                }
                else if (giveup == 0)
                {
                    salah = 0;
                    for (int x = 0; x < 9; x++)
                    {
                        for (int y = 0; y < 9; y++)
                        {
                            if (tbox[x, y].Text != soal[x, y])
                            {
                                salah += 2;
                            }
                        }
                    }
                    score = score - salah - hint;
                }
                FormCongrats congrats = new FormCongrats();
                congrats.Show();             
                this.Hide();
            }
            else
            {
                //INI CODE NYARI SUMBU X DAN Y  YANG AKTIF
                var tboxbariskolom = sender as TextBox;
                int sumbux = Convert.ToInt32(Convert.ToString(tboxbariskolom.Name.Substring(0, 1)));
                int sumbuy = Convert.ToInt32(Convert.ToString(tboxbariskolom.Name.Substring(1, 1)));

                //INI CODE CEK SUMBU X
                for (int x = 0; x < 9; x++)
                {
                    if (sumbux != x)
                    {
                        if (tbox[sumbux, sumbuy].Text == tbox[x, sumbuy].Text && tbox[sumbux, sumbuy].Text != "")
                        {
                            tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                            tbox[x, sumbuy].BackColor = Color.LightPink;
                            tbox[sumbux, sumbuy].ForeColor = Color.Red;
                            tbox[x, sumbuy].ForeColor = Color.Red;
                        }
                    }
                }

                //INI CODE CEK SUMBU Y
                for (int y = 0; y < 9; y++)
                {
                    if (sumbuy != y)
                    {
                        if (tbox[sumbux, sumbuy].Text == tbox[sumbux, y].Text && tbox[sumbux, sumbuy].Text != "")
                        {
                            tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                            tbox[sumbux, y].BackColor = Color.LightPink;
                            tbox[sumbux, sumbuy].ForeColor = Color.Red;
                            tbox[sumbux, y].ForeColor = Color.Red;
                        }
                    }
                }

                //INI CODE CEK KOTAK
                //CEK KOTAK KIRI ATAS
                if (sumbux < 3 && sumbuy < 3)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            if (x != sumbux && y != sumbuy)
                            {
                                if (tbox[sumbux, sumbuy].Text == tbox[x, y].Text && tbox[sumbux, sumbuy].Text != "")
                                {
                                    tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                                    tbox[x, y].BackColor = Color.LightPink;
                                    tbox[sumbux, sumbuy].ForeColor = Color.Red;
                                    tbox[x, y].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

                //CEK KOTAK kiri tengah
                if (sumbux < 3 && sumbuy > 2 && sumbuy < 6)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 3; y < 6; y++)
                        {
                            if (x != sumbux && y != sumbuy)
                            {
                                if (tbox[sumbux, sumbuy].Text == tbox[x, y].Text && tbox[sumbux, sumbuy].Text != "")
                                {
                                    tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                                    tbox[x, y].BackColor = Color.LightPink;
                                    tbox[sumbux, sumbuy].ForeColor = Color.Red;
                                    tbox[x, y].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

                //CEK KOTAK kiri bawah
                if (sumbux < 3 && sumbuy > 5)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 6; y < 9; y++)
                        {
                            if (x != sumbux && y != sumbuy)
                            {
                                if (tbox[sumbux, sumbuy].Text == tbox[x, y].Text && tbox[sumbux, sumbuy].Text != "")
                                {
                                    tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                                    tbox[x, y].BackColor = Color.LightPink;
                                    tbox[sumbux, sumbuy].ForeColor = Color.Red;
                                    tbox[x, y].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

                //CEK KOTAK tengah atas
                if (sumbux > 2 && sumbux < 6 && sumbuy < 3)
                {
                    for (int x = 3; x < 6; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            if (x != sumbux && y != sumbuy)
                            {
                                if (tbox[sumbux, sumbuy].Text == tbox[x, y].Text && tbox[sumbux, sumbuy].Text != "")
                                {
                                    tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                                    tbox[x, y].BackColor = Color.LightPink;
                                    tbox[sumbux, sumbuy].ForeColor = Color.Red;
                                    tbox[x, y].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

                //CEK KOTAK tengah
                if (sumbux > 2 && sumbux < 6 && sumbuy > 2 && sumbuy < 6)
                {
                    for (int x = 3; x < 6; x++)
                    {
                        for (int y = 3; y < 6; y++)
                        {
                            if (x != sumbux && y != sumbuy)
                            {
                                if (tbox[sumbux, sumbuy].Text == tbox[x, y].Text && tbox[sumbux, sumbuy].Text != "")
                                {
                                    tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                                    tbox[x, y].BackColor = Color.LightPink;
                                    tbox[sumbux, sumbuy].ForeColor = Color.Red;
                                    tbox[x, y].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

                //CEK KOTAK tengah bawah
                if (sumbux > 2 && sumbux < 6 && sumbuy > 5)
                {
                    for (int x = 3; x < 6; x++)
                    {
                        for (int y = 6; y < 9; y++)
                        {
                            if (x != sumbux && y != sumbuy)
                            {
                                if (tbox[sumbux, sumbuy].Text == tbox[x, y].Text && tbox[sumbux, sumbuy].Text != "")
                                {
                                    tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                                    tbox[x, y].BackColor = Color.LightPink;
                                    tbox[sumbux, sumbuy].ForeColor = Color.Red;
                                    tbox[x, y].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

                //CEK KOTAK kanan atas
                if (sumbux > 5 && sumbuy < 3)
                {
                    for (int x = 6; x < 9; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            if (x != sumbux && y != sumbuy)
                            {
                                if (tbox[sumbux, sumbuy].Text == tbox[x, y].Text && tbox[sumbux, sumbuy].Text != "")
                                {
                                    tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                                    tbox[x, y].BackColor = Color.LightPink;
                                    tbox[sumbux, sumbuy].ForeColor = Color.Red;
                                    tbox[x, y].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

                //CEK KOTAK kanan tengah
                if (sumbux > 5 && sumbuy > 2 && sumbuy < 6)
                {
                    for (int x = 6; x < 9; x++)
                    {
                        for (int y = 3; y < 6; y++)
                        {
                            if (x != sumbux && y != sumbuy)
                            {
                                if (tbox[sumbux, sumbuy].Text == tbox[x, y].Text && tbox[sumbux, sumbuy].Text != "")
                                {
                                    tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                                    tbox[x, y].BackColor = Color.LightPink;
                                    tbox[sumbux, sumbuy].ForeColor = Color.Red;
                                    tbox[x, y].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

                //CEK KOTAK kanan bawah
                if (sumbux > 5 && sumbuy > 5)
                {
                    for (int x = 6; x < 9; x++)
                    {
                        for (int y = 6; y < 9; y++)
                        {
                            if (x != sumbux && y != sumbuy)
                            {
                                if (tbox[sumbux, sumbuy].Text == tbox[x, y].Text && tbox[sumbux, sumbuy].Text != "")
                                {
                                    tbox[sumbux, sumbuy].BackColor = Color.LightPink;
                                    tbox[x, y].BackColor = Color.LightPink;
                                    tbox[sumbux, sumbuy].ForeColor = Color.Red;
                                    tbox[x, y].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }
            }
        }

        //WEDHANA NYARI POSISI AKTIF HINT
        private void simpanposisiTboxHint_Enter(object sender, EventArgs e)
        {
            var tboxbariskolom = sender as TextBox;
            sumbux = Convert.ToInt32(Convert.ToString(tboxbariskolom.Name.Substring(0, 1)));
            sumbuy = Convert.ToInt32(Convert.ToString(tboxbariskolom.Name.Substring(1, 1)));
        }

        //WEDHANA HINT  
        private void pictureBoxHint_Click(object sender, EventArgs e)
        {
            //diwarnai ulang mewarnai ulang
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {                  
                    if (x < 3 && y > 5 || x < 3 && y < 3 || x > 2 && x < 6 && y > 2 && y < 6 || x > 5 && y > 5 || x > 5 && y < 3)
                    {
                        tbox[x, y].BackColor = Color.SkyBlue;
                        tbox[x, y].ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        tbox[x, y].BackColor = Color.Orchid;
                        tbox[x, y].ForeColor = Color.DarkSlateGray;
                    }
                }
            }
            tbox[sumbux, sumbuy].Text = soal[sumbux, sumbuy];
            hint += 2;
        }


        //LIVIA RESTART
        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            benar = 0;
            salah = 0;
            hint = 0;
            score = 100;
            giveup = 0;
            FormGame f2 = new FormGame();
            f2.Show();
            this.Hide();
        }

        //VANYA GIVEUP
        private void pictureBoxGiveUp_Click(object sender, EventArgs e)
        {
            salah = 0;
            giveup = 1; //biar tau kalo dia udh melewati giveup
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    //diwarnai ulang mewarnai ulang
                    if (x < 3 && y > 5 || x < 3 && y < 3 || x > 2 && x < 6 && y > 2 && y < 6 || x > 5 && y > 5 || x > 5 && y < 3)
                    {
                        tbox[x, y].BackColor = Color.SkyBlue;
                        tbox[x, y].ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        tbox[x, y].BackColor = Color.Orchid;
                        tbox[x, y].ForeColor = Color.DarkSlateGray;
                    }

                    if (tbox[x, y].Text != soal[x, y])
                    {
                        salah += 2;
                    }
                    tbox[x, y].Text = soal[x, y];
                }
            }
        }

        //INEZ 
        private void pictureBoxClose1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //INEZ
        private void pictureBoxEnd_Click(object sender, EventArgs e)
        {
            if (giveup == 1)
            {
                score = score - salah - hint;
            }
            else if (giveup == 0)
            {
                salah = 0;
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (tbox[x, y].Text != soal[x, y])
                        {
                            salah += 2;
                        }
                    }
                }
                score = score - salah - hint;
            }
            FormCongrats congrats = new FormCongrats();
            congrats.Show();
            this.Hide();
        }
    }
}
