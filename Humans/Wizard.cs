using System;

namespace Humans
{
    public class Wizard : Human
    {
        public Wizard(string name, int strength, int intelligence, int dexterity, int health, int Damage) : base(name, strength, 25, dexterity, 50, Damage)
        {
        }

        public override int Attack(Human target)
        //damage = 5 * Intelligence, heals the Wizard by amount damage dealt
        {
            int damage = this.Intelligence * 5;
            this.Health += damage;
            target.Health = target.Health - damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.Health;

        }

        public int Heal(Human target)
        {
            return target.Health += 10 * this.Intelligence;
        }
    }
}
