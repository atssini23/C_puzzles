using System;
using System.Linq;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             RandomArray();
             TossCoin();
             TossMultipleCoins();
             Names();
            
        }

        static void RandomArray(){
            int[] myArray = new int[10];
            //System.Console.WriteLine(myArray);
            Random randObj = new Random();
            for (int i = 0; i < myArray.Length; i++){
                myArray[i] = randObj.Next(5,26);
            }
            System.Console.WriteLine(myArray.Min());
            System.Console.WriteLine(myArray.Max());
            System.Console.WriteLine(myArray.Sum());
        }

        static string TossCoin(Random randObj){
            System.Console.WriteLine("Tossing a coin...");
            Random randObj = new Random();
            int CoinToss = randObj.Next(0,2);
            string res = "";
            if (CoinToss == 0){
                System.Console.WriteLine("Heads");
                res = "Heads";
            } else {
                System.Console.WriteLine("Tails");
                res = "Tails";
            }
            return res;
        }

        static Double TossMultipleCoins(int Num){
            int CountHeads = 0;
            Random r = new Random();
            for (int i = 0; i < Num; i++){
                if(TossCoin(r) == "Heads"){
                    CountHeads++;
                }
            }
            return (Double)CountHeads/Num;
        }

        static void Names(){
            string[] mynames = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random r = new Random();
            // string[] temp = new string[mynames.Length];
            for(int k = 0; k < mynames.Length; k++){
                int i = r.Next(k - k);
                string temp = mynames[k];
                mynames[k] = mynames[i];
                mynames[i] = temp;
            }
            System.Console.WriteLine(string.Join(",", mynames));

            string brace = "[ ";
            for (int z = 0; z < mynames.Length; z++) {
                if (mynames[z].Length > 5) {
                    brace += mynames[z] + ", ";
                }
            }

            brace += "]";
            System.Console.WriteLine(brace);
        }

        
    }
}
