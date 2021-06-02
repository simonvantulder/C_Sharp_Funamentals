using System;
using System.Collections.Generic;


namespace Humans{
    class Ninja : Human
{
    private int calorieIntake;
    // private Boolean IsFull;
    public List<Food> FoodHistory;
     

    // public Ninja(){
    //     calorieIntake = 0;
    //     FoodHistory = new List<Food>();
    // }

        public Ninja(string name, int strength, int intelligence, int dexterity, int Health, int Damage) : base(name, strength, intelligence, 175, Health, Damage)
        {
        }

        // add a public "getter" property called "IsFull"

        public override int Attack(Human target)
        {
            int rando = new Random().Next(0, 5);
            int damage = 0;
            if (rando == 0){
                damage = this.Dexterity * 5 + 10;
            }
            else{
                damage = this.Dexterity * 5;
            }
            target.Health = target.Health - damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.Health;

        }

        public int Steal(Human target)
        {
            this.Health += 5;
            return target.Health - 5;
        }
//      public Boolean isFull
//     {
//         get { if (this.calorieIntake >= 1200) return true; else return false; }
//     }
//     // build out the Eat method
//     public void Eat(Food item)
//     {
//         if( this.isFull){
//             Console.WriteLine( "This Ninja is Full and can't eat anymore.");
//         }
//         else { 
//             // while ( !this.isFull){

//             calorieIntake += item.Calories;
//             FoodHistory.Add(item);
//             Console.WriteLine($"{item.Name} + {item.IsSweet}");
//             // }

//         }
//     }

}

}