using System;

namespace Humans{

    public class Human : IDamageable
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        private int Damage;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public string Nombre
        {
            get { return Name; }
            set { Name = value; }
        }
        public Human(string name){
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
            Damage = 10;
        }

//SuperHuman instant training/levelup
        public Human(string name, int strength, int intelligence, int dexterity, int HealthPts, int damage){
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = HealthPts;
            Damage = damage;
        }


         
         
         
        // Add a constructor to assign custom values to all fields
         
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int damage = this.Strength * 5;
            target.health = target.health - damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.health;
        }
        public int Attack(IDamageable target)
        {
            Console.WriteLine($"{Name} attacked {target.Nombre} for {Damage} damage.");
            return target.TakeDamage(Damage);
        }

        public virtual int TakeDamage(int damage)
        {
            this.health = this.health - damage;
            Console.WriteLine($"{Name} attacked {this.Name} for {damage} damage!");
            return this.health;
        }

    }

}