using System;
using System.Data;
using System.Data.SqlClient;

class DisconnectedDemo
{
    static void Main()
    {
        string connStr = @"Server=(localdb)\MSSQLLocalDB;Database=LabDB;Trusted_Connection=True;";
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students", conn);
        DataSet ds = new DataSet();

        adapter.Fill(ds, "Students"); // fills dataset with table data

        Console.WriteLine("Disconnected Architecture:");
        Console.WriteLine("--------------------------");

        foreach (DataRow row in ds.Tables["Students"].Rows)
        {
            Console.WriteLine($"{row["Id"]} - {row["Name"]} - {row["Marks"]}");
        }
    }
}


