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

        static internal void bubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                modifyOrder(array, i);
            }
        }

        static void modifyOrder(int[] array, int endIndex)
        {
            for (int i = array.Length - 2; i > endIndex; i--)
            {
                if (array[i - 1] > array[i])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                }
            }
        }

        static internal int bubbleSortReviced(int[] array)
        {
            int retVal = -1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                retVal = modifyOrderRevision(array, i);
                //変換処理が行われなかったときは、すでに昇順になっていると考えて処理を終了する。
                if (retVal == 0)
                    break;
            }
            return retVal;
        }

        static int modifyOrderRevision(int[] array, int endIndex)
        {
            int exchange = 0;
            for (int i = array.Length - 1; i > endIndex; i--)
            {
                if (array[i - 1] > array[i])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    exchange += 1;
                }
            }
            return exchange;
        }

        internal static int fib(int n)
        {
            if (n < 2)
                return n;
            else
            {
                int a = fib(n - 1);
                int b = fib(n - 2);
                int c = a + b;
                return c;
            }
        }
    }
}