// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

int a = 10;
int b = 100;

Console.WriteLine("Answer of adding a, b");
Console.WriteLine(a + b);

Console.ReadLine();

InsertCutomer();

SqlDataAdapter adapter = new SqlDataAdapter();
static void InsertCutomer()
{
    SqlConnection con = new SqlConnection("ConnectionString");
    SqlCommand cmd = new SqlCommand("Sp_InsertCustomer", con);

    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.AddWithValue("@Id", 1);

    cmd.ExecuteNonQuery();
}

// C#.net to Windows standard exe
// 