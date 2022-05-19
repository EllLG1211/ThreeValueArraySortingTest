namespace ThreeValueArraySortingTest
{
    internal class CountingSorter : Sorter
    {
        protected override void SortingAlgorithm(int[] array)
        {
            int[] numberof = { 0, 0 };

            foreach(var item in array) if (item != 2) ++numberof[item];

            int[] indexes = {0, numberof[0], numberof[0] + numberof[1]};

            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (array[i] == array[indexes[value]]) indexes[value]++;
                else
                {
                    array[i] = array[indexes[value]];
                    array[indexes[value]] = value;
                }
            }
        }
    }
}
