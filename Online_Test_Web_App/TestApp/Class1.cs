using Business_Object_Layer;
using Data_Access_Layer;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace TestApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            
            SqlUserDatabase db = new SqlUserDatabase();
            String p  = db.login("ramendrapandey","1234qwert");
           
                Console.WriteLine($"{p}");
           
        }
    }
}

