using Data_Access_Layer;
using OnlineTestWebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTestWebApp.Models
{
    public class Model1

    {
        
        static void Main(string[] args)
        {
            String username;
            String password;
            SqlUserDatabase sqlUserDatabase = new SqlUserDatabase();
            sqlUserDatabase.login("username", "password");
            LoginController loginController = new LoginController();
            loginController.Login();
        }
    }
}