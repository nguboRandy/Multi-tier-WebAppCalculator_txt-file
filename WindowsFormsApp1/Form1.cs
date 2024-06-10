using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string btn_operator = "";
        private string calculation_string = "";
        private readonly BusinessClass BusinessInstance = new BusinessClass();
        public Form1()
        {
            InitializeComponent();
        }

        //Multiply button
        private void button13_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += " * ";
            btn_operator = "*";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "9";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += "0";

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += " + ";
            btn_operator = "+";

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += " - ";
            btn_operator = "-";

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            ResultTxt.Text += " / ";
            btn_operator = " / ";

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ResultTxt.Text = "";
            

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string inputString = ResultTxt.Text;
            string num1;
            string num2;
            double result;
            int operator_index;

            try
            {
                switch (btn_operator)
                {
                    case "+":
                        operator_index = inputString.IndexOf("+");
                        num1 = inputString.Substring(0, operator_index).Trim();
                        num2 = inputString.Substring(operator_index + 1).Trim();
                        result = BusinessInstance.Add(double.Parse(num1), double.Parse(num2));
                        calculation_string = $"{inputString} = {result}";
                        ResultTxt.Text = $"{inputString} = {result}";
                        break;
                    case "-":
                        operator_index = inputString.IndexOf("-");
                        num1 = inputString.Substring(0, operator_index).Trim();
                        num2 = inputString.Substring(operator_index + 1).Trim();
                        result = BusinessInstance.Subtract(double.Parse(num1), double.Parse(num2));
                        calculation_string = $"{inputString} = {result}";
                        ResultTxt.Text = $"{inputString} = {result}";
                        break;
                    case "*":
                        operator_index = inputString.IndexOf("*");
                        num1 = inputString.Substring(0, operator_index).Trim();
                        num2 = inputString.Substring(operator_index + 1).Trim();
                        result = BusinessInstance.Multiply(double.Parse(num1), double.Parse(num2));
                        calculation_string = $"{inputString} = {result}";
                        ResultTxt.Text = $"{inputString} = {result}";
                        break;
                    case "/":
                        operator_index = inputString.IndexOf("/");
                        num1 = inputString.Substring(0, operator_index).Trim();
                        num2 = inputString.Substring(operator_index + 1).Trim();
                        result = BusinessInstance.Divide(double.Parse(num1), double.Parse(num2));
                        calculation_string = $"{inputString} = {result}";
                        ResultTxt.Text = $"{inputString} = {result}";
                        break;
                    default:
                        break;
                }

                BusinessInstance.SaveToFile(calculation_string);
                MessageBox.Show("Saved to file");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show("An error occurred during calculation or saving.");
            }
        }

        private static void ResultTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CEbutton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
