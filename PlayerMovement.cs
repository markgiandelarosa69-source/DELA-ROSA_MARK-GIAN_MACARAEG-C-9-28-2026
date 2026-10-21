using System;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;

        char player = '@';
        int playerX = 5;
        int playerY = 5;

        while (true)
        {
            Console.Clear();

            Console.SetCursorPosition(playerX, playerY);
            Console.Write(player);

            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.W && playerY > 0)
                playerY--;

            else if (key == ConsoleKey.S && playerY < Console.WindowHeight - 1)
                playerY++;

            else if (key == ConsoleKey.A && playerX > 0)
                playerX--;

            else if (key == ConsoleKey.D && playerX < Console.WindowWidth - 1)
                playerX++;
        }
    }
}
