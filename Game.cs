using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkForOOPL
{
     public class Game
    {
        public void TheGame(int n,Random random,Random random2, List<Football_player> team, List<Referee> referees,int time) 
        {
            
            Console.WriteLine("Team 1:");
            int playerI = random.Next(team.Count);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(team[playerI]);
            }

            Console.WriteLine("Team 2:");
            int player = random2.Next(team.Count);
            for (int i = 0; i < 11; i++)
            {
               
                Console.WriteLine(team[player]);
            }

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter number 1:(Referee), 2:(Assistant referees )");
                string input = Console.ReadLine();
                string[] data = input.Split(',');

                if (data[0] == "1")
                {
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine();
                    int age = int.Parse(data[1]);
                    Referee r = new Referee(name, age);
                    referees.Add(r);  
                }
                else if (data[0] == "2")
                {
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine();
                    int age = int.Parse(data[1]); 
                    Referee aR = new Referee(name, age);
                    referees.Add(aR);
                    
                }
            }

            if (time<30)
            {
                Console.WriteLine("Goal in " + time + " minute");
                Console.WriteLine(team[playerI]);
                Console.WriteLine("Winner is Team 1");
            }
            else
            {
                Console.WriteLine("Goal in " + time + " minute");
                Console.WriteLine(team[player]);
                Console.WriteLine("Winner is Team 2");
            }
            

        }
    }
}
