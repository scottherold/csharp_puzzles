using System;
using System.Collections.Generic;
namespace puzzles
{
    public class Program
    {
        public static int[] RandomArray()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(5,25);
            }
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            foreach (int val in arr)
            {
                sum = sum + val;
                if (val < min)
                {
                    min = val;
                }
                if (val > max)
                {
                    max = val;
                }
            }
            Console.Write("Array Min Value: {0}, Max Value: {1}\n",min,max);
            Console.Write("The sum of the array's values is {0}.\n\n",sum);
            return arr;
        }
        public static string CoinToss()
        {
            Console.Write("Tossing a Coin!\n");
            Random rand = new Random();
            int result = rand.Next(1,3);
            string face = "";
            if (result > 1)
            {
                face = "Heads";
            }
            else
            {
                face = "Tails";
            }
            Console.WriteLine(face);
            return face;
        }
        public static double TossMultipleCoins(int num)
        {
            int i = 0; 
            double headsCount = 0;
            double tailsCount = 0;
            while (i < num)
            {
                string face = CoinToss();
                i += 1;
                if (face == "Heads")
                {
                    headsCount += 1;
                }
                else
                {
                    tailsCount += 1;
                }
            }
            double ratio = headsCount/tailsCount;
            Console.WriteLine(ratio+"\n");
            return ratio;
        }
        public static string[] Names()
        {
            Random rand = new Random();
            string[] arr = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydeny"};
            string container = "";
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                container = arr[i];
                int randIndex = rand.Next(0,arr.Length);
                arr[i] = arr[randIndex];
                arr[randIndex] = container;
            }
            foreach (string val in arr)
            {
                Console.WriteLine(val+"\n");
                if (val.Length > 5)
                {
                    counter += 1;
                }
            }
            // Console.WriteLine("*************************************************\n");
            string[] newArr = new string[counter];
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > 5)
                {
                    newArr[x] = arr[i];
                    x++;
                }
            }
            // foreach (string val in newArr)
            // {
            //     Console.WriteLine(val+"\n");
            // }
            return newArr;
        }
        static void Main(string[] args)
        {
            RandomArray();
            CoinToss();
            TossMultipleCoins(5);
            Names();
        }
    }
}
