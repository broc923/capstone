using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace IDPrinter {
    class Database {
        #region connectToDatabase

        public static string connect = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        #endregion

        #region checkForUser
        public static string[] checkUser(string userID) {
            string sql = "SELECT * FROM [dbo].[Table] WHERE (ID=@userID)";
            Console.WriteLine(userID);
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@userID", userID);
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader()) {
                    while (dataReader.Read()) {
                        Console.WriteLine(dataReader["firstName"].ToString());
                    }
                    string[] data = { dataReader["ID"].ToString(), dataReader["firstName"].ToString(), dataReader["lastName"].ToString(), dataReader["street"].ToString(), dataReader["city"].ToString(), dataReader["userState"].ToString(), dataReader["zip"].ToString(), dataReader["phone"].ToString(), dataReader["photo"].ToString(), dataReader["isAdmin"].ToString() };
                    return data;
                }

            }
        }
        #endregion

        #region addUser
        public static string addUser(string firstName, string LastName, string street, string city, string userState, string zip, string phone, string photo, string isAdmin) {
            string sql = "INSERT INTO [dbo].[Table] (firstName, lastName, street, city, userState, zip, phone, photo, isAdmin) VALUES (@firstName,@lastName,@street,@city,@userState,@zip,@phone,@photo,@isAdmin)";
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", LastName);
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@userState", userState);
                command.Parameters.AddWithValue("@zip", zip);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@photo", photo);
                command.Parameters.AddWithValue("@isAdmin", isAdmin);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                connection.Close();

                string userAdded = "The user has been added.";
                return userAdded;
            }
        }
        #endregion

        #region deleteUser
        public static string deleteUser(string userID) {
            string sql = "DELETE FROM [dbo].[Table] WHERE (ID=@userID)";
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@userID", userID);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                connection.Close();

                string userDeleted = "The user has been deleted.";
                return userDeleted;
            }
        }
        #endregion

        #region updateUser
        // public static string updateUser(string userID, string firstName, string LastName, string street, string city, string userState, string zip, string phone, string photo, string isAdmin) {
        public static int updateUser(string ID, string FirstName) {
            // UPDATE Customers SET ContactName = 'Alfred Schmidt', City = 'Hamburg' WHERE CustomerName = 'Alfreds Futterkiste';
            // string sql = "UPDATE [dbo].[Table] SET firstName = @firstName, lastName=@lastName, street=@street, city=@city, userState=@userState, zip=@zip, phone=@phone, photo=@photo, isAdmin=@isAdmin WHERE ID = @userID";
            string sql = "UPDATE [dbo].[Table] SET firstName=@firstName WHERE (firstName='Caleb')";
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@userID", ID);
                command.Parameters.AddWithValue("@firstName", FirstName);

                connection.Open();

                int userUpdated = command.ExecuteNonQuery();

                connection.Close();

                return userUpdated;

                /** public static string deleteUser(string userID) {
                     string sql = "DELETE FROM [dbo].[Table] WHERE (ID=@userID)";
                     using (SqlConnection connection = new SqlConnection(connect)) {
                         SqlCommand command = new SqlCommand(sql, connection);
                         command.Parameters.AddWithValue("@userID", userID);
                         connection.Open();
                         SqlDataReader dataReader = command.ExecuteReader();
                         connection.Close();

                         string userDeleted = "The user has been deleted.";
                         return userDeleted;

                     }
                 }

                 public static string addUser(string firstName, string LastName, string street, string city, string userState, string zip, string phone, string photo, string isAdmin) {
                     string sql = "INSERT INTO [dbo].[Table] (firstName, lastName, street, city, userState, zip, phone, photo, isAdmin) VALUES (@firstName,@lastName,@street,@city,@userState,@zip,@phone,@photo,@isAdmin)";
                     using (SqlConnection connection = new SqlConnection(connect)) {
                         SqlCommand command = new SqlCommand(sql, connection);
                         command.Parameters.AddWithValue("@firstName", firstName);
                         command.Parameters.AddWithValue("@lastName", LastName);
                         command.Parameters.AddWithValue("@street", street);
                         command.Parameters.AddWithValue("@city", city);
                         command.Parameters.AddWithValue("@userState", userState);
                         command.Parameters.AddWithValue("@zip", zip);
                         command.Parameters.AddWithValue("@phone", phone);
                         command.Parameters.AddWithValue("@photo", photo);
                         command.Parameters.AddWithValue("@isAdmin", isAdmin);
                         connection.Open();
                         SqlDataReader dataReader = command.ExecuteReader();
                         connection.Close();

                         string userAdded = "The user has been added.";
                         return userAdded;
                     }
                 }

                 public static string[] checkUser(string userID) {
                     string sql = "SELECT * FROM [dbo].[Table] WHERE (ID=@userID)";
                     Console.WriteLine(userID);
                     using (SqlConnection connection = new SqlConnection(connect)) {
                         SqlCommand command = new SqlCommand(sql, connection);
                         command.Parameters.AddWithValue("@userID", userID);
                         connection.Open();
                         using (SqlDataReader dataReader = command.ExecuteReader()) {
                             while (dataReader.Read()) {
                                 Console.WriteLine(dataReader["firstName"].ToString());
                             }
                             string[] data = { dataReader["ID"].ToString(), dataReader["firstName"].ToString(), dataReader["lastName"].ToString(), dataReader["street"].ToString(), dataReader["city"].ToString(), dataReader["userState"].ToString(), dataReader["zip"].ToString(), dataReader["phone"].ToString(), dataReader["photo"].ToString(), dataReader["isAdmin"].ToString() };
                             return data;
                         }**/

                     }
                 }

                #endregion
    }
}
