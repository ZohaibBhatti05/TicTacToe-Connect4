using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWinForm
{
    public partial class Form1 : Form
    {
        static char[,] Grid = {
            { '-','-','-'},
            { '-','-','-'},
            { '-','-','-'} };

        static char Player = 'X';
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            bool reset = false;
            string temp = ((Button)sender).Name;

            int x = int.Parse(temp.Substring(6, 1)) - 1;
            int y = int.Parse(temp.Substring(7, 1)) - 1;

            if (PlacePiece(x, y))
            {
                Button button = sender as Button;
                button.Text = Convert.ToString(Player);

                if (IsWin())
                { reset = true; DisplayWinner(String.Format("{0} wins!!", Player)); }

                else if (IsBoardFull())
                { reset = true; DisplayWinner("Draw!!"); }

                else { Player = (Player == 'X') ? 'O' : 'X'; }
                label1.Text = String.Format("{0}'s turn.", Player);

                if (reset)
                {
                    button11.Text = "-"; button21.Text = "-"; button31.Text = "-";
                    button12.Text = "-"; button22.Text = "-"; button32.Text = "-";
                    button13.Text = "-"; button23.Text = "-"; button33.Text = "-";
                    Reset();
                }
            }
        }

        static bool PlacePiece(int x, int y)
        {
            if (Grid[x, y] == '-')
            {
                Grid[x, y] = Player;
                return true;
            }
            return false;
        }

        static bool IsWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((Grid[i, 0] == Player && Grid[i, 1] == Player && Grid[i, 2] == Player)
                    || (Grid[0, i] == Player && Grid[1, i] == Player && Grid[2, i] == Player))
                { return true; }
            }
            if ((Grid[0, 0] == Player && Grid[1, 1] == Player && Grid[2, 2] == Player)
                || (Grid[2, 0] == Player && Grid[1, 1] == Player && Grid[0, 2] == Player)) { return true; }
            return false;
        }

        static bool IsBoardFull()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (Grid[x, y] == '-') { return false; }
                }
            }
            return true;
        }

        static void DisplayWinner(string Text)
        {
            System.Windows.Forms.MessageBox.Show(Text);
            Reset();
        }

        static void Reset()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Grid[x, y] = '-';
                }
            }
            Player = 'X';
        }
    }
}
