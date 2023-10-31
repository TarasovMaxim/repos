using System;
using System.IO;
using System.Threading;
namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            char[,] map = ReadMap("map.txt");
            int pacmanX = 1;
            int pacmanY = 1;
            int score = 0;
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();
            Task.Run(() => {
                while (true)
                {
                    pressedKey = Console.ReadKey();
                }
            });
            while (true)
            {
                Console.Clear();


                HandleInput(pressedKey, ref pacmanX, ref pacmanY, ref map, ref score);

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Yellow;
                DrawMap( map);

                Console.SetCursorPosition(pacmanX, pacmanY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("☻");

                Console.ForegroundColor= ConsoleColor.Green;
                Console.SetCursorPosition (50, 0);
                Console.Write($"Score {score}");

                Thread.Sleep(110);
               
            }
        }
        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");
            char[,] map = new char[GetMaxLengthOfLine(file), file.Length];
            for (int x = 0; x < map.GetLength(0); x++)
                for (int y = 0; y < map.GetLength(1); y++)
                    map[x, y] = file[y][x];
            return map;
        }
        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
        }
        private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY,ref char[,] map, ref int score)
        {
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                    if (map[pacmanX, pacmanY - 1] == ' ')
                    {
                        pacmanY -= 1;
                    }
                    else if (map[pacmanX, pacmanY - 1] == '.')
                    {
                        score++;
                        map[pacmanX, pacmanY - 1] = ' ';
                        pacmanY -= 1;
                    }
                    break;
                    case ConsoleKey.DownArrow:
                    if (map[pacmanX, pacmanY + 1] == ' ')
                        pacmanY += 1;
                    else if (map[pacmanX, pacmanY + 1] == '.')
                    {
                        score++;
                        map[pacmanX, pacmanY + 1] = ' ';
                        pacmanY += 1;
                    }
                    break;
                    case ConsoleKey.LeftArrow:
                    if (map[pacmanX - 1, pacmanY] == ' ')
                        pacmanX -= 1;
                    else if (map[pacmanX - 1, pacmanY] == '.')
                    {
                        score++;
                        map[pacmanX - 1, pacmanY] = ' ';
                        pacmanX -= 1;
                    }
                    break;
                    case ConsoleKey.RightArrow:
                    if (map[pacmanX + 1, pacmanY] == ' ')
                        pacmanX += 1;
                    else if (map[pacmanX + 1, pacmanY] == '.')
                    {
                        score++;
                        map[pacmanX + 1, pacmanY] = ' ';
                        pacmanX += 1;
                    }
                    break;
                } 
        }
        private static int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;
            foreach (var line in lines)
                if (line.Length > maxLength)
                    maxLength = line.Length;
            return maxLength;
        }
    }
}