﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkForOOPL
{
   public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
