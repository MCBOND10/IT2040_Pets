using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Dog : Pet
    {
       
        public Dog(string Name, string Owner, double Weight) : base("dog", Name, Owner, Weight)
        {
        }

        public string bark(int count)
        { 
            string barking = string.Concat(Enumerable.Repeat("Bark!", count));
            return barking;
        }
    }
}
