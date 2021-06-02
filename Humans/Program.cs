using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Person = new Human("bobette");
            Console.WriteLine(Person.Name);

            Ninja Assassin = new Ninja("Warrior", 10,10,10,100, 10);
            Buffet allYouEat = new Buffet();




            
            // while (!Assassin.isFull) 
            // {
            // Assassin.Eat(allYouEat.Serve());
            // }
            // if (Assassin.isFull){
            //     Console.WriteLine("Uh I'm stuffed");
            // }
        }
    }
}
