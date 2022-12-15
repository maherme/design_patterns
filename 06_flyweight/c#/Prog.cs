using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int m = 0;
            List<int> American = new List<int>();
            List<int> Italian = new List<int>();
            List<int> Mexican = new List<int>();
            List<int> Meat = new List<int>();
            List<int> Soup = new List<int>();
            List<int> Salad = new List<int>();
            List<int> FastFood = new List<int>();
            CFlyweightFactory flywf = new CFlyweightFactory();

            i = flywf.Addition("Burguer");
            American.Add(i);
            Meat.Add(i);
            FastFood.Add(i);

            i = flywf.Addition("Caprese");
            Italian.Add(i);
            Salad.Add(i);

            i = flywf.Addition("Minestrone");
            Italian.Add(i);
            Soup.Add(i);

            i = flywf.Addition("Tacos al pastor");
            Mexican.Add(i);
            Meat.Add(i);
            FastFood.Add(i);

            i = flywf.Addition("Burrito");
            Mexican.Add(i);
            Meat.Add(i);
            FastFood.Add(i);

            i = flywf.Addition("Pizza");
            Italian.Add(i);
            FastFood.Add(i);

            i = flywf.Addition("Nopales");
            Mexican.Add(i);
            Salad.Add(i);

            i = flywf.Addition("Black Angus");
            American.Add(i);
            Meat.Add(i);

            foreach(int n in FastFood){
                CRecipe recipe = (CRecipe)flywf[n];
                recipe.CalculatePrice();
                recipe.Show();
            }
            Console.WriteLine("--------------------------");
            foreach(int n in American){
                CRecipe recipe = (CRecipe)flywf[n];
                //recipe.CalculatePrice();  // This calculate the extrinsec state, if commented price is 0
                recipe.Show();
            }
            Console.WriteLine("--------------------------");
            i = flywf.Addition("Pizza");
            Console.WriteLine("--------------------------");
            foreach(int n in Salad){
                CRecipe recipe = (CRecipe)flywf[n];
                recipe.CalculatePrice();
                recipe.Show();
            }
            Console.WriteLine("--------------------------");
            // Show all recipes inside the factory:
            for(m = 0; m < flywf.Count; m++){
                CRecipe recipe = (CRecipe)flywf[m];
                recipe.CalculatePrice();
                recipe.Show();
            }
        }
    }
}
