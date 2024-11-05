using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
    public partial class Form3 : Form
    {
        int player1Score = 0;
        int player2Score = 0;
        bool turn = true; // True = giliran X; False = giliran O
        int turn_count = 0;

        public Form3()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();

            label1.Visible = turn;
            label2.Visible = !turn;
        }

        private void Form5x5_Load(object sender, EventArgs e)
        {
            label1.Text = "(X) Pemain 1";
            label2.Text = "(O) Pemain 2";
        }





        private void checkForWinner()
        {
            bool there_is_a_winner = false;
            int size = 5;

            Button[,] buttons = {
                { A1, A2, A3, A4, A5 },
                { B1, B2, B3, B4, B5 },
                { C1, C2, C3, C4, C5 },
                { D1, D2, D3, D4, D5 },
                { E1, E2, E3, E4, E5 }
            };

            // Periksa baris dan kolom untuk 4 kotak berjejer
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 3; j++)
                {
                    if (CheckLine(buttons, i, j, 0, 1, 4) || // Periksa baris
                        CheckLine(buttons, j, i, 1, 0, 4)) // Periksa kolom
                    {
                        there_is_a_winner = true;
                        break;
                    }
                }
            }

            // Periksa diagonal untuk 4 kotak berjejer
            for (int i = 0; i < size - 3; i++)
            {
                for (int j = 0; j < size - 3; j++)
                {
                    if (CheckLine(buttons, i, j, 1, 1, 4) || // Diagonal utama
                        CheckLine(buttons, i, size - 1 - j, 1, -1, 4)) // Diagonal sekunder
                    {
                        there_is_a_winner = true;
                        break;
                    }
                }
            }

            if (there_is_a_winner)
            {
                disableButtons();
                string winner = turn ? "O" : "X";
                MessageBox.Show($"{winner} Selamat Anda Menang!", "Bagus");
                showWinnerMessageBox(winner);
            }
            else if (turn_count == size * size)
            {
                MessageBox.Show("Anda Berdua Seri", "Coba Lagi");
            }

            keluar.Text = "Keluar";
            button10.Text = "Reset";
        }




        private bool CheckLine(Button[,] buttons, int startX, int startY, int stepX, int stepY, int length)
        {
            string first = buttons[startX, startY].Text;
            if (string.IsNullOrEmpty(first))
                return false;

            for (int i = 1; i < length; i++)
            {
                if (buttons[startX + stepX * i, startY + stepY * i].Text != first)
                    return false;
            }

            return true;
        }

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button b && b != button10 && b != keluar)
                {
                    b.Enabled = false;
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "Reset"; // Reset teks pada tombol "Reset"
            player1Score = 0;
            player2Score = 0;

            label5.Text = "Skor Pemain 1: " + player1Score;
            label6.Text = "Skor Pemain 2: " + player2Score;

            turn = true; // Pemain 1 mulai
            turn_count = 0;

            foreach (Control c in Controls)
            {
                if (c is Button b && b != button10 && b != keluar)
                {
                    b.Enabled = true;
                    b.Text = "";
                }
            }

            label1.Visible = true; // Label Pemain 1 terlihat
            label2.Visible = false; // Label Pemain 2 tersembunyi
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Akan keluar Dari Permainan", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
        }

        private void showWinnerMessageBox(string winner)
        {
            if (winner == "X")
            {
                player1Score++;
            }
            else if (winner == "O")
            {
                player2Score++;
            }

            label5.Text = "Skor Pemain 1: " + player1Score;
            label6.Text = "Skor Pemain 2: " + player2Score;

            startNewGame();
        }

        private void startNewGame()
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                if (c is Button b && b != button10 && b != keluar)
                {
                    b.Enabled = true;
                    b.Text = "";
                }
            }

            label1.Visible = true;
            label2.Visible = false;
        }
    }

}
