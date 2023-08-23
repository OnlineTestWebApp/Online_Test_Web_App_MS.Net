using Business_Object_Layer;
using Data_Access_Layer;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace TestApp
{
    internal class Class1
    {
        static void Main1(string[] args)
        {
            
            SqlUserDatabase db = new SqlUserDatabase();
            String p  = db.login("ramendrapandey","1234qwert");
           
                Console.WriteLine($"{p}");
           
        }
        static void Main2(string[] args)
        {
            SqlExamDatabase db = new SqlExamDatabase(); 
        List<Exam> exam_list = new List<Exam>();

            exam_list = db.leaderboard();
            foreach(Exam exam in exam_list)
            {
                Console.WriteLine(exam);
            }
        }
        static void Main3(string[] args)
        {
            SqlExamDatabase db = new SqlExamDatabase();
            Exam e = db.studentSearch("ramendra");
            Console.WriteLine($"{e.id}");
           
        }
        static void Main(string[] args)
        {
                        SqlUserDatabase db = new SqlUserDatabase();
            db.regestration("dresw", "ytgf54", "true");
        }
    }
}

