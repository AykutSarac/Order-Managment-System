
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
            this.OrderInput = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.OrderState = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NotesInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerNameInput
            // 
            this.CustomerNameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerNameInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerNameInput.Location = new System.Drawing.Point(19, 56);
            this.CustomerNameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerNameInput.Name = "CustomerNameInput";
            this.CustomerNameInput.PlaceholderText = "Ad Soyad";
            this.CustomerNameInput.Size = new System.Drawing.Size(456, 37);
            this.CustomerNameInput.TabIndex = 0;
            // 
            // OrderInput
            // 
            this.OrderInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.OrderInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderInput.FormattingEnabled = true;
            this.OrderInput.Items.AddRange(new object[] {
            "İskender",
            "Döner",
            "Köfte Ekmek",
            "Pide"});
            this.OrderInput.Location = new System.Drawing.Point(4, 5);
            this.OrderInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderInput.Name = "OrderInput";
            this.OrderInput.Size = new System.Drawing.Size(373, 44);
            this.OrderInput.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(385, 5);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 45);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sipariş *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alıcı *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres *";
            // 
            // AddressInput
            // 
            this.AddressInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressInput.Location = new System.Drawing.Point(19, 159);
            this.AddressInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressInput.Multiline = true;
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.PlaceholderText = "Adres";
            this.AddressInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressInput.Size = new System.Drawing.Size(456, 134);
            this.AddressInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Durum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ücret";
            // 
            // price
            // 
            this.price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price.Enabled = false;
            this.price.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(483, 339);
            this.price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(457, 45);
            this.price.TabIndex = 9;
            this.price.Text = "0 TL";
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addOrderBtn.Location = new System.Drawing.Point(0, 401);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(959, 41);
            this.addOrderBtn.TabIndex = 11;
            this.addOrderBtn.Text = "Ekle / Güncelle";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
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
            "İptal"});
            this.OrderState.Location = new System.Drawing.Point(19, 339);
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
            this.tableLayoutPanel1.Controls.Add(this.NotesInput, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CustomerNameInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddressInput, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.price, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.OrderState, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 401);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // NotesInput
            // 
            this.NotesInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotesInput.Location = new System.Drawing.Point(483, 159);
            this.NotesInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NotesInput.Multiline = true;
            this.NotesInput.Name = "NotesInput";
            this.NotesInput.PlaceholderText = "Not Ekle";
            this.NotesInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesInput.Size = new System.Drawing.Size(457, 134);
            this.NotesInput.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 36);
            this.label6.TabIndex = 14;
            this.label6.Text = "Notlar";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.12236F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.87764F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.OrderInput, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(482, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 61);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // AddOrder
            // 
            this.AcceptButton = this.addOrderBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addOrderBtn);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerNameInput;
        private System.Windows.Forms.ComboBox OrderInput;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.ComboBox OrderState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox NotesInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}