using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class SuperDuperArray
    {
        private readonly int[] Buffer;
        public int[] SortMe { get; set; }
        private SuperDuperArray(int n)
        {
            Buffer = new int[n];
            SortMe = new int[n];
            RandomGenerator();
        }
        public static SuperDuperArray Implementation(int n) =>  new(n);
        private void RandomGenerator()
        {
            for(int i = 0; i < Buffer.Length; i++)
            {
                int random = new Random().Next(0, 100000);
                Buffer[i] = random;
                SortMe[i] = random;
            }
        }
        public void DeepCopy()
        {
            for (int i = 0; i < Buffer.Length; i++)
            {
                SortMe[i] = Buffer[i];
            }
        }
        public void ShowMe()
        {
            foreach (var value in SortMe)
            {
                Console.WriteLine(value);
            }
        }
    }
}
