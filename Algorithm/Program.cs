using Algorithm.Method;
using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        public static List<ISort> AlgorithmsList = new();
        static void Main(string[] args)
        {
        START:
            Console.WriteLine("Enter the size of the array to be sorted: ");
            int arrayLength;
            try
            {
                arrayLength = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                goto START;
            }

            Console.Clear();

            SuperDuperArray superDuperArray = SuperDuperArray.Implementation(arrayLength);

            AlgorithmsList.Add(new BubbleSort(superDuperArray));
            AlgorithmsList.Add(new QuickSort(superDuperArray));

            foreach(var algorithm in AlgorithmsList)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Before sorting:");
                superDuperArray.ShowMe();
                Console.WriteLine("-------------------------------------------------");
                Timer time = new();
                algorithm.SortMe();
                Console.WriteLine($"Approximate working time of the algorithm {algorithm.Name}: {time.EndTime().TotalSeconds} [s]");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("After sorting:");
                superDuperArray.ShowMe();
                superDuperArray.DeepCopy();
                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}
