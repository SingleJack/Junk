using SchedulerApp.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SchedulerApp.Data
{
    internal class AdminDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UsherSignUp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //performs all operations on the database.
        public List<AdminModel> FetchAll()
        {
            List<AdminModel> returnList = new List<AdminModel>();

            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "select * from dbo.ServiceDetail";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        AdminModel user = new AdminModel();
                        user.Id = reader.GetInt32(0);
                        user.FirstName = reader.GetString(1);
                        user.LastName = reader.GetString(2);
                        user.Date = reader.GetDateTime(3);
                        user.Duties = reader.GetString(4);
                        user.Service = reader.GetInt32(5);
                        user.UserID = reader.GetString(6);

                        returnList.Add(user);
                    }
                }
            }

            return returnList;
        }

        public AdminModel FetchOne(int Id)
        {
            AdminModel user = new AdminModel();

            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "select * from dbo.ServiceDetail where Id = @id";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                //associate @id with Id parameter 
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {                       
                        user.Id = reader.GetInt32(0);
                        user.FirstName = reader.GetString(1);
                        user.LastName = reader.GetString(2);
                        user.Date = reader.GetDateTime(3);
                        user.Duties = reader.GetString(4);
                        user.Service = reader.GetInt32(5);
                        user.UserID = reader.GetString(6);
                    }
                }
            }
            return user;
        }
    }
}