using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the Yield Keyword *****\n");
            Garage carLOt = new Garage();
            foreach (Car c in carLOt)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed); 
            }
            Console.WriteLine();
            foreach (Car c in carLOt.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }
            Console.ReadLine();
        }
    }
}
