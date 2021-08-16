using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace OrderMS {
  public class Crud {
    public static void AddOrder(bool newOrder, string CustomerName, string OrderInput, string Address, string Notes, string Price, int OrderState, string id) {
      using SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");

      try {
        connection.Open();
        string action;

        if (newOrder) {
          action = "INSERT INTO tblOrder(Customer, OrderDetails, Address, Notes, Payment, State) values(@Customer, @OrderDetails, @Address, @Notes, @Payment, @State)";
        } else {
          action = "UPDATE tblOrder SET Customer = @Customer, OrderDetails = @OrderDetails, Address = @Address, Notes = @Notes, Payment = @Payment, State = @State WHERE Id=" + id;
        }

        SQLiteCommand actionRun = new SQLiteCommand(action, connection);

        actionRun.Parameters.AddWithValue("@Customer", CustomerName);
        actionRun.Parameters.AddWithValue("@OrderDetails", OrderInput);
        actionRun.Parameters.AddWithValue("@Address", Address);
        actionRun.Parameters.AddWithValue("@Notes", Notes);
        actionRun.Parameters.AddWithValue("@Payment", Price);
        actionRun.Parameters.AddWithValue("@State", OrderState);

        actionRun.ExecuteNonQuery();
        connection.Close();

        actionRun.Dispose();
      } catch (Exception error) {
        throw error;
      }
    }

    public static void DeleteOrderById(string id) {
      using SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");

      try {
        connection.Open();
        string action = "DELETE FROM tblOrder WHERE Id=" + id;

        SQLiteCommand actionRun = new SQLiteCommand(action, connection);
        actionRun.ExecuteNonQuery();
        connection.Close();

        actionRun.Dispose();
      } catch (Exception error) {
        throw error;
      }
    }

    public static int UserLogin(string username, string password) {
      using SQLiteConnection connection = new SQLiteConnection("Data Source=database.db;Version=3;");

      try {
        connection.Open();

        string query = "SELECT * FROM tblUsers WHERE username = @username AND password = @password";
        SQLiteCommand action = new SQLiteCommand(query, connection);

        action.Parameters.AddWithValue("@username", username);
        action.Parameters.AddWithValue("@password", password);

        action.ExecuteNonQuery();
        connection.Close();

        SQLiteDataAdapter adapter = new SQLiteDataAdapter(action);
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        if (dt.Rows.Count > 0) {
          return 1;
        } else {
          throw new Exception("Kullanıcı Adı veya Şifre hatalı!");
        }
      } catch (Exception error) {
        throw error;
      }
    }


  }
}
