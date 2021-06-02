using System;
using System.Collections.Generic;

namespace Humans{
    class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Strawberries", 50, false, true),
                new Food("MacAndCheese", 7000, false, false),
                new Food("Enchiladas", 900, true, false),
                new Food("BlueBerries", 10, false, true),
                new Food("Melon", 400, false, true),
                new Food("Bananas", 50, false, true),
                new Food("Pears", 100, false, true),
            };
        }
        
        public Food Serve()
        {
            int rando = new Random().Next(1, 8);

            return Menu[rando];
        }
    }
}