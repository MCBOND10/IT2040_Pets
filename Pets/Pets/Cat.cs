using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Cat : Pet
    {
        public Cat(string Name, string Owner, double Weight) : base("cat", Name, Owner, Weight)
        {
        }

        public string meow(int count)
        {
            string meowing = string.Concat(Enumerable.Repeat("meow.", count));
            return meowing;
        }
    }
}
