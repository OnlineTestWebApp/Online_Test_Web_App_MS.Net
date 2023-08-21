using Business_Object_Layer;
using System;
using System.Data.SqlClient;


namespace Data_Access_Layer
{
    public class SqlUserDatabase 
    {
        String query;
        
        SqlConnection con = new SqlConnection();
        
        public String login(String username, String password) 
        {
            con.ConnectionString = "data source=RAMENDRA\\SQLEXPRESS; Initial Catalog = user; Integrated Security=true";
            User user= new User();  
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
           
            query= $"Select privilege from usertable where user_name='{username}' and password= '{password}'";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String privilege=reader.GetString(0);
            con.Close();
            
            return privilege ;
          //  while (reader.Read()) 
          //  {
          //      Console.WriteLine($"{reader[0],-10} {reader[1],-10}{reader[2],-10}"); 
//            }

        }
    }
}
