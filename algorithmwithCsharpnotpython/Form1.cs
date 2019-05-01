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
            if (!int.TryParse(textBox1.Text, out number))
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
            if (!int.TryParse(textBox1.Text, out number))
                return;

            listBox1.Items.Clear();
            List<int> testList = new List<int>() { 4, 5, 6, 7, 2, 4, 10 };
            var array = testList.ToArray();
            var s = sort.fib_List(number);

            listBox1.Items.Add(s.ToString());
        }
    }
}
