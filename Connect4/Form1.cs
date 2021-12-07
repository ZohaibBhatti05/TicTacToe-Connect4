using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // namespace added for antialiasing

namespace Connect4
{
    public partial class Form1 : Form   // Form Class: contains graphics and event methods
    {
        public static int BoardWidth = 7;   // variables, public for Backend class
        public static int BoardHeight = 6;
        public static int Connect = 4;

        static int RedWins = 0;
        static int YellowWins = 0;  // declare int variables for win count
        static int Colour = 1;  // Players are internally recorded as 1 (red) and 2 (yellow)
        public static int[,] Board = new int[BoardWidth, BoardHeight]; // new PUBLIC 2d array for access from Backend class, all values are default (0)
        public static int FirstTo;

        public Form1()
        {
            InitializeComponent();  // Default initialisation
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
        }

        // ===========================================================================================================
        // ========================================== G R A F I K S ==================================================

        private void panel1_Paint(object sender, PaintEventArgs e)  // draws white circles innit
        {
            DoubleBuffered = true;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // set graphical smoothing to antialias
            // prevents aliasing, it's called antialias tf else is it supposed to do //

            SolidBrush brush = new SolidBrush(Color.White);

            for (int x = 0; x < BoardWidth; x++) // nested if, for 2d array:
            {
                for (int y = 0; y < BoardHeight; y++)
                {
                    e.Graphics.FillEllipse(brush, new Rectangle(3 + (x * 100), 3 + (y * 100), 94, 94));
                    // draw a white circle innit
                }
            }
            e.Graphics.Dispose();   // dispose of graphics as it is not in use and will be redeclared
        }


        private void panel2_Paint(object sender, PaintEventArgs e)  // method runs when panel is drawn or redrawn
        /* reads from Board[] array and draws a circle with smooth edges at each position on the grid with the relevant colour
         * as read from the array. Is rerun (circles are all redrawn) whenever Board array is updated. */
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // set graphical smoothing to antialias
            // prevents aliasing, it's called antialias tf else is it supposed to do //

