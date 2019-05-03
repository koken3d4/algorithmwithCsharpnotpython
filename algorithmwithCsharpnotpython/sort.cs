using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

        internal static long fib_List(int index)
        {
            List<long> longList = new List<long>();
            longList.Add(0);
            longList.Add(1);

            //インデックスの境界外を防ぐためにif文で処理。
            if (index < 2)
                return longList[index];
            //indexの所で反復を終了させるとlongList[index]でエラーが出るので、プラス1する。
            for (int i = 2; i < index + 1; i++)
            {
                long addList = longList[i - 2] + longList[i - 1];
                longList.Add(addList);
            }

            return longList[index];
        }

        internal static void hanoi(int index, List<string> comment)
        {
            move(index, 1, 2, 3, comment);
        }

        static void move(int diskNumber, int start, int yobi, int end, List<string> comment)
        {
            if (diskNumber >= 2)
            {
                move(diskNumber - 1, start, end, yobi, comment);
            }
            comment.Add(diskNumber.ToString() + "のディスクについて" + start.ToString() + "軸の円盤を" + end.ToString() + "軸へ移動");
            if (diskNumber >= 2)
                move(diskNumber - 1, yobi, start, end, comment);
        }

        public static void heapSort(int[] array)
        {
            constructHeap(array, 0);
            Debug.Print(string.Join(",", array));
            for (int last = array.Length - 1; last > 0; last--)
            {
                int temp = array[0];
                array[0] = array[last ];
                array[last ] = temp;
                exchangeNodes(array, 0, last - 1);
                string str = string.Join(",", array);   //配列の各要素が","で区切られて一つの文字列として出力される。
                Debug.Print(str);
            }
        }
        
        static void constructHeap(int[] array, int n)
        {
            int lastIndex = array.Length - 1;
            if (lastIndex < left(n))
                return;

            constructHeap(array, left(2));
            if (right(n) <= lastIndex)
            {
                constructHeap(array, right(n));
            }
            exchangeNodes(array, n, lastIndex);
        }

        static void exchangeNodes(int[] array, int n, int lastIndex)
        {
            if (lastIndex < left(n))
                return;

            int child = left(n);
            if (right(n) <= lastIndex)
                if (array[left(n)] < array[right(n)])
                    child = right(n);

            if (array[n] < array[child])
            {
                int temp = array[child];
                array[child] = array[n];
                array[n] = temp;
                exchangeNodes(array, child, lastIndex);
            }
        }

        static int left(int n)
        {
            return 2 * n + 1;
        }

        static int right(int n)
        {
            return 2 * (n + 1);
        }
    }
}