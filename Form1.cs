using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.Drawing.Text;
namespace TICTACTOE
{
    public partial class Form1 : Form
    {
        int player1Score = 0;
        int player2Score = 0;

        // ... Rest of the code remains the same
        bool turn = true;
        int turn_count = 0;

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

                MessageBox.Show(winner + "wins", "good");
            }
            else
            {
                if (turn_count == 9) MessageBox.Show("Draw" + "Try Again");

            }

            if (there_is_a_winner)
            {
                dissableButtons();
                string winner = turn ? "O" : "X"; // Player who just played wins
                showWinnerMessageBox(winner); // Call modified method
            }
            else
            {
                if (turn_count == 9) showWinnerMessageBox("Draw"); // Draw message box
            }


        }
        private void dissableButtons()
        {
            try { foreach (Control c in Controls) { Button b = (Button)c; b.Enabled = false; } } catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "Reset";

            player1Score = 0;
            player2Score = 0;

            // Update score labels
            label5.Text = "Player 1 Score: " + player1Score;
            label6.Text = "Player 2 Score: " + player2Score;

            turn = true; // Player 1 starts
            turn_count = 0;

            // Reset buttons
            try
            {
                foreach (Control c in Controls)
                {
                    Button b =c as Button;
                    if (b != null)
                    {
                        b.Enabled = true; // Enable all buttons
                        b.Text = ""; // Clear button text
                    }
                }
            }
            catch { }

            // Reset labels (optional)
            label1.Visible = true; // Player 1 label visible
            label2.Visible = false; // Player 2 label hidden

        }

        private void Exit_Click(object sender, EventArgs e)
        {
           
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void showWinnerMessageBox(string winner)
        {
          
                // Increment score of the winning player
                if (winner == "X")
                {
                    player1Score++;
                }
                else if (winner == "O")
                {
                    player2Score++;
                }

                // Update score labels
                label5.Text = "Player 1 Score: " + player1Score;
                label6.Text = "Player 2 Score: " + player2Score;
            // Start a new game
            startNewGame();

        }

        private void startNewGame()
        {
            // Reset game state variables
            turn = true;
            turn_count = 0;

            // Enable all buttons
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = true;
                    b.Text = "";
                }
            }

            // Update labels (optional)
            label1.Visible = true; // Player 1 label visible
            label2.Visible = false; // Player 2 label hidden
           
        }
        
    }
}
