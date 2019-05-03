using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithmwithCsharpnotpython
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool checkTextBox(string inputText, ref int retInt)
        {
            //数値が変換できたときはTRUEを返す。変換できないときはFALSEを返す。
            if (int.TryParse(inputText, out retInt))
                return true;
            else
            {
                MessageBox.Show("数値を入力して下さい");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //適当な配列作成のため
            List<int> testList = new List<int>() { 4, 5, 6, 7, 2, 4, 10 };
            var array = testList.ToArray();
            sort newsort = new sort();
            newsort.sortStart(array);

            foreach (var i in array)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> testList = new List<int>() { 4, 5, 6, 7, 2, 4, 10 };
            var array = testList.ToArray();
            sort.insertionSort(array);

            foreach (var i in array)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> testList = new List<int>() { 4, 5, 6, 7, 2, 4, 10 };
            var array = testList.ToArray();
            sort.bubbleSort(array);

            foreach (var i in array)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> testList = new List<int>() { 4, 5, 6, 7, 2, 4, 10 };
            var array = testList.ToArray();
            var s = sort.bubbleSortReviced(array);

            foreach (var i in array)
            {
                listBox1.Items.Add(i.ToString());
            }
            listBox1.Items.Add(s.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (!checkTextBox(textBox1.Text, ref number))
                return;

            listBox1.Items.Clear();
            List<int> testList = new List<int>() { 4, 5, 6, 7, 2, 4, 10 };
            var array = testList.ToArray();
            var s = sort.fib(number);

            listBox1.Items.Add(s.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (!checkTextBox(textBox1.Text, ref number))
                return;

            listBox1.Items.Clear();
            var s = sort.fib_List(number);

            listBox1.Items.Add(s.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (!checkTextBox(textBox1.Text, ref number))
                return;

            listBox1.Items.Clear();

            List<string> commentList = new List<string>();
            sort.hanoi(number, commentList);

            foreach (var str in commentList)
            { listBox1.Items.Add(str); }
            //listBox1.Items.Add(s.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ヒープソート用に改造する。
            //int number = 0;
            //if (!checkTextBox(textBox1.Text, ref number))
            //    return;
            //テストリストの中をヒープソートする。
            listBox1.Items.Clear();
            List<int> testList = new List<int>() { 4, 5, 6, 7, 2, 4, 10 };
            List<string> commentList = new List<string>();
            sort.heapSort(testList.ToArray());

            foreach (var str in commentList)
            { listBox1.Items.Add(str); }
            //listBox1.Items.Add(s.ToString());
        }
    }
}
