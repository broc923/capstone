using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDPrinter {
    class Database {
        #region connectToDatabase
        //[dbo].[Table]
        //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        
        #endregion

        #region checkForUser
        public static void checkUser(string userID) {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Data Source =.\\SQLEXPRESS;" + "AttachDbFilename = \"E:\\Spring 2016\\Computer Science Capstone\\Capstone Code\\capstone\\IDPrinter\\Database.mdf\";" + "Integrated Security = True;";
            string connect = builder.ConnectionString;
            string sql = "SELECT * FROM [dbo].[Table] WHERE (ID=@userID)";
            Console.WriteLine(userID);
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@userID", userID);
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader()) {
                    while(dataReader.Read()) {
                        Console.WriteLine(dataReader["firstName"].ToString());
                    }
                }
                
            }
        }
        #endregion

        #region addUser
        public static void addUser(string firstName, string LastName) {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            string connect = builder.ConnectionString;
            string sql = "INSERT INTO [dbo].[Table] (firstName, lastName, street, city, userState, zip, phone, photo, isAdmin) VALUES (@firstName,@lastName)";
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", LastName);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                connection.Close();
            }
        }
        #endregion

        #region deleteUser

        #endregion

        #region updateUser

        #endregion

        #region selectUser

        #endregion
    }
}