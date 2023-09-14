using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    internal class Testing_Search_Functions
    {
        public void kjh()
        {
            //testing different methods of "searching" and displaying code ie searching cupcake, will bring up the 
            var food = new List<string>() { "Cake", "Cookies", "Pancake", "Cupcake", "Vanilla Pudding", "Fruit Snacks" };

            string foodItem = Console.ReadLine();

            if (food.Contains(foodItem)) 
            {
                Console.WriteLine("Yes");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No recipes match that name (Case sensitive)\nPress \"Z\" to continue");
                Console.ReadKey();
                Program.ReloopMain();
            }
        }
    }
}
