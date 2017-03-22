using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTag
{
    class ConsoleGameUI
    {
        IPlayable game;


        public ConsoleGameUI(IPlayable game)
        {
            this.game = game;
        }


        public void PrintBoard()
        {
            for (int i = 0; i < ((Game2)game).BoardSize; i++)
            {
                for (int j = 0; j < ((Game2)game).BoardSize; j++)
                {
                    if (((Game2)game)[i, j] / 10 > 0) Console.Write("{0} ", ((Game2)game)[i, j]);
                    else Console.Write("{0}  ", ((Game2)game)[i, j]);
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

        public void PlayGame()
        {
            int step = 0;
            while (!((Game2)game).IsFinished())
            {
                Console.Clear();
                PrintBoard();

                int shiftValue = ReadShiftValue();

                try
                {
                    ((Game2)game).Shift(shiftValue);
                    step++;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("{0}", ex.Message);
                    Console.ReadLine();
                }

            }

            Console.Clear();
            PrintBoard();

            Console.WriteLine("Игра завершена за {0} шагов! Поздравляю!", step);
            Console.ReadLine();
        }


    }
}
