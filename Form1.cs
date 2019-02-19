using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Простой_Калькулятор
{
    public partial class Form1 : Form
    {
        private string upper = "0";
        private string lower;
        private int temp;
        private int shift = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void text_Change()
        {
            label1.Text = upper.ToString();
        }

        private void increment(int el)
        {
            if (upper == "0")
                upper = el.ToString();
            else
                upper += el.ToString();
            text_Change();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1
            increment(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 2
            increment(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 3
            increment(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 4
            increment(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 5
            increment(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 6
            increment(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 7
            increment(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 8
            increment(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 9
            increment(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 0
            increment(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // .
            if (upper.IndexOf(',') != -1)
                upper += ',';
            text_Change();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // +

        }

        private void button13_Click(object sender, EventArgs e)
        {
            // -

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // *

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // /

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // =

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // %

        }

        private void button18_Click(object sender, EventArgs e)
        {
            // +/-

        }

        private void button19_Click(object sender, EventArgs e)
        {
            // AC / C
            upper = 0;
            text_Change();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
