using System.Data.SqlClient;

public class Repository
{
  public void RunQuery(string query)
  {
      SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Northwind;Integrated Security=true");
      connection.Open();

      // This line is vulnerable to SQL Injection attacks.
      SqlCommand command = new SqlCommand(query, connection);
      command.ExecuteNonQuery();

      connection.Close();
  }
}

