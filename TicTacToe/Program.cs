using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] Grid = {
            { '-','-','-'},
            { '-','-','-'},
            { '-','-','-'} };

        static void Main()
        {
            Engine();
        }

        static void Engine()
        {
            do
            {
                char Player = 'X';

                while (true)
                {
                    PlacePiece(Player);
                    Print();

                    if (IsWin(Player))
                    { Console.WriteLine("Player {0} wins!!", Player); break; }

                    else if (IsBoardFull())
                    { Console.WriteLine("Draw!!"); break; }

                    else
                    { Player = (Player == 'X') ? 'O' : 'X'; }
                }
                Console.WriteLine("Enter 'Y' to play again");
                if (Console.ReadLine().ToLower() != "y")
                { break; }
            }
            while (true);
        }

        static void PlacePiece(char Player)
        {
            while(true)
            {
                Console.WriteLine("Enter x coord");
                int x = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Enter y coord");
                int y = int.Parse(Console.ReadLine()) - 1;
                if (Grid[x,y] == '-')
                {
                    Grid[x, y] = Player; break;
                }
            }
        }
        static bool IsWin(char Player)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((Grid[i,0] == Player && Grid[i,1] == Player && Grid[i,2] == Player)
                    || (Grid[0,i] == Player && Grid[1, i] == Player && Grid[2, i] == Player))
                { return true; }
            }
            if ((Grid[0,0] == Player && Grid[1,1] == Player && Grid[2,2] == Player)
                || (Grid[2,0] == Player && Grid[1,1] == Player && Grid[0,2] == Player)) { return true; }
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
        static void Print()
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write(Grid[x, y]);
                }
                Console.WriteLine();
            }
        }

    }
}
