namespace Commands
{
    internal class KittyKitty
    {
        public void CallingTheCat()
        {
            //Prompts the user to call the cat
            Console.WriteLine("There is a soft gray kitten watching you work in the kitchen \nDo you wish to call it?");
            Console.WriteLine("\n 1. Yes \n 2. No");
            string CallTheCat = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            switch (CallTheCat)
            {
                case "2":
                    Console.WriteLine("You chose to not call the cat :( \nNothing Happens... \nYou walk back to the kitchen island");
                    Console.WriteLine("Press \"Z\" to continue");
                    Console.ReadKey();
                    Program.ReloopMain();
                    break;


                case "1":
                    //Prompts the user to pet the cat

                    Console.WriteLine("You call the cat \nThe cat purrs and walks over to you \nYou can pet it");
                    Console.WriteLine("Do you wish to pet the cat? \n 1.Yes \n 2.No");
                    string PetTheCat = Console.ReadLine();
                    Console.WriteLine("----------------------------------");


                    switch (PetTheCat)
                    {
                        case "1":
                            Console.OutputEncoding = System.Text.Encoding.UTF8;
                            Console.WriteLine(@"You pet the cat, its fur is long and soft
                                   ∫ /ᐠ｡ ｡ᐟ\ is purring                      ");
                            Console.WriteLine("Press \"Z\" to continue");
                            Console.ReadKey();
                            Program.ReloopMain();
                            break;
                        case "2":
                            Console.WriteLine("You refrain from petting the cat \nThe cat walks back to its spot and lays down \nYou go back to the kitchen island");
                            Console.WriteLine("Press \"Z\" to continue");
                            Console.ReadKey();
                            Program.ReloopMain();
                            break;
                        default:
                            Console.WriteLine("That was not an option");
                            Console.WriteLine("Press \"Z\" to continue");
                            Console.ReadKey();
                            Program.ReloopMain();
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("That was not an option");
                    Console.WriteLine("Press \"Z\" to continue");
                    Console.ReadKey();
                    Program.ReloopMain();
                    break;
            }



        }
    }
}
