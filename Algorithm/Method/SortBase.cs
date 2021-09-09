using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Method
{
    class SortBase : ISort
    {
        protected SuperDuperArray superDuperArray;
        public string Name { get; protected set; }
        public SortBase(SuperDuperArray superDuperArray)
        {
            this.superDuperArray = superDuperArray;
            Name = "BaseSort";
        }

        public virtual void SortMe()
        {
            Console.WriteLine("THIS IS VIRTUAL FUNCTION/METHOD");
            Console.WriteLine("sorting is in progress, please wait");
        }
    }
}
