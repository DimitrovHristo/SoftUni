using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CollectTheCoins
{
    static int coinsCollected = 0;
    static int wallsHit = 0;

    static void Main(string[] args)
    {
        int rows = 4;
        char[][] board = new char[4][];
        for (int i = 0; i < rows; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }
        string directions = Console.ReadLine();
        Move(board, directions);
        Print();

    }

    static void Move(char[][] board, string directions)
    {
        int a = 0;
        int b = 0;
        for (int i = 0; i < directions.Length; i++)
        {
            switch (directions[i])
            {
                case 'V': a += 1; if (WrongDirection(a, b, board)) a -= 1; break;
                case '<': b -= 1; if (WrongDirection(a, b, board)) b += 1; break;
                case '>': b += 1; if (WrongDirection(a, b, board)) b -= 1; break;
                case '^': a -= 1; if (WrongDirection(a, b, board)) a += 1; break;
            }
            CheckForCoin(a, b, board);


        }
    }
    static bool WrongDirection(int x, int y, char[][] board)
    {
        if (x < 0 || x > board.GetUpperBound(0) || y < 0 || y > board[x].GetUpperBound(0))
        {
            wallsHit++;
            return true;
        }
        return false;
    }

    static void CheckForCoin(int x, int y, char[][] board)
    {
        if (board[x][y] == '$')
        {
            coinsCollected++;
            board[x][y] = 'X';
        }
    }

    static void Print()
    {
        Console.WriteLine("Coins Collected: {0}", coinsCollected);
        Console.WriteLine("Walls hit: {0}", wallsHit);
    }
}