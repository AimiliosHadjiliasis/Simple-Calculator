using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Varaibles:
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        bool isEqualPerformed = false;
        bool isOneOverXPerformed = false;
        bool isSquarePerformed = false;
        bool isSquareRootPerformed = false;
        bool isCosPerformed = false;
        bool isSinPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            //Function that gets the button that we click
            if (isEqualPerformed || isSinPerformed || isCosPerformed 
                || isOneOverXPerformed || isSquarePerformed || isSquareRootPerformed)
            {
                //Set everything to false for optimaization of use 
                TextBox_Result.Text = "";
                resultValue = 0;
                isEqualPerformed = false;
                isSinPerformed = false;
                isCosPerformed = false;
                isOneOverXPerformed = false;
                isSquarePerformed = false;
                isSquareRootPerformed = false;
            }

            if ((TextBox_Result.Text == "0") || isOperationPerformed)
                TextBox_Result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            //Take care of point (.)
            if(button.Text == ".")
            {
                if(!TextBox_Result.Text.Contains("."))
                    TextBox_Result.Text = TextBox_Result.Text + button.Text;
            }
            else
            TextBox_Result.Text = TextBox_Result.Text + button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            //  Happens when we press an operator button
            //  operators: /*-+
            Button button = (Button)sender;

            if(resultValue!=0)
            {
                //clean the screen and print rV in laber
                Button_Equals.PerformClick();
                operationPerformed = button.Text;
                LabelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(TextBox_Result.Text);
                LabelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void Button_CE_Click(object sender, EventArgs e)
        {
            //CE Button set to 0
            TextBox_Result.Text = "0";
        }

        private void Button_C_Click(object sender, EventArgs e)
        {
            TextBox_Result.Text = "0";
            resultValue = 0;
            LabelCurrentOperation.Text = " ";
        }

        private void Button_Equals_Click(object sender, EventArgs e)
        {
            //Button that selects the operation that is going to happen if 
            //we press the equal button

            switch (operationPerformed)
            {
                case "+":
                    TextBox_Result.Text= (resultValue + double.Parse(TextBox_Result.Text)).ToString();
                    break;
                case "-":
                    TextBox_Result.Text = (resultValue - double.Parse(TextBox_Result.Text)).ToString();
                    break;
                case "*":
                    TextBox_Result.Text = (resultValue * double.Parse(TextBox_Result.Text)).ToString();
                    break;
                case "/":
                    TextBox_Result.Text = (resultValue / double.Parse(TextBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(TextBox_Result.Text);
            LabelCurrentOperation.Text = "";

            isEqualPerformed = true;
        }

        private void ButtonOneOverX_Click(object sender, EventArgs e)
        {
            //Button that calculates the 1 over numeber
            Button button = (Button)sender;
            resultValue = double.Parse(TextBox_Result.Text);
            double res = 1 / resultValue;
            TextBox_Result.Text = res.ToString();
            isOneOverXPerformed = true;
        }

        private void ButtonXSquare_Click(object sender, EventArgs e)
        {
            //Button that calculates the square of a numeber
            Button button = (Button)sender;
            resultValue = double.Parse(TextBox_Result.Text);
            double res = resultValue * resultValue;
            TextBox_Result.Text = res.ToString();
            isSquarePerformed = true;
        }

        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            //  Button that calculates the square root of a number
            Button button = (Button)sender;
            resultValue = double.Parse(TextBox_Result.Text);
            double res = Math.Sqrt(resultValue);
            TextBox_Result.Text = res.ToString();
            isSquareRootPerformed = true;
        }

        private void ButtonSin_Click(object sender, EventArgs e)
        {
            //  Button thatcalculates the sin function
            Button button = (Button)sender;
            resultValue = double.Parse(TextBox_Result.Text);
            double res = (resultValue * (Math.PI)) / 180;
            TextBox_Result.Text = Math.Sin(res).ToString();
            isSinPerformed = true;
        }

        private void ButtonCos_Click(object sender, EventArgs e)
        {
            //  Button thatcalculates the cos function
            Button button = (Button)sender;
            resultValue = double.Parse(TextBox_Result.Text);
            double res = (resultValue * (Math.PI)) / 180;
            TextBox_Result.Text = Math.Cos(res).ToString();
            isCosPerformed = true;
        }
    }
}
