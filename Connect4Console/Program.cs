using System;
using System.Collections.Generic;

namespace Connect4Console
{
    class Program
    {
        static int[,] Board = new int[9, 6];

        static void Main()
        {
            //Print();
            Engine();
        }

        static void Engine()
        {
            do
            {
                int Switch = 0;
                int Colour = 1; // For the sake of simplicity, red will be 1 and yellow 2

                while (true)
                {
                    PlacePiece(Colour);
                    Print();

                    if (IsWin(Colour))
                    { Console.WriteLine("Player {0} wins!!",Colour); break; }

                    else if (IsBoardFull())
                    { Console.WriteLine("Draw!!"); break; }

                    else
                    { Switch = 1 - Switch; Colour = Switch + 1; }
                }
                Console.WriteLine("Enter 'Y' to play again");
                if (Console.ReadLine().ToLower() != "y")
                { break; }
            }
            while (true);
        }

        static void PlacePiece(int Colour)
        {
            int x; int y;
            while (true)
            {
                Console.WriteLine("Enter x coord");
                x = int.Parse(Console.ReadLine()) - 1;

                y = 5;
                while(y >= 0)
                {
                    if (Board[x, y] == 0)
                    {
                        Board[x, y] = Colour; break;
                    }
                    y--;
                }
                break;
            }
        }

        static bool IsWin(int Colour)
        {
            // check horizontal
            
            for (int y = 5; y >= 0; y--)
            {
                for (int x = 0; x < 6; x++) // only check until index 6, as past then is impossible
                {
                    if (Board[x,y] == Colour
                    && Board [x+1,y] == Colour
                    && Board[x+2,y] == Colour
                    && Board[x+3,y] == Colour)
                    { return true; }
                }
            }

            // check vertical

            for (int x = 0; x < 9; x++)
            {
                for (int y = 5; y > 2; y--) // only check until index 2, as past then is impossible
                {
                    if (Board[x, y] == Colour
                    && Board[x, y-1] == Colour
                    && Board[x, y-2] == Colour
                    && Board[x, y-3] == Colour)
                    { return true; }
                }
            }

            // check diagonal (pos gradient)

            for (int x = 0; x < 6; x++)
            {
                for (int y = 3; y < 6; y++) // only checks these values as theyre the only possible diagonal wins
                {
                    if (Board[x, y] == Colour
                    && Board[x+1, y-1] == Colour
                    && Board[x+2, y-2] == Colour
                    && Board[x+3, y-3] == Colour)
                    { return true; }
                }
            }

            // check diagonal (neg gradient)

            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 3; y++) // only checks these values as theyre the only possible diagonal wins
                {
                    if (Board[x, y] == Colour
                    && Board[x+1, y+1] == Colour
                    && Board[x+2, y+2] == Colour
                    && Board[x+3, y+3] == Colour)
                    { return true; }
                }
            }

            return false;
        }

        static bool IsBoardFull()
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (Board[x,y] == 0) { return false; }
                }
            }
            return true;
        }


        static void Print()
        {
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Console.Write(Board[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
