﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTag
{
    class Game2 : Game, IPlayable
    {
        private const int stepsInRandomize = 20;
        public Game2(params int[] value)
            : base(value)
        {
            this.Randomize();

        }

        private int GetRandomValueForShift()
        {
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            List<int> possibleStep = new List<int>();

            Point zero = GetLocation(0);

            if (zero.J > 0) possibleStep.Add(this[zero.I, zero.J - 1]);
            if (zero.I > 0) possibleStep.Add(this[zero.I - 1, zero.J]);
            if (zero.I < BoardSize - 1) possibleStep.Add(this[zero.I + 1, zero.J]);
            if (zero.J < BoardSize - 1) possibleStep.Add(this[zero.I, zero.J + 1]);

            int rnd = rand.Next(possibleStep.Count - 1);
            int randomValue = possibleStep[rnd];
            return randomValue;
        }
        public void Randomize()
        {
            for (int i = 0; i < stepsInRandomize; i++)
            {
                int randomValue = GetRandomValueForShift();
                Swap(randomValue, 0);
            }
        }

        public bool IsFinished()
        {
            int count = 0;
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    count++;
                    if (this[i, j] != count && (i != BoardSize - 1 || j != BoardSize - 1) ||
                        this[i, j] != 0 && i == BoardSize - 1 && j == BoardSize - 1)
                        return false;
                }
            }
            return true;
        }

    }
}
