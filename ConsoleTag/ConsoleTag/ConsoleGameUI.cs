using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTag
{
    class ConsoleGameUI
    {
        Game2 game;
        //Game3 Play3;

        public ConsoleGameUI(Game2 game)
        {
            this.game = game;
        }

        //public ConsoleGameUI(Game3 Play3)
        //{
        //}

        public void PrintBoard()
        {
            for (int i = 0; i < game.BoardSize; i++)
            {
                for (int j = 0; j < game.BoardSize; j++)
                {
                    if (game[i, j] / 10 > 0) Console.Write("{0} ", game[i, j]);
                    else Console.Write("{0}  ", game[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int ReadShiftValue()
        {
            int value = -1;
            while (value == -1)
            {
                Console.Clear();
                Console.WriteLine("Введите номер сдвигаемой фишки");

                if (Int32.TryParse(Console.ReadLine(), out value))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введено не число типа int!");
                }
            }
            return value;
        }

    }
}
