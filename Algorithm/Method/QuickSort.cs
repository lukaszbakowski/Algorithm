using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Method
{
    class QuickSort : SortBase
    {
        public QuickSort(SuperDuperArray superDuperArray) : base(superDuperArray)
        {
            Name = "QiuckSort";
        }
        public override void SortMe()
        {
            base.SortMe();
            QSort(0, superDuperArray.SortMe.Length - 1);
        }
        private void QSort(int left, int right)
        {
            int center = superDuperArray.SortMe[(left + right) / 2];
            int i, j, buff;
            i = left;
            j = right;
            do
            {
                while (superDuperArray.SortMe[i] < center) i++;
                while (superDuperArray.SortMe[j] > center) j--;
                if (i <= j)
                {
                    buff = superDuperArray.SortMe[i];
                    superDuperArray.SortMe[i] = superDuperArray.SortMe[j];
                    superDuperArray.SortMe[j] = buff;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (j > left) QSort(left, j);
            if (i < right) QSort(i, right);
        }
    }
}
