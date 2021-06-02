using System;
using System.Collections.Generic;

namespace firstAssignment
{
    class Program
    {
        static void Main(string[] args){

            List<object> empty = new List<object>();
            empty.Add(7);
            empty.Add(28);
            empty.Add(-1);
            empty.Add(true);
            int sum = 0;
            foreach(var entry in empty){

                Console.WriteLine(entry);
                if (entry is int) {
                    int numEntry = (int)entry;
                    sum = sum + numEntry;
                }
            }
                Console.WriteLine(sum);
        }



    }
}

