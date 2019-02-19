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
        private string lower = "";
        private bool flag = false;
        private double temp = 0;
        private double result = 0;
        public char ev;

        public Form1()
        {
            InitializeComponent();
        }

        private void flag_check()
        {
            if (flag)
            {
                button12.BackColor = Color.FromName("Control");
                button13.BackColor = Color.FromName("Control");
                button14.BackColor = Color.FromName("Control");
                button15.BackColor = Color.FromName("Control");
                button16.BackColor = Color.FromName("Control");
                button17.BackColor = Color.FromName("Control");
            }
        }

        private void text_Change()
        {
            label1.Text = upper;
        }

        private void increment(int el)
        {
            flag_check();
            if (upper == "0")
                upper = el.ToString();
            else
                upper += el.ToString();
            text_Change();
            //if (button_name.Length != 0)
                
        }

        private double operation(double el1, double el2, char ev)
        {
            double ret = 0;
            switch (ev)
                {
                    case '+':
                        ret = el1 + el2;
                        break;
                    case '-':
                        ret = el1 - el2;
                        break;
                    case '/':
                        ret = el1 / el2;
                        break;
                    case '*':
                        ret = el1 * el2;
                        break;
                    case '%':
                        // need to add button's behavior
                        break;
                }
            return ret;
        }

        private void button_event(char ev)
        {
            if (ev == '=')
            {
                if (result != 0)
                    result = operation(result, temp, this.ev);
                result = operation(temp, double.Parse(upper), this.ev);
                label1.Text = result.ToString();
                lower = result.ToString();
                result = 0;
                temp = 0;
                upper = "0";
            }
            else if (temp == 0)
            {
                temp = double.Parse(upper);
                upper = "0";
                this.ev = ev;
            }
            else
            {
                result = operation(temp, double.Parse(upper), this.ev);
                temp = double.Parse(upper);
                this.ev = ev;
            }
            
            
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
            if (upper.IndexOf(',') == -1)
                upper += ',';
            text_Change();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // +
            button14.BackColor = Color.Gold;
            flag = true;
            button_event('+');
            /*button14.BackColor = Color.LightYellow;
            button_name = "button14";*/
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // -
            button13.BackColor = Color.Gold;
            flag = true;
            button_event('-');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // *
            button15.BackColor = Color.Gold;
            flag = true;
            button_event('*');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // /
            button16.BackColor = Color.Gold;
            flag = true;
            button_event('/');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // =
            button12.BackColor = Color.Gold;
            flag = true;
            button_event('=');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // %
            button17.BackColor = Color.Gold;
            flag = true;
            button_event('%');
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // +/-
            if (upper.IndexOf('-') == -1)
                upper = upper.Insert(0, "-");
            else
                upper = upper.TrimStart('-');
            text_Change();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // AC / C
            flag_check();
            upper = "0";
            temp = 0;
            result = 0;
            label2.Text = lower;
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
