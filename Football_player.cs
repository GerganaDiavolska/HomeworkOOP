using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkForOOPL
{
    public abstract class Football_player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        public Football_player(string name, int age, int number, double height)
        {
            this.Name = name;
            this.Number = number;
            this.Age = age;
            this.Height = height;
        }

    }
}
