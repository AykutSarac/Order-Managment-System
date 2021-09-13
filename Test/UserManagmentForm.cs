using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using OrderMS;

namespace OrderMS {
  public partial class UserManagmentForm : Form {
    public UserManagmentForm() {
      InitializeComponent();
      UpdateTable();
    }

    public void UpdateTable() {

      try {
        using SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
        connection.Open();

        // Return Orders List ordered by their states
        SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From tblUsers", connection);
        DataSet dset = new DataSet();
        adapter.Fill(dset, "info");


        UsersTable.DataSource = dset.Tables[0];

        adapter.Dispose();
        connection.Close();

        // Remove table selection
        UsersTable.ClearSelection();
      } catch (Exception e) {
        MessageBox.Show(e.Message);
      }
    }

    private void UsersTable_DataSourceChanged(object sender, EventArgs e) {
      // Rename Table Header Texts
      UsersTable.Columns[0].HeaderText = "ID";
      UsersTable.Columns[1].HeaderText = "Kullanıcı Adı";
      UsersTable.Columns[2].HeaderText = "Şifre";
      UsersTable.Columns[3].HeaderText = "Yetki";

      // Convert States into Text
      for (int i = 0; i < UsersTable.Rows.Count; i++) {
        int state = Convert.ToInt32(UsersTable.Rows[i].Cells[3].Value);
        UsersTable.Rows[i].Cells[3].Value = GetState(state);
      }
    }

    private string GetState(int state) {
      // Order States
      var stateMap = new Dictionary<int, string>(){
        {0, "Kullanıcı"},
        {1, "Yönetici"},
      };

      string output;

      return stateMap.TryGetValue(state, out output) ? output : "default";
    }

    private void UsersTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
      DialogResult result = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

      if (result == DialogResult.OK) {
        string id = UsersTable.Rows[e.RowIndex].Cells[0].Value.ToString();
        Crud.DeleteUserById(id);
        UpdateTable();
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      string username = UsernameInput.Text;
      string password = PasswordInput.Text;
      bool isAdmin = isAdminCB.Checked;

      try {
        using SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
        connection.Open();

        string action = "INSERT INTO tblUsers(username, password, type) values(@username, @password, @type)";

        SQLiteCommand actionRun = new SQLiteCommand(action, connection);

        actionRun.Parameters.AddWithValue("@username", username);
        actionRun.Parameters.AddWithValue("@password", password);
        actionRun.Parameters.AddWithValue("@type", Convert.ToInt32(isAdmin).ToString());

        actionRun.ExecuteNonQuery();

        actionRun.Dispose();
        connection.Close();

        UsernameInput.Text = "";
        PasswordInput.Text = "";
        isAdminCB.Checked = false;

        UpdateTable();
      } catch (Exception error) {
        MessageBox.Show(error.Message, "Bir hata meydana geldi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
