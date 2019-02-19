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
        private int upper = 0;
        private int lower = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void text_Change()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1
            if (upper == 0)
                upper = 1;
            else
                upper = upper * 10 + 1;
            text_Change();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 2
            if (upper == 0)
                upper = 2;
            else
                upper = upper * 10 + 2;
            text_Change();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 3
            if (upper == 0)
                upper = 3;
            else
                upper = upper * 10 + 3;
            text_Change();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 4
            if (upper == 0)
                upper = 4;
            else
                upper = upper * 10 + 4;
            text_Change();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 5
            if (upper == 0)
                upper = 5;
            else
                upper = upper * 10 + 5;
            text_Change();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 6
            if (upper == 0)
                upper = 6;
            else
                upper = upper * 10 + 6;
            text_Change();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 7
            if (upper == 0)
                upper = 7;
            else
                upper = upper * 10 + 7;
            text_Change();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 8
            if (upper == 0)
                upper = 8;
            else
                upper = upper * 10 + 8;
            text_Change();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 9
            if (upper == 0)
                upper = 9;
            else
                upper = upper * 10 + 9;
            text_Change();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 0
            if (upper != 0)
                upper *= 10;
            text_Change();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // .

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
