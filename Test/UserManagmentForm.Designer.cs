
namespace OrderMS {
  partial class UserManagmentForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagmentForm));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.UsersTable = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.PasswordInput = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.isAdminCB = new System.Windows.Forms.CheckBox();
      this.UsernameInput = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 234F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 321);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(485, 50);
      this.label1.TabIndex = 0;
      this.label1.Text = "Kullanıcı Yönetimi";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.UsersTable);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 89);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(485, 229);
      this.panel1.TabIndex = 1;
      // 
      // UsersTable
      // 
      this.UsersTable.AllowUserToAddRows = false;
      this.UsersTable.AllowUserToDeleteRows = false;
      this.UsersTable.AllowUserToOrderColumns = true;
      this.UsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.UsersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.UsersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
      this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.UsersTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UsersTable.Location = new System.Drawing.Point(0, 0);
      this.UsersTable.Name = "UsersTable";
      this.UsersTable.ReadOnly = true;
      this.UsersTable.RowHeadersWidth = 51;
      this.UsersTable.RowTemplate.Height = 29;
      this.UsersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.UsersTable.Size = new System.Drawing.Size(485, 229);
      this.UsersTable.TabIndex = 0;
      this.UsersTable.DataSourceChanged += new System.EventHandler(this.UsersTable_DataSourceChanged);
      this.UsersTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersTable_CellMouseDoubleClick);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(494, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(406, 50);
      this.label2.TabIndex = 2;
      this.label2.Text = "Kullanıcı Ekle";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.PasswordInput);
      this.panel2.Controls.Add(this.button1);
      this.panel2.Controls.Add(this.isAdminCB);
      this.panel2.Controls.Add(this.UsernameInput);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(494, 89);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(406, 229);
      this.panel2.TabIndex = 3;
      // 
      // PasswordInput
      // 
      this.PasswordInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PasswordInput.Location = new System.Drawing.Point(21, 68);
      this.PasswordInput.Name = "PasswordInput";
      this.PasswordInput.PasswordChar = '*';
      this.PasswordInput.PlaceholderText = "Şifre";
      this.PasswordInput.Size = new System.Drawing.Size(371, 30);
      this.PasswordInput.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.button1.Location = new System.Drawing.Point(21, 165);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(164, 42);
      this.button1.TabIndex = 2;
      this.button1.Text = "Kullanıcı Ekle";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // isAdminCB
      // 
      this.isAdminCB.AutoSize = true;
      this.isAdminCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.isAdminCB.Location = new System.Drawing.Point(21, 114);
      this.isAdminCB.Name = "isAdminCB";
      this.isAdminCB.Size = new System.Drawing.Size(102, 32);
      this.isAdminCB.TabIndex = 1;
      this.isAdminCB.Text = "Yönetici";
      this.isAdminCB.UseVisualStyleBackColor = true;
      // 
      // UsernameInput
      // 
      this.UsernameInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.UsernameInput.Location = new System.Drawing.Point(21, 17);
      this.UsernameInput.Name = "UsernameInput";
      this.UsernameInput.PlaceholderText = "Kullanıcı Adı";
      this.UsernameInput.Size = new System.Drawing.Size(371, 30);
      this.UsernameInput.TabIndex = 0;
      // 
      // UserManagmentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(903, 321);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "UserManagmentForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Kullanıcı Ekle / Sil";
      this.TopMost = true;
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView UsersTable;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox PasswordInput;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox isAdminCB;
    private System.Windows.Forms.TextBox UsernameInput;
  }
}