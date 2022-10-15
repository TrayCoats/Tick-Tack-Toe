using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tick_Tack_Toe
{
    public partial class Form1 : Form
    {
        int winCountX = 0;
        int winCountO = 0;
        int currentTurn = 0;

        String[] gameWorld = new string[9];
        

        public String returnSymbol(int turn)
        {
            if(turn % 2 == 0)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }
        public void CheckForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                string combo = "";
                switch (i)
                {
                    case 0:
                        combo = gameWorld[0] + gameWorld[1] + gameWorld[2];
                        break;
                    case 1:
                        combo = gameWorld[0] + gameWorld[4] + gameWorld[8];
                        break;
                    case 2:
                        combo = gameWorld[0] + gameWorld[3] + gameWorld[6];
                        break;
                    case 3:
                        combo = gameWorld[2] + gameWorld[4] + gameWorld[6];
                        break;
                    case 4:
                        combo = gameWorld[2] + gameWorld[5] + gameWorld[8];
                        break;
                    case 5:
                        combo = gameWorld[0] + gameWorld[4] + gameWorld[8];
                        break;
                    case 6:
                        combo = gameWorld[3] + gameWorld[4] + gameWorld[5];
                        break;
                    case 7:
                        combo = gameWorld[6] + gameWorld[7] + gameWorld[8];
                        break;
                    case 8:
                        combo = gameWorld[1] + gameWorld[4] + gameWorld[7];
                        break;

                }
                if (combo.Equals("XXX"))
                {
                    MessageBox.Show("X has won the game!", "Better luck next time O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StartOver();
                    winCountX++;
                    Xscore.Text = winCountX.ToString();
                }
                else if (combo.Equals("OOO"))
                {
                    MessageBox.Show("O has won the game!", "Better luck next time X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StartOver();
                    winCountO++;
                    Oscore.Text = winCountO.ToString();
                }
                Draw();
            }
        }
        public void StartOver()
        {
            Check1.Text = "";
            Check2.Text = "";
            Check3.Text = "";
            Check4.Text = "";
            Check5.Text = "";
            Check6.Text = "";
            Check7.Text = "";
            Check8.Text = "";
            Check9.Text = "";

            currentTurn = 0;
            gameWorld = new string[9];
        }
        public void Draw()
        {
            int counter = 0;
            for (int i = 0; i < gameWorld.Length; i++)
            {
                if(gameWorld[i] != null)
                {
                    counter++;
                }
                if (counter == 9) 
                {
                    StartOver();
                    MessageBox.Show("WOW, That's a draw!", "We need a winner try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Check1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameWorld[0] = returnSymbol(currentTurn);
            Check1.Text = gameWorld[0];
            CheckForWinner();
        }
        private void Check2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameWorld[1] = returnSymbol(currentTurn);
            Check2.Text = gameWorld[1];
            CheckForWinner();
        }
        private void Check3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameWorld[2] = returnSymbol(currentTurn);
            Check3.Text = gameWorld[2];
            CheckForWinner();
        }
        private void Check4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameWorld[3] = returnSymbol(currentTurn);
            Check4.Text = gameWorld[3];
            CheckForWinner();
        }
        private void Check5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameWorld[4] = returnSymbol(currentTurn);
            Check5.Text = gameWorld[4];
            CheckForWinner();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameWorld[5] = returnSymbol(currentTurn);
            Check6.Text = gameWorld[5];
            CheckForWinner();
        }
        private void Check7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameWorld[6] = returnSymbol(currentTurn);
            Check7.Text = gameWorld[6];
            CheckForWinner();
        }
        private void Check8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameWorld[7] = returnSymbol(currentTurn);
            Check8.Text = gameWorld[7];
            CheckForWinner();
        }
        private void Check9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameWorld[8] = returnSymbol(currentTurn);
            Check9.Text = gameWorld[8];
            CheckForWinner();
        }
        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            StartOver();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StartOver();
            winCountX = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
