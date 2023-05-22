using System;
using System.Collections.Generic;
using System.Text;

namespace Football_HW
{
    public class Defender : FootballPlayer
    {
        public Defender(string name, int age, int number, int height) : base(name, age, number, height)
        {
            Name = name;
            Age = age;
            Number = number; 
            Height = height;
        }
    }
}
