using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTag
{
    interface IPlayable
    {
        int BoardSize { get; }

        void Randomize();

        bool IsFinished();

        int this[int I, int J] { get;}


        void Shift(int value);
    }
}
