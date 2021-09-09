using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Method
{
    class BubbleSort : SortBase
    {
        public BubbleSort(SuperDuperArray superDuperArray) : base(superDuperArray)
        {
            Name = "BubbleSort";
        }
        public override void SortMe()
        {
            base.SortMe();

            int n = superDuperArray.SortMe.Length;
            for (int i=1; i< n; i++)
            {
                for(int j = n-1;j>=1; j--)
                {
                    if(superDuperArray.SortMe[j] < superDuperArray.SortMe[j-1])
                    {
                        int buffer = superDuperArray.SortMe[j - 1];
                        superDuperArray.SortMe[j - 1] = superDuperArray.SortMe[j];
                        superDuperArray.SortMe[j] = buffer;
                    }
                }
            }
        }
    }
}
