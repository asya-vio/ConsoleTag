using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTag
{
    interface IPlayable
    {
        void Randomize();

        bool IsFinished();

        void Shift(int value);
    }
}
