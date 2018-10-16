using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEvents
{
    public partial class Form1 : Form
    {
        MyClass inst = null;

        public Form1()
        {
            InitializeComponent();
            inst = new MyClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inst.MyEvent += Handler1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inst.MyEvent -= Handler1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inst.MyEvent += Handler2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inst.MyEvent -= Handler2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inst.MyEvent += delegate { richTextBox1.Text += "Анонимный метод 1."; };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inst.MyEvent -= delegate { richTextBox1.Text += "Анонимный метод 1."; };
        }

         private void Handler1()
        {
            richTextBox1.Text += ("Обработчик события 1");
        }

         private void Handler2()
        {
            richTextBox1.Text += ("Обработчик события 2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            inst.InvokeEvent();
        }
    }
}
