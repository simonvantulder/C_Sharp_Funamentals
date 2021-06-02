using System;

namespace Humans
{
    public class Samurai : Human
    {
        public Samurai(string name, int strength, int intelligence, int dexterity, int health, int Damage) : base(name, strength, intelligence, dexterity, 200, Damage)
    {

    }
        public override int Attack(Human target)
        {
            if(target.Health < 50){
                target.Health = 0;
                Console.WriteLine($"{Name} slaughtered {target.Name}!");
            }
            else{
            base.Attack(target);
            }
            return target.Health;
        }

        public void Meditate(){
            Health = 200;
        }
    }
}