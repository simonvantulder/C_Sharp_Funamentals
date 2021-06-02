using System;
namespace randomPass.Models
{
    public class Dachi
    {
        public int Happiness { get; set; }

        public int Fullness { get; set; }

        public int Energy { get; set; }

        public int Meals { get; set; }

        public bool Alive {get; set;}

        public Dachi()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 100;
            Alive = true;
        }


        public int Play(Dachi pet)
        {
            Random r = new Random(); //add chance dont want to play
            pet.Happiness +=  r.Next(5,11);

            pet.Energy -= 5;
            if (pet.Energy <= 0){
                Alive = false;
            }
            
            return pet.Happiness;
        }


        public void Feed(Dachi pet)
        {
            Random r = new Random(); //add chance dont want to that food
            pet.Fullness +=  r.Next(5,11); // add cant feed without meals
            pet.Meals -= 1;
            
            if (pet.Meals <= 0){
                Alive = false;
            }            

        }


        public void SleepInn(Dachi pet)
        {
            Random r = new Random(); //add chance dont want that food
            pet.Fullness -= 5;  // add cant feed without meals
            pet.Happiness -=  5; // add cant feed without meals
            pet.Energy += 15;
            
            if (pet.Happiness <= 0 || pet.Fullness <= 0){
                Alive = false;
            }
        }

        public void Work(Dachi pet)
        {
            Random r = new Random(); //add chance dont want that food
            pet.Meals +=  r.Next(1,4); // add cant feed without meals
            pet.Energy -= 1;

            if (pet.Energy <= 0){
                Alive = false;
            }
            
        }
    }
}
