using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using OrderMS;

namespace Test {
  public partial class AddOrder : Form {
    private readonly Panel panel;
    private readonly bool newOrder = true;
    private readonly string id;


    public AddOrder(Panel panel) {
      InitializeComponent();

      OrderState.SelectedIndex = 0;

      this.panel = panel;
      this.newOrder = true;
      this.deleteOrder.Visible = false;
      this.tableLayoutPanel3.ColumnCount = 1;
    }

    public AddOrder(string id, Panel panel) {
      InitializeComponent();

      // Initialize Class Values
      this.panel = panel;
      this.newOrder = false;
      this.id = id;
      this.Text = "Sipariş (No: " + id + ")";

      using SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
      connection.Open();

      string query = "SELECT * FROM tblOrder WHERE Id = " + id;
      SQLiteCommand action = new SQLiteCommand(query, connection);
      action.ExecuteNonQuery();
      SQLiteDataReader data = action.ExecuteReader();

      // Set SQL Values to Form Inputs
      if (data.Read()) {
        CustomerNameInput.Text = data["Customer"].ToString();
        OrderInput.Text = data["OrderDetails"].ToString();
        NotesInput.Text = data["Notes"].ToString();
        AddressInput.Text = data["Address"].ToString();
        PriceInput.Value = Convert.ToInt32(data["Payment"]);

        OrderState.SelectedIndex = Int32.Parse(data["State"].ToString());
      }

      data.Close();
      connection.Close();
    }

    private void addOrderBtn_Click(object sender, EventArgs e) {

      try {
        Crud.AddOrder(this.newOrder, CustomerNameInput.Text, OrderInput.Text, AddressInput.Text, NotesInput.Text, PriceInput.Text, OrderState.SelectedIndex, this.id);

        this.panel.UpdateTable();
        this.panel.Focus();
        Close();
      } catch (Exception error) {
        MessageBox.Show(error.Message, "Bir hata meydana geldi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void deleteOrder_Click(object sender, EventArgs e) {
      try {
        Crud.DeleteOrderById(this.id);

        MessageBox.Show("Sipariş Silindi!");
        this.panel.UpdateTable();
        this.panel.Focus();
        Close();
      } catch (Exception error) {
        MessageBox.Show(error.Message, "Bir hata meydana geldi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
