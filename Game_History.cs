using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3
{
    class Game_History
    {
        public Game_History()
        {
            History = new Stack<Game_Memento>();
        }

        internal Game_Memento Game_Memento
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Stack<Game_Memento> History { get; private set; }
    }
}
