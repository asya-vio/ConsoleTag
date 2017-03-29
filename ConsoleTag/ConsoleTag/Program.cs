using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTag
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gameArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };

            int[] gameArr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0, 15};

            Game3 game3 = null;
            try
            {
                game3 = new Game3(gameArr);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("{0} ", ex);
                return;
            }

            Game2 game2 = null;
            try
            {
                game2 = new Game3(gameArr2);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("{0} ", ex);
                return;
            }

            ConsoleGameUI game2UI = new ConsoleGameUI(game2);

            ConsoleGameUI game3UI = new ConsoleGameUI(game3);

            game2UI.StartGame();

            game3UI.StartGame();



        }
    }
}
