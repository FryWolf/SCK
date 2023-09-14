using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolkit;

namespace Commands
{
    internal class KittyKitty
    {
        public void CallingTheCat()
        {
            //Prompts the user to call the cat
            Console.WriteLine("There is a soft gray kitten watching you work in the kitchen \nDo you wish to call it?");
            Console.WriteLine("\n 1. Yes \n 2. No");
            string? CallTheCat = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            switch (CallTheCat)
            {
                case "2":
                    CommonTools.Continue("You chose to not call the cat :( \nNothing Happens... \nYou walk back to the kitchen island");
                    break;

                case "1":
                    //Prompts the user to pet the cat

                    Console.WriteLine("You call the cat \nThe cat purrs and walks over to you \nYou can pet it");
                    Console.WriteLine("Do you wish to pet the cat? \n 1.Yes \n 2.No");
                    string? PetTheCat = Console.ReadLine();
                    Console.WriteLine("----------------------------------");
                    

                    switch (PetTheCat)
                    {
                        case "1":
                            Console.OutputEncoding = System.Text.Encoding.UTF8;
                            CommonTools.Continue(@"You pet the cat, its fur is long and soft
                                   ∫ /ᐠ｡ ｡ᐟ\ is purring                      ");
                            break;
                        case "2":
                            CommonTools.Continue("You refrain from petting the cat \nThe cat walks back to its spot and lays down \nYou go back to the kitchen island");
                            break;
                        default:
                            CommonTools.Continue("That was not an option");
                            break;
                    }
                    break;

                default:
                    CommonTools.Continue("That was not an option");
                    break;
            }
        }
    }
}
