using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
            TotalNumber = string.Empty;
            Operation = string.Empty;
        }

        string TotalNumber;
        int Num1;
        int Num2;
        string Operation;
        int result;

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "1";
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "2";
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "3";
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "4";
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "5";
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "6";
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "7";
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "8";
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "9";
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = txtbx_screen.Text + "0";
        }
        private void btn_plus_Click(object sender, EventArgs e)
        {
            Operation = "+";
            Num1 = Convert.ToInt32(txtbx_screen.Text);
            txtbx_screen.Text = string.Empty;
        }
        private void btn_minus_Click(object sender, EventArgs e)
        {
            Operation = "-";
            Num1 = Convert.ToInt32(txtbx_screen.Text);
            txtbx_screen.Text = string.Empty;
        }
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            Operation = "*";
            Num1 = Convert.ToInt32(txtbx_screen.Text);
            txtbx_screen.Text = string.Empty;
        }
        private void btn_divide_Click(object sender, EventArgs e)
        {
            Operation = "/";
            Num1 = Convert.ToInt32(txtbx_screen.Text);
            txtbx_screen.Text = string.Empty;
        }
        private void btn_equals_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToInt32(txtbx_screen.Text);
            if (Operation == "+")
            {
                result = Num1 + Num2;
                txtbx_screen.Text = result.ToString();
            }
            else if (Operation == "-")
            {
                result = Num1 - Num2;
                txtbx_screen.Text = result.ToString();
            }
            else if (Operation == "*")
            {
                result = Num1 * Num2;
                txtbx_screen.Text = result.ToString();
            }
            else if (Operation == "/")
            {
                result = Num1 / Num2;
                txtbx_screen.Text = result.ToString();
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbx_screen.Text = string.Empty;
        }
    }
}
