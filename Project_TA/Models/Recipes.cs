using System;

namespace Project_TA.Models
{
    public class Recipes
    {
        public string FoodName { get; set; }
        public string FoodImage { get; set; }
        public string FoodRecipes { get; set; }
        public string Ingredient { get; set; }

        public override string ToString()
        {
            return FoodName;
        }

    
    }
}
