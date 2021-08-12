using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

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
        }

        public AddOrder(string id, Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.newOrder = false;
            this.id = id;

            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();

            this.Text = "Sipariş (No: " + id + ")";

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

            connection.Close();
            panel.UpdateTable();
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();

            if (newOrder)
            {
                string action = "INSERT INTO tblOrder(Customer, OrderDetails, Address, Notes, Payment, State) values(@Customer, @OrderDetails, @Address, @Notes, @Payment, @State)";

                SQLiteCommand actionRun = new SQLiteCommand(action, connection);
                actionRun.Parameters.AddWithValue("@Customer", CustomerNameInput.Text);
                actionRun.Parameters.AddWithValue("@OrderDetails", OrderInput.Text);
                actionRun.Parameters.AddWithValue("@Address", AddressInput.Text);
                actionRun.Parameters.AddWithValue("@Notes", NotesInput.Text);
                actionRun.Parameters.AddWithValue("@Payment", price.Text);
                actionRun.Parameters.AddWithValue("@State", OrderState.SelectedIndex);

                actionRun.ExecuteNonQuery();
                actionRun.Dispose();
                MessageBox.Show("Sipariş Başarıyla Eklendi");
            } else {
                string action = "UPDATE tblOrder SET Customer = @Customer, OrderDetails = @OrderDetails, Address = @Address, Notes = @Notes, Payment = @Payment, State = @State WHERE Id = " + this.id;
                MessageBox.Show("Sipariş Başarıyla Güncellendi");

                SQLiteCommand actionRun = new SQLiteCommand(action, connection);
                actionRun.Parameters.AddWithValue("@Customer", CustomerNameInput.Text);
                actionRun.Parameters.AddWithValue("@OrderDetails", OrderInput.Text);
                actionRun.Parameters.AddWithValue("@Address", AddressInput.Text);
                actionRun.Parameters.AddWithValue("@Notes", NotesInput.Text);
                actionRun.Parameters.AddWithValue("@Payment", price.Text);
                actionRun.Parameters.AddWithValue("@State", OrderState.SelectedIndex);

                actionRun.ExecuteNonQuery();
                actionRun.Dispose();
            }

            
            connection.Close();
            panel.UpdateTable();
            this.panel.Focus();
            this.Close();
        }
    }
}
