using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3
{
    class Player
    {
        private int player_number;
        private char symbol;
        private int step = 0;

        public Player(int _player_number, char _symbol)
        {
            player_number = _player_number;
            symbol = _symbol;
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

        public void add_symbol()
        {
            step = step + 1;
            Console.WriteLine("Player {0} add symbol {1}. Number step: {2}", player_number, symbol, step);
        }

        public void reset_step(Game_Memento memento)
        {
            this.step = memento.step;
            Console.WriteLine("Reset game. Number step of player: {0}", step);
        }

        public Game_Memento Save_Game()
        {
            Console.WriteLine("Game is saved.");
            return new Game_Memento(step);
        }
    }
}
