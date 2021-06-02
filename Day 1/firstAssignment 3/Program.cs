using System;
using System.Collections.Generic;

// namespace ConsoleApplication;


namespace firstAssignment
{
    class Program
    {
        static void Main(string[] args){

        }
            // public static void PrintNumbers(int num1, int num2){
            //     for( int i = num1; i <= num2; i++){
            //         Console.WriteLine(i);
            //     }
            // }

            // public static void PrintOdds(int num1, int num2){
            //     for( int i = num1; i <= num2; i+=2){
            //         Console.WriteLine(i);
            //     }
            // }

            // public static void PrintSum(int num1, int num2){
            //     int sum = 0;
            //     for( int i = num1; i <= num2; i+=2){
            //         sum = sum + i;
            //         Console.WriteLine("New number: " + i + "Sum: " + sum);
            //     }
            // }
            // public static void LoopArray(int[] empty){
            //     for( int i = empty[0]; i <= 6; i++){
            //         Console.WriteLine(i);
            //     }
            // }

            // public static int FindMax(int[] numbers)
            // {
            //     // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            //     // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            //     // or even a mix of positive numbers, negative numbers and zero.
            // //     def Maax(list1):
            // //     if len(list1)==0:
            // //         return False
            // //     max=list1[0]
            // //     for x in range(len(list1)):
            // //         if list1[x] >max:
            // //             max=list1[x]
            // //     return max
            // // #print(Maax(list1))
            //     int max = numbers[0];
            //     for( int j = 0; j < 7; j++){
            //         if( max < numbers[j]){
            //             max = numbers[j];
            //         }
            //     }
            //     Console.WriteLine(max);
            //     return max;
            // }


            public static void GetAverage(int[] numbers)
            {
                // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
                // For example, with an array [2, 10, 3], your program should write 5 to the console.
                //     count=sum=0

                // for x in range(len(list1)):
                //     sum+=list1[x]
                // return sum/len(list1)
                int sum = numbers[0];
                int avg = 0;
                for (int k = 0; k < 7; k++)
                {
                    sum = sum + numbers[k];
                }
                avg = sum / numbers.Length;
                Console.WriteLine(avg);
            }

            public static int[] OddArray(int num1, int num2){
                int[] numArray = new int[128];
                for( int i = num1; i <= num2; i++){
                    if(i%2==0){
                    numArray[i]= i;
                    }
                }return numArray;

                // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
                // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].


            }

            public static int[] RandoArray(){
                int[] rando = new int[] {5,12,15,17,25,24,8,9,3,21};
                int max = rando[0];
                int min = rando[0];
                int sum = 0;

                for(int i =0; i < rando.Length; i++){
                    if (max < rando[i]){
                        max = rando[i];
                    }
                    if (min > rando[i]){
                        min = rando[i];
                    }
                    sum+=rando[i];
                }
                return rando;
            }

            public static string CoinFlip(){
                int rando = new Random().Next(1, 3);
                Console.WriteLine("flipping your coin");
                if( rando == 1){
                    return "Heads!";
                }
                else{
                    return "Tails!";
                }
                
            }

            public static string[] NameChoose(){
                int rando = new Random().Next(1, 20);
                string[] sList = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
                string temp = "";
                for( int i =0; i < rando; i++){
                    for( int j =0; j < 6; j++){
                        temp = sList[j+1];
                        sList[j+1] = sList[j];
                        sList[j] = temp;
                    }
                }
                return sList;
                
            }


                }
            }

        