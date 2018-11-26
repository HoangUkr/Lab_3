using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LabWork #3");
            Console.WriteLine("Student: Pham Xuan Hoang");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("Variant 11");
            Player player_1 = new Player(1, 'X');
            Player player_2 = new Player(2, 'O');
            player_1.add_symbol();
            player_2.add_symbol();
            player_1.add_symbol();
            player_2.add_symbol();
            player_1.add_symbol();
            player_2.add_symbol();
            Game_History game = new Game_History();
            game.History.Push(player_1.Save_Game());
            game.History.Push(player_2.Save_Game());
            player_1.add_symbol();
            player_2.add_symbol();
            player_1.reset_step(game.History.Pop());
            player_1.add_symbol();
            Console.ReadKey();
        }
    }
}
