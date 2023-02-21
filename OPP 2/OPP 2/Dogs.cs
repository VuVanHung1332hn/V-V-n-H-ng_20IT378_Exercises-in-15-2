using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_1
{
     class Dogs:Animal
    {

        public Dogs() 
        {
            Console.WriteLine("A Dog was created.");
        }

        // Override the sleep and eats methods from the animal class
        public override void sound()
        {
            Console.WriteLine("A Dog sounds 'Gau Gau'");
        }

        public override void sleep()
        {
            Console.WriteLine("A Dog sleep during the day");
        }
        public override void breed()
        {
            Console.WriteLine("A Dog have breeds Spaniel, Chihuahua, and Collie.");
        }
    }
}
