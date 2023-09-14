using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    internal class Egg_sorting
    {
        public void eggcounter()
        {
            //egg box calculator
            Console.WriteLine("There are eggs and egg cartons sitting on the counter in front of you");
            Console.WriteLine("\n");
            Console.WriteLine("How many eggs do you want to put in cartons?");
            int NumOfEggs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            int extraCarton = 0;
            int extra = (NumOfEggs % 12);
            //checks for zeros
            if (extra != 0)
            {
                extraCarton = extra / extra;
            }
            //makes the remainder one for easy addition
            //adds values and states number of cartons needed to contain all the eggs
            int cartons = (NumOfEggs / 12) + extraCarton;
            Console.WriteLine("You will need ");
            Console.Write(cartons);
            Console.WriteLine(" carton(s)");
            Console.Write("Filled carton(s): ");
            Console.WriteLine(NumOfEggs / 12);
            //states number of Eggs that don't fill a full carton
            Console.Write("Extra egg(s): ");
            Console.Write(extra);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("You packaged " + NumOfEggs + "!");
            Console.WriteLine("\nYou walk back to the kitchen island");
            Console.WriteLine("Press \"Z\" to continue");
            Console.ReadKey();
            Program.ReloopMain();
        }

    }
}
