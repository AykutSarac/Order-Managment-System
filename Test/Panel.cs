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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
            UpdateTable();
        }

        public void UpdateTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
            {
                connection.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From tblOrder", connection);
                DataSet dset = new DataSet();
                adapter.Fill(dset, "info");
                connection.Close();

                OrderTable.DataSource = dset.Tables[0];
            }
        }


        private void Panel_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            AddOrder AddOrderForm = new AddOrder(this);
            AddOrderForm.Show();
        }

        private void OrderTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = OrderTable.Rows[e.RowIndex].Cells[0].Value.ToString();

            AddOrder AddOrderForm = new AddOrder(id, this);
            AddOrderForm.Show();
        }

        private void OrderTable_DataSourceChanged(object sender, EventArgs e)
        {
            OrderTable.Columns[0].HeaderText = "No";
            OrderTable.Columns[1].HeaderText = "Müşteri İsmi";
            OrderTable.Columns[2].HeaderText = "Sipariş";
            OrderTable.Columns[3].HeaderText = "Adres";
            OrderTable.Columns[4].HeaderText = "Notlar";
            OrderTable.Columns[5].HeaderText = "Ücret";
            OrderTable.Columns[6].HeaderText = "Durum";

            for (int i = 0; i < OrderTable.Rows.Count; i++)
            {
                int state = Int32.Parse(OrderTable.Rows[i].Cells[6].Value.ToString());
                OrderTable.Rows[i].Cells[6].Value = GetState(state);
            }
        }

        private string GetState(int state)
        {
            var stateMap = new Dictionary<int, string>()
{
            {0, "Sipariş Alındı"},
            {1, "Hazırlanıyor"},
            {2, "Yolda"},
            {3, "İptal"},
};
            string output;

            return stateMap.TryGetValue(state, out output) ? output : "default";
        }
    }
}
