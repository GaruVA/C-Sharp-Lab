using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_B
{
    public partial class Form2 : Form
    {
        public Form2(User user)
        {
            InitializeComponent();

            lblFirstName.Text = user.FirstName;
            lblLastName.Text = user.LastName;
            lblDateOfBirth.Text = user.DateOfBirth;
            lblEmailAddress.Text = user.EmailAddress;
            lblUsername.Text = user.Username;
        }
    }
}
