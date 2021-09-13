
namespace Test
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.login = new System.Windows.Forms.Button();
      this.username = new System.Windows.Forms.TextBox();
      this.password = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // login
      // 
      this.login.BackColor = System.Drawing.Color.CornflowerBlue;
      this.login.Cursor = System.Windows.Forms.Cursors.Default;
      this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.login.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.login.ForeColor = System.Drawing.Color.White;
      this.login.Location = new System.Drawing.Point(118, 411);
      this.login.Name = "login";
      this.login.Size = new System.Drawing.Size(288, 48);
      this.login.TabIndex = 0;
      this.login.Text = "Giriş Yap";
      this.login.UseVisualStyleBackColor = false;
      this.login.Click += new System.EventHandler(this.login_Click);
      // 
      // username
      // 
      this.username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.username.Location = new System.Drawing.Point(118, 237);
      this.username.Name = "username";
      this.username.PlaceholderText = "Kullanıcı Adı";
      this.username.Size = new System.Drawing.Size(288, 39);
      this.username.TabIndex = 2;
      this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
      // 
      // password
      // 
      this.password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.password.Location = new System.Drawing.Point(118, 307);
      this.password.Name = "password";
      this.password.PasswordChar = '*';
      this.password.PlaceholderText = "Şifre";
      this.password.Size = new System.Drawing.Size(288, 39);
      this.password.TabIndex = 3;
      this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::OrderMS.Properties.Resources.icons8_lock_96;
      this.pictureBox1.Location = new System.Drawing.Point(214, 76);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(96, 96);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Controls.Add(this.password);
      this.panel1.Controls.Add(this.login);
      this.panel1.Controls.Add(this.username);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(518, 578);
      this.panel1.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Poppins Medium", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.Coral;
      this.label2.Location = new System.Drawing.Point(87, 187);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(351, 37);
      this.label2.TabIndex = 6;
      this.label2.Text = "Sipariş Yönetim Otomasyonu";
      // 
      // label1
      // 
      this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label1.Location = new System.Drawing.Point(37, 484);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(451, 54);
      this.label1.TabIndex = 5;
      this.label1.Text = "Sipariş Yönetim Sistemini kullanmak için giriş yapmalısınız. Eğer bir hesabınız b" +
    "ulunmuyorsa bir yöneticiye ulaşın.";
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(518, 578);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sipariş Yönetim Otomasyonu";
      this.TopMost = true;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
      this.Shown += new System.EventHandler(this.Login_Shown);
      this.Enter += new System.EventHandler(this.login_Click);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

