using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProjectBD
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
            errorLabel.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tboxUsername.Text) || String.IsNullOrEmpty(tboxPassword.Text))
            {
                errorLabel.Visible = true;
                return;
            }

            if (tboxUsername.Text == "paul" && tboxPassword.Text == "database")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                errorLabel.Visible = true;
            }
            

        }
        private void tboxUsername_Validating(object sender, CancelEventArgs e)
        {
            errorLabel.Visible = false;
            if (String.IsNullOrEmpty(tboxUsername.Text))
            {
                errorProvider1.SetError(tboxUsername, "Nu poate fi gol!");
            }
            else
            {
                errorProvider1.SetError(tboxUsername, "");
            }
        }

        private void tboxPassword_Validating(object sender, CancelEventArgs e)
        {
            errorLabel.Visible = false;
            if (String.IsNullOrEmpty(tboxUsername.Text))
            {
                errorProvider2.SetError(tboxUsername, "Nu poate fi gol!");
            }
            else
            {
                errorProvider2.SetError(tboxUsername, "");
            }
        }
    }
}
