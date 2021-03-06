
namespace Test
{
    partial class AddOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.CustomerNameInput = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.AddressInput = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.OrderState = new System.Windows.Forms.ComboBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.OrderInput = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.NotesInput = new System.Windows.Forms.TextBox();
      this.PriceInput = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.addOrderBtn = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.deleteOrder = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PriceInput)).BeginInit();
      this.panel1.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // CustomerNameInput
      // 
      this.CustomerNameInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CustomerNameInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.CustomerNameInput.Location = new System.Drawing.Point(19, 46);
      this.CustomerNameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.CustomerNameInput.Multiline = true;
      this.CustomerNameInput.Name = "CustomerNameInput";
      this.CustomerNameInput.PlaceholderText = "Ad Soyad";
      this.CustomerNameInput.Size = new System.Drawing.Size(456, 46);
      this.CustomerNameInput.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(482, 97);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 31);
      this.label1.TabIndex = 3;
      this.label1.Text = "Sipariş *";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(18, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(458, 26);
      this.label2.TabIndex = 4;
      this.label2.Text = "Alıcı *";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 97);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 31);
      this.label3.TabIndex = 6;
      this.label3.Text = "Adres *";
      // 
      // AddressInput
      // 
      this.AddressInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AddressInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.AddressInput.Location = new System.Drawing.Point(19, 133);
      this.AddressInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.AddressInput.Multiline = true;
      this.AddressInput.Name = "AddressInput";
      this.AddressInput.PlaceholderText = "Adres";
      this.AddressInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.AddressInput.Size = new System.Drawing.Size(456, 114);
      this.AddressInput.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(18, 252);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(83, 36);
      this.label4.TabIndex = 8;
      this.label4.Text = "Durum";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(482, 252);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(82, 36);
      this.label5.TabIndex = 10;
      this.label5.Text = "Ücret *";
      // 
      // OrderState
      // 
      this.OrderState.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OrderState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.OrderState.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.OrderState.Items.AddRange(new object[] {
            "Sipariş Alındı",
            "Hazırlanıyor",
            "Yolda",
            "Teslim Edildi",
            "İptal"});
      this.OrderState.Location = new System.Drawing.Point(19, 293);
      this.OrderState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.OrderState.Name = "OrderState";
      this.OrderState.Size = new System.Drawing.Size(456, 44);
      this.OrderState.TabIndex = 12;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.OrderInput, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.CustomerNameInput, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.AddressInput, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.OrderState, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.PriceInput, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
      this.tableLayoutPanel1.RowCount = 6;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.101851F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.05202F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.537572F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.57225F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98266F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18497F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 360);
      this.tableLayoutPanel1.TabIndex = 13;
      // 
      // OrderInput
      // 
      this.OrderInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OrderInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.OrderInput.Location = new System.Drawing.Point(483, 133);
      this.OrderInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.OrderInput.Multiline = true;
      this.OrderInput.Name = "OrderInput";
      this.OrderInput.PlaceholderText = "Sipariş";
      this.OrderInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.OrderInput.Size = new System.Drawing.Size(457, 114);
      this.OrderInput.TabIndex = 14;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.12236F));
      this.tableLayoutPanel2.Controls.Add(this.NotesInput, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(482, 44);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 50);
      this.tableLayoutPanel2.TabIndex = 11;
      // 
      // NotesInput
      // 
      this.NotesInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.NotesInput.Location = new System.Drawing.Point(3, 3);
      this.NotesInput.Multiline = true;
      this.NotesInput.Name = "NotesInput";
      this.NotesInput.PlaceholderText = "Sipariş Notları";
      this.NotesInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.NotesInput.Size = new System.Drawing.Size(453, 44);
      this.NotesInput.TabIndex = 0;
      // 
      // PriceInput
      // 
      this.PriceInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PriceInput.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PriceInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.PriceInput.Location = new System.Drawing.Point(482, 291);
      this.PriceInput.Name = "PriceInput";
      this.PriceInput.Size = new System.Drawing.Size(459, 45);
      this.PriceInput.TabIndex = 15;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(482, 15);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(75, 26);
      this.label6.TabIndex = 14;
      this.label6.Text = "Notlar";
      // 
      // addOrderBtn
      // 
      this.addOrderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addOrderBtn.Location = new System.Drawing.Point(3, 3);
      this.addOrderBtn.Name = "addOrderBtn";
      this.addOrderBtn.Size = new System.Drawing.Size(805, 51);
      this.addOrderBtn.TabIndex = 11;
      this.addOrderBtn.Text = "Ekle / Güncelle";
      this.addOrderBtn.UseVisualStyleBackColor = true;
      this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.tableLayoutPanel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 360);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(959, 57);
      this.panel1.TabIndex = 14;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.56726F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.43274F));
      this.tableLayoutPanel3.Controls.Add(this.addOrderBtn, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.deleteOrder, 1, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(959, 57);
      this.tableLayoutPanel3.TabIndex = 0;
      // 
      // deleteOrder
      // 
      this.deleteOrder.Dock = System.Windows.Forms.DockStyle.Fill;
      this.deleteOrder.Location = new System.Drawing.Point(814, 3);
      this.deleteOrder.Name = "deleteOrder";
      this.deleteOrder.Size = new System.Drawing.Size(142, 51);
      this.deleteOrder.TabIndex = 12;
      this.deleteOrder.Text = "Sil";
      this.deleteOrder.UseVisualStyleBackColor = true;
      this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
      // 
      // AddOrder
      // 
      this.AcceptButton = this.addOrderBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(959, 417);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "AddOrder";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sipariş";
      this.TopMost = true;
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PriceInput)).EndInit();
      this.panel1.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OrderState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox OrderInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button deleteOrder;
    private System.Windows.Forms.TextBox NotesInput;
    private System.Windows.Forms.NumericUpDown PriceInput;
  }
}