using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dogs dogs= new Dogs(); 
            // Dogs class
            
            dogs.sound();
            dogs.sleep();
            dogs.breed();

            
            Cats cats= new Cats();
            // Cats class
            cats.sound();
            cats.sleep();
            cats.breed();
            cats.climb();

            Dusks dusks= new Dusks();
            // Dusks class
            dusks.sound();
            dusks.sleep();
            dusks.breed();
            dusks.swim();
            Console.ReadLine();
        }
    }
}
