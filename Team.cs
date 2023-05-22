using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkForOOPL
{
    public class Team
    {
        public void CreateCoach(string name, int age) 
        {
            Coach coach = new Coach(name,age);
        }

        public void Players(int numberOfPlayers, List<Football_player> FP) 
        {
            if (numberOfPlayers>11 && numberOfPlayers<22)
            {
                int sum = 0;

                for (int i = 0; i < numberOfPlayers; i++)
                {
                   
                    Console.WriteLine("Enter number 1:(Goalkeeper), 2:(Defender), 3:(Midfield) or 4:(Striker)");
                    string input = Console.ReadLine();
                    string[] data = input.Split(',');

                    if (data[0] == "1")
                    {
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        int number = int.Parse(data[1]);
                        int age = int.Parse(data[2]);
                        double height = double.Parse(data[3]);
                        Goalkeeper gK = new Goalkeeper(name, number,age,height);
                        FP.Add(gK);
                        sum = sum + age;
                     }
                    else if (data[0] == "2")
                    {
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        int number = int.Parse(data[1]);
                        int age = int.Parse(data[2]);
                        double height = double.Parse(data[3]);
                        Defender d = new Defender(name, number, age, height);
                        FP.Add(d);
                        sum = sum + age;
                     }
                    else if (data[0] == "3")
                    {

                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        int number = int.Parse(data[1]);
                        int age = int.Parse(data[2]);
                        double height = double.Parse(data[3]);
                        Midfield m = new Midfield(name, number, age, height);
                        FP.Add(m);
                        sum = sum + age;
                     }
                    else if (data[0] == "4")
                    {
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        int number = int.Parse(data[1]);
                        int age = int.Parse(data[2]);
                        double height = double.Parse(data[3]);
                        Striker s = new Striker(name, number, age, height);
                        FP.Add(s);
                        sum =sum+age;
                    }
                }
                    int average = sum / numberOfPlayers;
                    Console.WriteLine("Average age of players in Team is: " + average);
            }
             else
             {
               Console.WriteLine("Number of players must be greater than 11 and less than 22");
             }

        }

    }
}
