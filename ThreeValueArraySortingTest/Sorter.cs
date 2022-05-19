using System.Diagnostics;

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
