using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_1
{
    class Dusks:Animal
    {
        public Dusks()
        {
            Console.WriteLine("A Duck was created.");
        }

        // Override the sleep and eats methods from the animal class
        public override void sound()
        {
            Console.WriteLine("A Duck sounds 'Quao Quao'");
        }

        public override void sleep()
        {
            Console.WriteLine("A Duck sleep at night.");
        }
        public override void breed()
        {
            Console.WriteLine("A Dusk have breeds Khaki Campbell ,Cayuga , and Rouen.");
        }
        public override void swim()
        {
            Console.WriteLine("A Dusk can swim.");
        }
    }
}

