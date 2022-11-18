using System.ComponentModel;

namespace wf_TicTacToe
{
    public partial class Form1 : Form
    {
        /* Vems tur det är:
         * true = X spelar
         * false = O spelare */

        bool turn = true;
        int turn_count = 0;






        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Skapat av: \nKenny Ruan\nLeon Vidos\nAdam Zahirovic", "Tic Tac Toe Om");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            if (turn)
                click.Text = "X";
            else
                click.Text = "O";




            turn = !turn;
            click.Enabled = false;
            turn_count++;

            check_for_wins();
        }
        private void check_for_wins()
        {
            bool found_winner = false;

            // checkar vinnare horisontellt
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                found_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                found_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                found_winner = true;

            //checkar vinnare vertikalt 
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                found_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                found_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                found_winner = true;

            // checkar vinnare diagonalt
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                found_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                found_winner = true;

            //checkar om det finns en vinnare 
            if (found_winner)
            {
                disable_buttons();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show("vinnaren är " + winner, "vinnare!");
            } //Slut för if
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Oavgjort!", "Oj!");
            }
        }//slut för Chechforwins
        private void disable_buttons()
        {
            try
            {
                foreach (Component c in Controls)
                {
                    Button click = (Button)c;
                    click.Enabled = false;

                }//slut för foreach
            }//slut för try
            catch { }

        }//slut för disablebuttons

        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            turn = true;
            turn_count= 0;


            try
            {
                foreach (Component c in Controls)
                {
                    Button click = (Button)c;
                    click.Text = "";
                    click.Enabled = true;

                }//slut för foreach
            }//slut för try
            catch { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}