            for (int x = 0; x < BoardWidth; x++) // nested if, for 2d array:
            {
                for (int y = 0; y < BoardHeight; y++)
                {
                    switch (Board[x, y])    // switch statement for value in array
                    {
                        case 1: // draw red/yellow circles
                            e.Graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(3 + (x * 100), 3 + (y * 100), 94, 94));
                            break;
                        case 2:
                            e.Graphics.FillEllipse(new SolidBrush(Color.Yellow), new Rectangle(3 + (x * 100), 3 + (y * 100), 94, 94));
                            break;
                        default: break;
                    }
                }
            }
            e.Graphics.Dispose();   // dispose of graphics as it is not in use and will be redeclared
        }


        private void Form1_Load(object sender, EventArgs e) // method runs when window is loaded
        {
            // Create buttons //
            panel2.Controls.Clear();

            for (int x = 0; x < BoardWidth; x++)
            {
                Button temp = new Button();                         // create new button
                temp.Name = String.Format("button{0}", x);    // assign button name according to postition e.g button00
                temp.Location = new Point((100 * x), 0);    // assign button location in grid structure
                temp.Size = new Size(100, BoardHeight*100);                     // set button size to 100 square pixels
                temp.Click += new EventHandler(button_Click);       // add the "button_Click" method to run when button is clicked
                temp.ForeColor = Color.Blue;                        // im blue dabadee dabadai
                temp.BackColor = Color.Transparent;                 // transparent background, circles wouldnt show otherwise lol
                temp.FlatStyle = FlatStyle.Flat;                    // set flat, makes grid look stock blue
                temp.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.White);
                temp.FlatAppearance.MouseDownBackColor = Color.FromArgb(130, Color.White); 
                //  Make it translucent when hovered over/clicked
                panel2.Controls.Add(temp);                          // add button to the panel "panel1", where game is drawn

                panel2.Invalidate();                                // refresh and redraw panel contents
            }
        }

        // =============================================================================================================
        // =============================================================================================================

        private void button_Click(object sender, EventArgs e)   // event on button click
        {
            Button button = sender as Button;   // store button that was clicked

            int x = int.Parse((((Button)sender).Name).Substring(6, 1)); // retrieve x position of button from button name
            // (each button's name is it's xy position on the grid)

            // check if column is free
            int y = BoardHeight - 1;  // temp var
            while (y >= 0)  // for each row, going from bottom upwards
            {
                if (Board[x, y] == 0)   // if it is empty (doesnt contain a red or yellow piece)
                {
                    Board[x, y] = Colour;   // change it to relevant colour reference (aka place piece)

                    panel2.Invalidate();    // redraw panel, perform logic as board has been updated:

                    if (Backend.IsWin(Colour))  // if player has won:
                    {
                        if (Colour == 1)    // if player is red:
                        {
                            DisplayWinner("Red Wins!"); // call display method
                            RedWins++; RedWinsLabel.Text = String.Format("Red Wins: {0}", RedWins);
                            // increment red's win counter, update label that displays it.
                            Reset(); panel2.Invalidate();
                            // call method to reset board, redraw panel
                        }
                        else // do same as ^^ but for yellow instead of red
                        {
                            DisplayWinner("Yellow Wins!");  // Evangelionfinalepisodelast30seconds.mov
                            YellowWins++; YellowWinsLabel.Text = String.Format("Yellow Wins: {0}", YellowWins);
                            Reset(); panel2.Invalidate();
                        }

                        if (checkBox1.Checked == true)  // if users are playing firstto:
                        {
                            if (RedWins == FirstTo) { DisplayWinner("RED WINS!!!!!!!"); ResetButton_Click(sender, e); }
                            else if (YellowWins == FirstTo) { DisplayWinner("RED WINS!!!!!!!"); ResetButton_Click(sender, e); }
                            // if player has won, show second display box and reset game completely
                        }
                    }

                    else if (Backend.IsBoardFull()) { DisplayWinner("Draw!"); Reset(); panel2.Invalidate(); }
                    // if a player has not won, check if the board is full. If so, call display, and reset the game

                    else // if a piece is placed and neither player has won:
                    {
                        Colour = (Colour == 1) ? 2 : 1; // switch colour
                    }

                    TurnLabel.Text = (Colour == 1) ? "Red's Turn" : "Yellow's Turn";    // update label to display whose turn it is
                    break;  // leave loop, piece has been placed and we no longer need to see where else a piece can be placed
                }
                y--;    // if board position is invalid, decrement y and continue loop
            }
        }

        static void Reset() // method to reset board
        {
            Array.Clear(Board, 0, Board.Length); Colour = 1;    // removes all 1s and 2s from Board array
            Colour = 1; // sets colour to 1 (red's turn by default);
        }

        static void DisplayWinner(string Text)  //method to display winner, takes either "Red wins" "Yellow wins" or "Draw"
        {
            System.Windows.Forms.MessageBox.Show(Text); // create new popup box that displays who won
        }

        private void ResetButton_Click(object sender, EventArgs e)  // method when reset button is clicked
        {
            Reset(); TurnLabel.Text = "Red's Turn"; panel2.Invalidate();
            RedWins = 0; YellowWins = 0;
            RedWinsLabel.Text = "Red Wins: 0"; YellowWinsLabel.Text = "Yellow Wins: 0";
            // reset the whole game
        }

        private void FirstToBox_KeyDown(object sender, KeyEventArgs e)
        // method run whenever user presses a key while text box is focused
        {
            if (e.KeyCode == Keys.Enter)    // if user hits enter:
            {
                if (!int.TryParse(FirstToBox.Text, out FirstTo))  // if user did not enter a number, clear box
                {
                    FirstToBox.Text = "";
                }
                FirstTo = Math.Abs(FirstTo);// set value as positive if negative
                FirstToBox.Text = Convert.ToString(FirstTo);

                ResetButton_Click(sender, e); // reset games

                this.ActiveControl = null;  // remove focus on text box
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)   // method run when checkbox is clicked
        {
            if (FirstTo == 0) { FirstTo = 1; FirstToBox.Text = "1"; } // if no firstto value specified, set as 1
            if (checkBox1.Checked == true) { ResetButton_Click(sender, e); }    // reset games
        }

        private void WidthBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    // if user hits enter:
            {
                if (!int.TryParse(WidthBox.Text, out BoardWidth))  // if user did not enter a number, clear box
                {
                    WidthBox.Text = ""; 
                }
                if (BoardWidth < 4)
                {
                    BoardWidth = 4; WidthBox.Text = "4"; // board must be at least 4x4
                }
                panel1.Width = BoardWidth * 100; panel2.Width = BoardWidth * 100; // readjust size of game panel
                Board = new int[BoardWidth, BoardHeight];   // reinitialise board, resets
                Form1_Load(sender, e);  // reload form
                panel1.Invalidate(); panel2.Invalidate(); // reload panel
                this.ActiveControl = null;  // remove focus from element
            }
        }

        private void HeightBox_KeyDown(object sender, KeyEventArgs e) // same as ^^ but with height innit
        {
            if (e.KeyCode == Keys.Enter)    // if user hits enter:
            {
                if (!int.TryParse(HeightBox.Text, out BoardHeight))  // if user did not enter a number, clear box
                {
                    HeightBox.Text = "";
                }
                if (BoardHeight < 4)
                {
                    BoardHeight = 4; HeightBox.Text = "4";
                }
                panel1.Height = BoardHeight*100; panel2.Height = BoardHeight * 100;
                Board = new int[BoardWidth, BoardHeight];
                Form1_Load(sender, e);
                panel1.Invalidate(); panel2.Invalidate();
                this.ActiveControl = null;
            }
        }

        private void ConnectCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    // if user hits enter:
            {
                if (!int.TryParse(ConnectCount.Text, out Connect))  // if user did not enter a number, clear box
                {
                    ConnectCount.Text = "";
                }
                if (Connect < 3)
                { Connect = 3; ConnectCount.Text = "3"; }   // minimum of connect 3
                if (BoardWidth < Connect)
                {
                    BoardWidth = Connect; WidthBox.Text = Convert.ToString(Connect);    // if exceeds existing grid size, adjust grid size
                    panel1.Width = (BoardWidth * 100); panel2.Width = (BoardWidth * 100);
                }
                if (BoardHeight < Connect)
                {
                    BoardHeight = Connect; HeightBox.Text = Convert.ToString(Connect);
                    panel1.Height = (BoardHeight * 100); panel2.Height = (BoardHeight * 100);
                }
                Board = new int[BoardWidth, BoardHeight];   // reinitialise grid
                Form1_Load(sender, e);  // reload form
                panel1.Invalidate(); panel2.Invalidate(); // reload panel
                
                this.ActiveControl = null;  // remove focus from control
            }
        }

        private void ResetGameButton_Click(object sender, EventArgs e)
        {
            Reset(); panel2.Invalidate(); TurnLabel.Text = "Red's Turn"; // reset current game
        }
    }
}