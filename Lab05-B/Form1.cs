using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab05_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string dateOfBirth = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            string emailAddress = txtEmailAddress.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty (username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please Fill All Fields!", "ErrorMessage" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!firstName.All(char.IsLetterOrDigit) || !lastName.All(char.IsLetterOrDigit) || !emailAddress.All(char.IsLetterOrDigit) || !username.All(char.IsLetterOrDigit) || !password.All(char.IsLetterOrDigit))
                {
                    MessageBox.Show("All inputs must contain only alphanumeric characters (A-Z, a-z, 0-9).", "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (password.Equals(confirmPassword))
                    {
                        User user1 = new User(firstName,lastName,dateOfBirth,emailAddress,username,password);
                        Form2 form2 = new Form2(user1);
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password should match.", "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Now;
            txtEmailAddress.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;


        }
    }
}
