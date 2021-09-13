using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderMS;

namespace Test {
  public partial class LoginForm : Form {
    public LoginForm() {
      InitializeComponent();
    }

    private void login_Click(object sender, EventArgs e) {
      string Username = username.Text;
      string Password = password.Text;

      try {
        string result = Crud.UserLogin(Username, Password);

        if (result.Length > 0) {

          // Open Panel and hide Login Form
          this.Hide();
          Panel panel = new Panel(result);
          panel.Show();
        }
      } catch (Exception error) {
        MessageBox.Show(error.Message, "Bir hata meydana geldi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void username_KeyDown(object sender, KeyEventArgs e) {

      // Skip to Password Input on enter
      if (e.KeyCode == Keys.Enter) {
        password.Focus();
      }
    }

    private void password_KeyDown(object sender, KeyEventArgs e) {

      // Submit on enter
      if (e.KeyCode == Keys.Enter) {
        login.PerformClick();
      }
    }

    private void Login_Shown(object sender, EventArgs e) {
      username.Focus();
    }

    private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) {
      Application.Exit();
    }
  }
}
