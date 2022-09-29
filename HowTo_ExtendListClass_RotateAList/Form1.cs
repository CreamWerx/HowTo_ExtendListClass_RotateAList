using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowTo_ExtendListClass_RotateAList
{
    public partial class Form1 : Form
    {
        BindingList<string> theList;
        public Form1()
        {
            InitializeComponent();
            theList = new BindingList<string>();
            listBox1.DataSource = theList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                theList.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newFirst = theList.Rotate();
            label1.Text = newFirst;
        }
    }

    public static class ListExtensions
    {
        public static string Rotate(this BindingList<string> list)
        {
            string first = list[0];
            list.RemoveAt(0);
            list.Add(first);
            return list[0];
        }
    }
}
