using System;
using System.Collections.Generic;
using System.Text;

namespace Football_HW
{
    public abstract class FootballPlayer : Person
    {
        public int Number { get; set; }
        public int Height { get; set; }

        public FootballPlayer(string name, int age, int number, int height) 
        {
            Name = name;
            Age = age;
            Number = number;
            Height = height;
        }

    }
}
