using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pet(string Type, string Name, string Owner, double Weight)
        {
            type = Type;
            name = Name;
            owner = Owner;
            weight = Weight;

        }

        public string getTag()
        {
            string tag = String.Format("If lost, call {0}.", owner);
            return tag;
        }
    }
}
