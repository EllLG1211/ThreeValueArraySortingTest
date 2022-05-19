using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeValueArraySortingTest
{
    internal class ShrinkingSorter : Sorter
    {
        protected override void SortingAlgorithm(int[] array)
        {
            int index0 = 0;
            int index2 = array.Length - 1;

            while (array[index0] == 0) ++index0;
            while (array[index2] == 2) --index2;

            int i = index0;
            while (i <= index2) switch (array[i])
                {
                    case 0:
                        array[i] = array[index0];
                        array[index0] = 0;
                        ++index0;
                        ++i;
                        break;
                    case 1:
                        ++i;
                        break;
                    case 2:
                        array[i] = array[index2];
                        array[index2] = 2;
                        --index2;
                        break;
                }
        }
    }
}
