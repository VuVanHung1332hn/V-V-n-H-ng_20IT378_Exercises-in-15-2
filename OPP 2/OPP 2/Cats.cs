using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_1
{
     class Cats: Animal
    {
        public Cats()
        {
            Console.WriteLine("A Cat was created.");
        }

        // Override the sleep and eats methods from the animal class
        public override void sound()
        {
            Console.WriteLine("A Cat sounds 'Meo Meo'");
        }

        public override void sleep()
        {
            Console.WriteLine("A Cat sleep a lot.");
        }
        public override void breed()
        {
            Console.WriteLine("A Cat have breeds Tabby ,British shorthair , and Ragdoll.");
        }
        public override void climb()
        {
            Console.WriteLine("A Cat can climb.");
        }
    }
}
