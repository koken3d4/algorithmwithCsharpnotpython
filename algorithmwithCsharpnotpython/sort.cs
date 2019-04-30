using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmwithCsharpnotpython
{
    internal class sort
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        internal sort()
        {
        }
        internal sort(List<int> intList)
        {
            sortStart(intList.ToArray());
        }

        internal void sortStart(int[] intArray)
        {
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                select_min_array(intArray, i);
            }
        }

        void select_min_array(int[] array, int i)
        {
            int min = i;
            for (int ii = i; ii < array.Length - 1; ii++)
            {
                if (array[i] > array[ii])
                    min = ii;
            }
            //元の本だと、タプルパッキングとシーケンスアンパッキングを用いているがC#ではよく分からなかったので安定した手法を用いる。
            int tempInt = array[i];
            array[i] = array[min];
            array[min] = tempInt;
        }



    }
}
