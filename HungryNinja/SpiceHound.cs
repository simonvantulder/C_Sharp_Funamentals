using System;
namespace HungryNinja
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get { if (this.calorieIntake >= 1200) return true; else return false; }
        }


        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (this.IsFull)
            {
                Console.WriteLine("This Ninja is Full and can't eat anymore.");
            }
            else
            {
                while (!this.IsFull)
                {
                    if (item.IsSweet == true)
                    {
                        calorieIntake += item.Calories + 10;
                    }
                    else
                    {
                        calorieIntake += item.Calories + 10;
                    }
                    ConsumptionHistory.Add(item);
                    Console.WriteLine($"{item.Name} + has {item.Calories} calories");
                }

            }
        }
    }
}