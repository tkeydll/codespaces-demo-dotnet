using System.Data.SqlClient;

public class Repository
{
  public async Task RunQuery(string name)
  {
      SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Northwind;Integrated Security=true");
      connection.Open();

      var query = "select * from customers where customer_name = '" + name + "';
      SqlCommand command = new SqlCommand(query, connection);
      await command.ExecuteNonQueryAsync();

      connection.Close();
  }
}

