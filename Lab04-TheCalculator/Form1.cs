using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04_TheCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int num1=0;
        private int num2=0;
        private int op;

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if(ValidateNumber(txtNum.Text))
            {
                num1 = int.Parse(txtNum.Text);
                op = 1;
                lblResult.Text = $"{num1} +";
            }
            else
            {
                MessageBox.Show("Invalid Value!");
            }
            txtNum.Text = "0";
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            if (ValidateNumber(txtNum.Text))
            {
                num1 = int.Parse(txtNum.Text);
                op = 2;
                lblResult.Text = $"{num1} -";
            }
            else
            {
                MessageBox.Show("Invalid Value!");
            }
            txtNum.Text = "0";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (ValidateNumber(txtNum.Text))
            {
                num1 = int.Parse(txtNum.Text);
                op = 3;
                lblResult.Text = $"{num1} ×";
            }
            else
            {
                MessageBox.Show("Invalid Value!");
            }
            txtNum.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (ValidateNumber(txtNum.Text))
            {
                num1 = int.Parse(txtNum.Text);
                op = 4;
                lblResult.Text = $"{num1} ÷";
            }
            else
            {
                MessageBox.Show("Invalid Value!");
            }
            txtNum.Text = "0";
        }

        private bool ValidateNumber(string number)
        {
            int n;
            return int.TryParse(number, out n);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (ValidateNumber(txtNum.Text))
            {
                num2 = int.Parse(txtNum.Text);
                switch (op)
                {
                    case 1:
                        lblExpression.Text = $"{num1} + {num2} = ";
                        lblResult.Text = $"{num1 + num2}";
                        break;
                    case 2:
                        lblExpression.Text = $"{num1} - {num2} = ";
                        lblResult.Text = $"{num1 - num2}";
                        break;
                    case 3:
                        lblExpression.Text = $"{num1} × {num2} = ";
                        lblResult.Text = $"{num1 * num2}";
                        break;
                    case 4:
                        if(num2 != 0)
                        {
                            lblExpression.Text = $"{num1} ÷ {num2} = ";
                            lblResult.Text = $"{num1 / num2}";
                            break;
                        }else
                        {
                            MessageBox.Show("Cannot Divide by 0!");
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Invalid Value!");
            }
            txtNum.Text = "0";
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            lblResult.Text = "0";
            lblExpression.Text = "";
            txtNum.Text = "0";
        }
    }
}
