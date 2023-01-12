
using SecurityManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.UserView
{
    public partial class FormLogin : Form
    {
        bool isOpen = true;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SignInManager.Authenticate(txt_UserName.Text.Trim(), txt_Password.Text.Trim());
            isOpen = false;
            Close();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = isOpen;
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            isOpen = false;
            Application.Exit();
        }
    }
}
