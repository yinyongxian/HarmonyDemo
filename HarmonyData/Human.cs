using System;
using System.Collections.Generic;
using System.Text;

namespace HarmonyData
{
    public class Human
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public string Greet()
        {
            return $"Hello, my name is {Name} and I am {Age} years old.";
        }
    }
}
