using System;
using System.IO;

namespace com.fabioscagliola.AdventOfCode202101
{
    class Program
    {
        static void Main()
        {
            string[] lineList = File.ReadAllLines("Input1.txt");

            // PART 1 
            int measurements = 0;
            for (int i = 0; i < lineList.Length - 1; i++)
            {
                int measurement1 = int.Parse(lineList[i]);
                int measurement2 = int.Parse(lineList[i + 1]);
                if (measurement2 > measurement1)
                    measurements++;
            }
            Console.WriteLine($"{measurements} measurements are larger than the previous measurement");

            // PART 2 
            int sums = 0;
            int currSum = 0;
            int prevSum;
            for (int i = 0; i < lineList.Length - 2; i++)
            {
                prevSum = currSum;
                int measurement1 = int.Parse(lineList[i]);
                int measurement2 = int.Parse(lineList[i + 1]);
                int measurement3 = int.Parse(lineList[i + 2]);
                currSum = measurement1 + measurement2 + measurement3;
                if (prevSum != 0 && currSum > prevSum)
                    sums++;
            }
            Console.WriteLine($"{sums} sums are larger than the previous sum");
        }

    }
}

