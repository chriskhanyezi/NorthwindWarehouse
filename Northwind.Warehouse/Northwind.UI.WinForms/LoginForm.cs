using Northwind.Business.Logic.Security;
using System;
using System.Windows.Forms;

namespace Northwind.UI.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            using (StatusBusy busy = new StatusBusy("Verifying credentials..."))
            {
                if (PTPrincipal.Login(this.UsernameTextBox.Text, this.PasswordTextBox.Text))
                {
                    this.Close();
                }
                else 
                { 
                  MessageBox.Show("Username does not match password, invalid username or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.UsernameTextBox.Focus();
        }
    }
}