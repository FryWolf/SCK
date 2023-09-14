//Add the namespace to program calling

using Toolkit;

class Program
{
    static void Main(string[] args)
    {
        //UnComment these to continue testing out the Search Function!
        //Commands.Testing_Search_Functions Sf = new Commands.Testing_Search_Functions();
        //Sf.kjh();
        Program.ReloopMain();
        
    }
    public static void ReloopMain()
    {
        Commands.Egg_sorting EggSort = new Commands.Egg_sorting();
        Commands.KittyKitty CallCat = new Commands.KittyKitty();
        Commands.Recipe_Cards RecipeCard = new Commands.Recipe_Cards();
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Clear();
        Console.WriteLine(@"----------------------------------------------------------------------------------------
                             |<Spice Cabinet Kitchen>| 
----------------------------------------------------------------------------------------


");
        Console.WriteLine("You find yourself standing in a fragrant kitchen \nWhat would you like to do?");
        Console.WriteLine("\n 1. Package the Eggs for the Market? \n 2. Call the Cat? \n 3. Read Recipes? \n 4. Leave the Kitchen? (Exits the Program)");

        string? options = Console.ReadLine();
        Console.WriteLine("----------------------------------");
        //switch for running the seperate programs
        switch (options)
        {
            case "1":
                //runs the egg sorter
                EggSort.eggcounter();
                break;
            case "2":
                // calls the cat
                CallCat.CallingTheCat();
                break;
            case "3":
                //Reads recpie cards
                RecipeCard.Recipe();
                break;
            case "4":
                //exits the program
                break;
            default:
                CommonTools.Continue("Please choose a valid number");
                break;
        }
        
    }
}
