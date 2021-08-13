using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using OrderMS;

namespace Test

{
    public partial class AddOrder : Form
    {
        Panel panel;
        bool newOrder = true;
        string id;


        public AddOrder(Panel panel)
        {
            InitializeComponent();

            OrderState.SelectedIndex = 0;
            this.panel = panel;
            this.newOrder = true;

            this.deleteOrder.Visible = false;
            this.tableLayoutPanel3.ColumnCount = 1;
        }

        public AddOrder(string id, Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.newOrder = false;
            this.id = id;
            this.Text = "Sipariş (No: " + id + ")";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
            {
                connection.Open();

                string query = "SELECT * FROM tblOrder WHERE Id = " + id;
                SQLiteCommand action = new SQLiteCommand(query, connection);
                action.ExecuteNonQuery();
                SQLiteDataReader data = action.ExecuteReader();

                if (data.Read())
                {
                    CustomerNameInput.Text = data["Customer"].ToString();
                    OrderInput.Text = data["OrderDetails"].ToString();
                    NotesInput.Text = data["Notes"].ToString();
                    AddressInput.Text = data["Address"].ToString();
                    OrderState.SelectedIndex = Int32.Parse(data["State"].ToString());
                }

                data.Close();
                connection.Close();
            }
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {

            try
            {
                Crud.AddOrder(this.newOrder, CustomerNameInput.Text, OrderInput.Text, AddressInput.Text, NotesInput.Text, price.Text, OrderState.SelectedIndex, this.id);

                this.panel.UpdateTable();
                this.panel.Focus();
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("İşlem gerçekleştirilirken bir hata meydana geldi!\n" + error.ToString());
            }

        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Crud.DeleteOrder(this.id);

                MessageBox.Show("Sipariş Silindi!");
                this.panel.UpdateTable();
                this.panel.Focus();
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("İşlem gerçekleştirilirken bir hata meydana geldi!\n" + error.ToString());
            }
        }
    }
}
