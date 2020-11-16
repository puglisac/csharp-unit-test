using System;
using System.Collections.Generic;

namespace UnitTestingProject
{
    public class AwesomeSauce
    {
        public List<string> Sauces { get; set; }

        public AwesomeSauce()
        {
            Sauces = new List<string>();
        }

        public bool isSauceAwesome(string sauce)
        {
            return Sauces.Contains(sauce);
        }

    }
}
