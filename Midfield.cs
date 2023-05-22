using System;
using System.Collections.Generic;
using System.Text;

namespace Football_HW
{
    public class Midfield : FootballPlayer
    {
        public Midfield(string name, int age, int number, int height) : base(name, age, number, height)
        {
            Name = name;
            Age = age;
            Number = number;
            Height = height;
            
        }
    }
}
