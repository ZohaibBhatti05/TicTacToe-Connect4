using System;
using System.Collections.Generic;
using System.Text;

namespace Connect4
{
    class Backend : Form1   // class to handle backend logic (whether a board has a winning player or is full indicating a draw)
    {
        // backend logic

        public static bool IsWin(int Colour)    // method to check if a player has won (check for 4 adjacent identical pieces)
        {
            // check horizontal

            for (int y = BoardHeight - 1; y >= 0; y--)
            {
                for (int x = 0; x < BoardWidth - (Connect - 1); x++) // only check until certain index, as past then is impossible
                {
                    bool temp = true;
                    for (int i = 0; i < Connect; i++)
                    {
                        if (Form1.Board[x+i,y] != Colour)
                        {
                            temp = false; break;
                        }
                    }
                    if (temp) { return true; }
                }
            }

            // check vertical

            for (int x = 0; x < BoardWidth; x++)
            {
                for (int y = BoardHeight - 1; y > (Connect - 2); y--) // only check until index 2, as past then is impossible
                {
                    bool temp = true;
                    for (int i = 0; i < Connect; i++)
                    {
                        if (Form1.Board[x, y - i] != Colour)
                        {
                            temp = false; break;
                        }
                    }
                    if (temp) { return true; }
                }
            }

            // check diagonal (pos gradient)

            for (int x = 0; x < BoardWidth - (Connect - 1); x++)
            {
                for (int y = (Connect - 1); y < BoardHeight; y++) // only checks these values as theyre the only possible diagonal wins
                {
                    bool temp = true;
                    for (int i = 0; i < Connect; i++)
                    {
                        if (Form1.Board[x + i, y - i] != Colour)
                        {
                            temp = false; break;
                        }
                    }
                    if (temp) { return true; }
                }
            }

            // check diagonal (neg gradient)

            for (int x = 0; x < BoardWidth - (Connect - 1); x++)
            {
                for (int y = 0; y < BoardHeight - (Connect - 1); y++) // only checks these values as theyre the only possible diagonal wins
                {
                    bool temp = true;
                    for (int i = 0; i < Connect; i++)
                    {
                        if (Form1.Board[x + i, y + i] != Colour)
                        {
                            temp = false; break;
                        }
                    }
                    if (temp) { return true; }
                }
            }

            return false;
        }
        public static bool IsBoardFull()    // method to check for a full board
        {
            for (int x = 0; x < BoardWidth; x++)
            {
                for (int y = 0; y < BoardHeight; y++)
                {
                    if (Form1.Board[x, y] == 0) { return false; }   // if any index in the grid is blank, board is not full
                }
            }
            return true;    // if nothing blank, board is full
        }
    }
}
