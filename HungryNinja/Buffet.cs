using System;
using System.Collections.Generic;

namespace HungryNinja{
    class Buffet
    {
        public List<IConsumable> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Strawberries", 50, false, true),
                new Food("MacAndCheese", 7000, false, false),
                new Food("Enchiladas", 900, true, false),
                new Food("BlueBerries", 10, false, true),
                new Food("Melon", 400, false, true),
                new Food("Bananas", 50, false, true),
                new Food("Pears", 100, false, true),
                new Drink("BlueBerries milkshake", 10, false, true),
                new Drink("Melon milkshake", 400, false, true),
                new Drink("Bananas milkshake", 50, false, true),
                new Drink("Pears milkshake", 100, false, true),
            };
        }
        
        public IConsumable Serve()
        {
            int rando = new Random().Next(0, 11);
            return Menu[rando];
        }
    }
}