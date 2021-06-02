using System;
namespace HungryNinja
{
    class Drink : IConsumable
{
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy {get;set;}
    public bool IsSweet {get;set;}

        // Implement a GetInfo Method
        public string GetInfo()
        {
            Console.WriteLine($"{Name}'s calories is: {Calories} and is {IsSweet}");
            return $"{Name}'s calories is: {Calories} and is {IsSweet}";
        }

        // Add a constructor method
        public Drink(string name, int calories, Boolean isSpicy, bool isSweet)
        {
            //default is shared among all drinks
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = true;
        }
    }   
}