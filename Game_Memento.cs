using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3
{
    class Game_Memento
    {
        public int step{get; private set;}

        public Game_Memento( int step)
        {
            this.step = step;
        }
    }
}
