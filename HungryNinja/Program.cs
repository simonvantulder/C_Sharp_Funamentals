using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {

            SweetTooth Assassin = new SweetTooth();
            SpiceHound MilkPlease = new SpiceHound();
            Buffet allYouCanEat = new Buffet();
            while (!Assassin.IsFull) 
            {
            Assassin.Consume(allYouCanEat.Serve());
            }
            if (Assassin.IsFull){
                Console.WriteLine("Uh I'm stuffed");
            }
            while (!MilkPlease.IsFull) 
            {
            MilkPlease.Consume(allYouCanEat.Serve());
            }
            if (MilkPlease.IsFull){
                Console.WriteLine("Uh I'm stuffed");
            }
            if(MilkPlease.ConsumptionHistory.Count > Assassin.ConsumptionHistory.Count)
            {
                Console.WriteLine($" SpiceHound MilkPlease ate {MilkPlease.ConsumptionHistory.Count} items that is {MilkPlease.ConsumptionHistory.Count - Assassin.ConsumptionHistory.Count} more than SweetTooth Assassin");
            }
            else if(MilkPlease.ConsumptionHistory.Count < Assassin.ConsumptionHistory.Count){
                Console.WriteLine($" SweetTooth Assassin ate {Assassin.ConsumptionHistory.Count} items that is {Assassin.ConsumptionHistory.Count - MilkPlease.ConsumptionHistory.Count} more than SpiceHound MilkPlease");
            }
            else{
                Console.WriteLine($" SpiceHound MilkPlease and SweetTooth Assassin both ate {MilkPlease.ConsumptionHistory.Count}");
            }
        }
    }
}
