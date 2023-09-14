using System;
using System.Runtime.CompilerServices;
using System.Text;
using Toolkit;

namespace Commands
{
    internal class Recipe_Cards
    {
        public void Recipe()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("You found a recipe box on the counter\nDo you want to open it?\n 1. Yes\n 2. No");
            string? OpenBox = (Console.ReadLine());

            //opens box or leaves the program
            switch (OpenBox)
            {
                case "1":
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("You open the box and find some recipe cards \nDo you want to read them? \n 1. Yes\n 2. No");
                    string? ReadCard = (Console.ReadLine());
                    switch (ReadCard)
                    {
                        case "1":
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("You pull out the recipe cards \nWhich recipe do you want to read?");
                            // Places for the recipe cards
                            Console.WriteLine("\n 1. Vanilla Cake\n 2. Pancakes \n insert other recipies here");

                            string? CardNumber = Console.ReadLine();
                            switch (CardNumber)
                            {
                                case "1":
                                    Console.Clear();
                                    CommonTools.Continue("Vanilla Cake Recipe Card\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\nIngredients:\r\n½ cup of butter\r\n1 ⅓ cups of sugar\r\n2 cups of all-purpose flour\r\n1 tbsp of baking powder\r\n½ tsp of salt\r\n1 cup of milk\r\n3 tsp of Vanilla extract\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n1. Preheat the oven to 350°F\r\n2. Cream the butter and sugar together\r\n3. Add in eggs and stir\r\n4. Stir in milk and vanilla into the batter\r\n5. Combine the dry ingredients and stir into\r\nthe batter\r\n6. Bake until golden and allow to cool\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\nBake for 40 minutes at 350°F in a 9x13 pan\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n");
                                    break;
                                case "2":
                                    Console.Clear();
                                    CommonTools.Continue("Pancake Recipe Card\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\nIngredients:\r\n1 ½ cups of all-purpose flour\r\n1 tbsp of baking powder\r\n1 tbsp of sugar\r\n1 pinch of salt\r\n1 ¼ cups of milk\r\n3 tbsp of butter\r\n1 egg\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n1. Combine the flour, baking powder, sugar,\r\nand salt in a large bowl\r\n2. Melt the butter\r\n3. Pour the milk, egg, and butter into the dry\r\nIngredients\r\n4. Mix until generally smooth \r\n(a few lumps are fine)\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\nPour small amounts into the pan and flip \r\nto cook both sides\r\n");
                                    break;
                                case "3":
                                    Console.Clear();
                                    CommonTools.Continue("Insert Food Recipe Card\nRecipe goes here");
                                    break;
                                case "4":
                                    Console.Clear();
                                    CommonTools.Continue("Insert Food Recipe Card\nRecipe goes here");
                                    break;

                                //returns to the main menu when invalid chars are inputed
                                default:
                                    CommonTools.Continue("That was not an option");
                                    break;
                            }
                            break;

                        case "2":
                            CommonTools.Continue("You decide to examine the lovely box instead\nYou walk back to the kitchen island");
                            break;
                        default:
                            CommonTools.Continue("That was not an option");
                            break;
                    }
                    break;
                case "2":
                    CommonTools.Continue("You decide to not open the box\nYou walk back to the kitchen island\n");
                    break;
                default:
                    CommonTools.Continue("That was not an option");
                    break;
            }
        }
    }
}
