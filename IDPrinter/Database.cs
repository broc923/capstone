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
            //Console.WriteLine(userID);
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@userID", userID);
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader()) {
                    while (dataReader.Read()) {
                        Console.WriteLine(dataReader["firstName"].ToString());
                        string[] data = { dataReader["ID"].ToString(), dataReader["firstName"].ToString(), dataReader["lastName"].ToString(), dataReader["street"].ToString(), dataReader["city"].ToString(), dataReader["userState"].ToString(), dataReader["zip"].ToString(), dataReader["phone"].ToString(), dataReader["photo"].ToString(), dataReader["isAdmin"].ToString() };
                        return data;
                    }
                }
                return new string[0];
            }
        }
        #endregion
        #region newUser
        public static int newUser() {
            string sql = "SELECT MAX(ID) AS userMax FROM [dbo].[Table]";
            //Console.WriteLine(userID);
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection);
                //command.Parameters.AddWithValue("@userID", userID);
                connection.Open();
                    //int numVal = Int32.Parse("-105");
                    int data = (Int32)command.ExecuteScalar();
                    return data;
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
    }
}
