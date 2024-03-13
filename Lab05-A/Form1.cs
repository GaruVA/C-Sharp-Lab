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

namespace Lab05_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int num1 = 0;
        private int num2 = 0;
        private int op;

        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = int.Parse(txtNum.Text);
                op = 1;
                lblResult.Text = $"{num1} +";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! {ex}", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            txtNum.Text = "0";
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = int.Parse(txtNum.Text);
                op = 2;
                lblResult.Text = $"{num1} -";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! {ex}", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            txtNum.Text = "0";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = int.Parse(txtNum.Text);
                op = 3;
                lblResult.Text = $"{num1} ×";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! {ex}", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            txtNum.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = int.Parse(txtNum.Text);
                op = 4;
                lblResult.Text = $"{num1} ÷";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! {ex}", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            txtNum.Text = "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = int.Parse(txtNum.Text);
                switch (op)
                {
                    case 1:
                        lblExpression.Text = $"{num1} + {num2} = ";
                        lblResult.Text = $"{num1 + num2}";
                        num1 = 0;
                        num2 = 0;
                        break;
                    case 2:
                        lblExpression.Text = $"{num1} - {num2} = ";
                        lblResult.Text = $"{num1 - num2}";
                        num1 = 0;
                        num2 = 0;
                        break;
                    case 3:
                        lblExpression.Text = $"{num1} × {num2} = ";
                        lblResult.Text = $"{num1 * num2}";
                        num1 = 0;
                        num2 = 0;
                        break;
                    case 4:
                        try
                        {
                            lblExpression.Text = $"{num1} ÷ {num2} = ";
                            lblResult.Text = $"{num1 / num2}";
                            num1 = 0;
                            num2 = 0;
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error! {ex}", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! {ex}", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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

