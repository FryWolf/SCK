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
            int NumOfEggs = -1;
            while (NumOfEggs == -1)
            {
                try
                {
                    NumOfEggs = Convert.ToInt32(Console.ReadLine());
                    if (NumOfEggs < 0)
                    {
                        NumOfEggs = -1;
                        Console.WriteLine("Are you crazy? Just put in a normal number...");
                    }
                }
                catch (FormatException) { NumOfEggs = 0; Console.WriteLine("We have a lot of eggs, but we don't have that many."); }
                catch (OverflowException) { Console.WriteLine("\nPlease try a smaller number!"); }

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
