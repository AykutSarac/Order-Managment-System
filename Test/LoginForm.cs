using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;

            if (Username == "admin" && Password == "123")
            {
                // Open Panel
                this.Hide();
                Panel panel = new Panel();
                panel.Show();
            }
            else {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.PerformClick();
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            username.Focus();
        }
    }
}
