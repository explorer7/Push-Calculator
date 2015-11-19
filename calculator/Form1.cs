using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public static decimal next = 0, previous = 0;
        public static char lastOp = '0';
        public static StringBuilder primString = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            primString.Append('1');
            primary.Text = primString.ToString();
        }

        private void two_Click(object sender, EventArgs e)
        {
            primString.Append('2');
            primary.Text = primString.ToString();
        }

        private void three_Click(object sender, EventArgs e)
        {
            primString.Append('3');
            primary.Text = primString.ToString();
        }

        private void four_Click(object sender, EventArgs e)
        {
            primString.Append('4');
            primary.Text = primString.ToString();
        }

        private void five_Click(object sender, EventArgs e)
        {
            primString.Append('5');
            primary.Text = primString.ToString();
        }

        private void six_Click(object sender, EventArgs e)
        {
            primString.Append('6');
            primary.Text = primString.ToString();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            primString.Append('7');
            primary.Text = primString.ToString();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            primString.Append('8');
            primary.Text = primString.ToString();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            primString.Append('9');
            primary.Text = primString.ToString();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            primString.Append('0');
            primary.Text = primString.ToString();
        }

        private void dec_Click(object sender, EventArgs e)
        {
            primString.Append('.');
            primary.Text = primString.ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (primString.ToString() != "")
            {
                next = Convert.ToDecimal(primString.ToString());
                secondary.Text += Convert.ToString(next) + " + ";
                operate();
                lastOp = '+';
                primary.Text = "0";
                primString.Clear();
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (primString.ToString() != "")
            {
                next = Convert.ToDecimal(primString.ToString());
                secondary.Text += Convert.ToString(next) + " - ";
                operate();
                lastOp = '-';
                primary.Text = "0";
                primString.Clear();
            }
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (primString.ToString() != "")
            {
                next = Convert.ToDecimal(primString.ToString());
                secondary.Text += Convert.ToString(next) + " x ";
                operate();
                lastOp = 'x';
                primary.Text = "0";
                primString.Clear();
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (primString.ToString() != "")
            {
                next = Convert.ToDecimal(primString.ToString());
                secondary.Text += Convert.ToString(next) + " / ";
                operate();
                lastOp = '/';
                primary.Text = "0";
                primString.Clear();
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (primString.ToString() != "")
            {
                secondary.Text = "";
                next = Convert.ToDecimal(primString.ToString());
                operate();
                lastOp = '0';
                primary.Text = Convert.ToString(previous);
                primString.Clear();
                primString.Append(previous);
                previous = 0;
            }
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            primString.Clear();
            primary.Text = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            secondary.Text = "";
            primString.Clear();
            primary.Text = "0";
            previous = 0;
        }

        private void posNeg_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(primString.ToString()) > 0) primString.Insert(0, "-");
            else primString.Remove(0, 1);
            primary.Text = primString.ToString();
        }

        public static void operate()
        {
            if (lastOp == '+') previous += next;
            else if (lastOp == '-') previous -= next;
            else if (lastOp == 'x') previous *= next;
            else if (lastOp == '/') previous /= next;
            else if (lastOp == '0') previous = next;
        }
    }
}

