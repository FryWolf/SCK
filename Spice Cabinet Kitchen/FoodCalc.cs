using System;
using System.Text;

namespace Commands
{
    internal class Egg_sorting
    {
        public void eggcounter()
        {
            StringBuilder sb = new StringBuilder();
            //egg box calculator
            sb.AppendLine("");
            sb.AppendLine("There are eggs and egg cartons sitting on the counter in front of you");
            sb.AppendLine("\n");
            sb.AppendLine("How many eggs do you want to put in cartons?");
            Console.WriteLine(sb.ToString());
            int NumOfEggs=0;
            while (NumOfEggs == 0)
            {
                try
                {
                    NumOfEggs = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { NumOfEggs = 0; Console.WriteLine("Error: Invalid input. Please enter a valid integer (e.g 23871)."); }
                catch (OverflowException) { Console.WriteLine("Error: Input is out of range. Please enter an integer between -2147483648 and 2147483647"); }
            }
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
            sb.Clear();
            int cartons = (NumOfEggs / 12) + extraCarton;
            sb.AppendLine("You will need " + cartons + " carton(s)");
            sb.AppendLine("Filled carton(s): " + (NumOfEggs / 12));
            //states number of Eggs that don't fill a full carton
            sb.AppendLine("Extra egg(s): " + extra);
            sb.AppendLine("----------------------------------");
            sb.AppendLine("You packaged " + NumOfEggs + "!");
            sb.AppendLine("\nYou walk back to the kitchen island");
            sb.AppendLine("Press \"Z\" to continue");
            Console.WriteLine(sb);
            Console.ReadKey();
            Program.ReloopMain();
        }

    }
}
