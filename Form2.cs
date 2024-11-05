using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
    public partial class Form2 : Form
    {
        int player1Score = 0;
        int player2Score = 0;

        bool turn = true;
        int turn_count = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "(X) Player 1";
            label2.Text = "(O) Player 2";
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();

            label1.Visible = turn;
            label2.Visible = !turn;
        }
        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;
            if (there_is_a_winner)
            {
                dissableButtons();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Selamat Anda Menang ", " Bagus ");


            }
            else
            {
                if (turn_count == 9) MessageBox.Show("Anda Berdua Seri", " Coba Lagi");



            }

            if (there_is_a_winner)
            {
                dissableButtons();
                string winner = turn ? "O" : "X";
                showWinnerMessageBox(winner);

                keluar.Text = "Keluar";
                button10.Text = "Reset";
            }
            else
            {
                if (turn_count == 9) showWinnerMessageBox("Draw");
                keluar.Text = "Keluar";
                button10.Text = "Reset";
            }


        }
        private void dissableButtons()
        {
            try { foreach (Control c in Controls) { Button b = (Button)c; b.Enabled = false; } } catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "Reset"; // Reset the text on the "Reset" button itself

            player1Score = 0;
            player2Score = 0;


            label5.Text = "Player 1 Score: " + player1Score;
            label6.Text = "Player 2 Score: " + player2Score;

            turn = true; // Player 1 starts
            turn_count = 0;


            try
            {
                foreach (Control c in Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Enabled = true;
                        b.Text = "";

                        keluar.Text = "Keluar";
                        button10.Text = "Reset";
                    }
                }
            }
            catch { }


            label1.Visible = true; // Player 1 label visible
            label2.Visible = false; // Player 2 label hidden





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


            label5.Text = "Player 1 Score: " + player1Score;
            label6.Text = "Player 2 Score: " + player2Score;

            startNewGame();

        }

        private void startNewGame()
        {

            turn = true;
            turn_count = 0;


            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = true;
                    b.Text = "";
                }
            }


            label1.Visible = true;
            label2.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
