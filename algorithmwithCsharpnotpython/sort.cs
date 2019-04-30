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

        /// <summary>
        /// 配列は参照型なので、これで配列の内容が変更されるので大丈夫
        /// </summary>
        /// <param name="intArray"></param>
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

        static internal void insertionSort(int[] intArray)
        {
            for (int i = 1; i < intArray.Length - 1; i++)
                insert(intArray, i);
        }

        static void insert(int[] array, int ii)
        {
            //
            int temp = array[ii];
            for (int i = ii - 1; i >= 0; i--)
            {
                if (temp < array[i])
                    array[i + 1] = array[i];
                else
                {
                    array[i + 1] = temp;
                    break;
                }
                //for文が全て実行されたときは配列の先頭の項目とする。
                if (i == 0)
                    array[0] = temp;
            }

        }
    }
}
