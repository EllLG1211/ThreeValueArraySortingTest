using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeValueArraySortingTest
{
    internal abstract class Sorter
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Starting: " + GetType().Name);
            var stopwatch = Stopwatch.StartNew();
            SortingAlgorithm(array);
            stopwatch.Stop();
            //PrintArray(array);
            Console.WriteLine(GetType().Name + " completed in " + stopwatch.Elapsed.TotalSeconds);
        }

        protected abstract void SortingAlgorithm(int[] array);

        protected void PrintArray(int[] array)
        {
            Console.Write("[ ");
            foreach (var item in array) Console.Write(item.ToString() + " ");
            Console.WriteLine("]");
        }
    }
}
