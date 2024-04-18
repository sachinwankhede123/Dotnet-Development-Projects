using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentcrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection sqlConnection;
            String connectionString = @"Data Source=SACHIN-PC\SQLEXPRESS;Initial Catalog=studentCRUD;Integrated Security=True;Encrypt=False";
           SqlConnection
          sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            Console.WriteLine("Name:");
            string name=Console.ReadLine();


            Console.WriteLine("Gender:");
            string gender = Console.ReadLine();

            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            string insertQuery="insert into record(name,gender,email)values('"+name+"', '"+gender+"', '"+email+"')";

            SqlCommand insertCommand = new SqlCommand(insertQuery,sqlconnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data inserted");
            sqlconnection.Close();

            Console.ReadKey();
                }
    }
}
