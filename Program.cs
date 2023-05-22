using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkForOOPL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Football_player> firstPlayer = new List<Football_player>();

            Console.WriteLine("Enter count on players:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

           Team playersMethod = new Team();
           playersMethod.Players(n,firstPlayer);

            Random random = new Random();
            Random random2 = new Random();

            List<Referee> referees = new List<Referee>();
            Game gameMethod = new Game();

            Random minute = new Random();
            int time = minute.Next(0, 60);

            gameMethod.TheGame(3,random,random2,firstPlayer,referees,time);

        }
    }
}
