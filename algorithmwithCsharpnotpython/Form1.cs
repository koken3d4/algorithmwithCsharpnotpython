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

        }
    }
}
