using System.Data.SqlClient;

public class Repository
{
  public async Task RunQueryAsync(string name)
  {
      var query = "select * from employees where employee_name = '" + name + "';";
      Console.WriteLine(query);

      SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Northwind;Integrated Security=true");
      connection.Open();

      SqlCommand command = new SqlCommand(query, connection);
      await command.ExecuteNonQueryAsync();

      connection.Close();
  }
}

