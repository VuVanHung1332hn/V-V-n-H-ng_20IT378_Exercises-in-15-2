using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_1
{
    class Animal
    {
        //Create a default contructor 
        //default construtor 

        public Animal() 
        {
            Console.WriteLine("An animal has been created. ");
        }
        public virtual void sleep()
        {
            Console.WriteLine("An Animal sleeps.");
        }
        public virtual void sound()
        {
            Console.WriteLine("An Animal eats different things.");
        }
        public virtual void breed() 
        {
            Console.WriteLine("An animal has many different breeds.");
        }
        public virtual void climb()
        {
            Console.WriteLine("An animal has several types that can be climb.");
        }
        public virtual void swim()
        {
            Console.WriteLine("An animal has several types that can be swim.");
        }
    }
}
