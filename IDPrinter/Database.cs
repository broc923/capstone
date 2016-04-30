using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace IDPrinter {
    class Database {
        #region connectToDatabase
        public static string connect = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; //Connection string in app.config
        #endregion

        #region checkForUser
        public static string[] checkUser(string userID) { //Checks the user's ID and returns info from DB
            string sql = "SELECT * FROM [dbo].[Table] WHERE (ID=@userID)"; //SQL string
            using (SqlConnection connection = new SqlConnection(connect)) { 
                SqlCommand command = new SqlCommand(sql, connection); //Create the command using the connection and sql string
                command.Parameters.AddWithValue("@userID", userID); 
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader()) {
                    while (dataReader.Read()) {
                        Console.WriteLine(dataReader["firstName"].ToString());
                        //All data from returned from the reader about the user ID
                        string[] data = { dataReader["ID"].ToString(), dataReader["firstName"].ToString(), dataReader["lastName"].ToString(), dataReader["street"].ToString(), dataReader["city"].ToString(), dataReader["userState"].ToString(), dataReader["zip"].ToString(), dataReader["phone"].ToString(), dataReader["photo"].ToString(), dataReader["isAdmin"].ToString() };
                        return data; //returns string array of all user info
                    }
                }
                return new string[0]; //Ruturn nothing, was an error
            }
        }
        #endregion
        #region newUser
        public static int newUser() { //Checks the latest user ID in the database
            string sql = "SELECT MAX(ID) AS userMax FROM [dbo].[Table]"; //sql string
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection); //Create the command using the connection and sql string
                connection.Open();
                int data = (Int32)command.ExecuteScalar(); //Count of the max ID in the database
                return data; //returns max ID in the DB
            }
        }
        #endregion

        #region addUser
        //adds users from the form into the database
        public static string addUser(string firstName, string LastName, string street, string city, string userState, string zip, string phone, string photo, string isAdmin) {
            string sql = "INSERT INTO [dbo].[Table] (firstName, lastName, street, city, userState, zip, phone, photo, isAdmin) VALUES (@firstName,@lastName,@street,@city,@userState,@zip,@phone,@photo,@isAdmin)"; //sql string
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection); //Create the command using the connection and sql string
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

                string userAdded = "The user has been added."; //Message to return if successful
                return userAdded; //Return string jsut to let the user know it was a success
            }
        }
        #endregion

        #region deleteUser
        //Deletes users based on ID from the database
        public static string deleteUser(string userID) {
            string sql = "DELETE FROM [dbo].[Table] WHERE (ID=@userID)"; //sql string
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection); //Create the command using the connection and sql string
                command.Parameters.AddWithValue("@userID", userID);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader(); //Executes data and lets things be read back if need be
                connection.Close();

                string userDeleted = "The user has been deleted.";
                return userDeleted;
            }
        }
        #endregion

        #region timeSelect
        //Grabs all users from timetable
        public static ArrayList selectUser() {
            string sql = "SELECT * FROM [dbo].[TimeTable] ORDER BY ID"; //sql string
            ArrayList data = new ArrayList(); //Establishes a blank arraylist
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection); //Create the command using the connection and sql string
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader()) {
                    while (dataReader.Read()) {
                        data.Add(dataReader["ID"].ToString());
                        data.Add(dataReader["time"].ToString());
                        data.Add(dataReader["loggingIn"].ToString());
                    }
                    Console.WriteLine(data[0]);
                    return data; //Returns all user info from the timeTable for every user
                }
            }
        }
        #endregion

        #region newLog
        //Creates a new timestamp log in the timetable
        public static string data(string ID, bool loggingIn) {
            string sql = "INSERT INTO [dbo].[TimeTable] (ID, time, loggingIn) VALUES (@ID,@time,@loggingIn)"; //sql string
            using (SqlConnection connection = new SqlConnection(connect)) {
                DateTime currentTime = DateTime.Now;

                SqlCommand command = new SqlCommand(sql, connection); //Create the command using the connection and sql string
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@time", currentTime);
                command.Parameters.AddWithValue("@loggingIn", loggingIn);

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader(); //
                connection.Close();

                string userAdded = "The user has been added.";
                return userAdded;
            }
        }
       #endregion

       #region clear Timetable
        //Clears Time Table
        public static string clearTimeTable() {
            string sql = "DELETE FROM [dbo].[Table]"; //sql string
            using (SqlConnection connection = new SqlConnection(connect)) {
                SqlCommand command = new SqlCommand(sql, connection); //Create the command using the connection and sql string
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader(); //Executes data and lets things be read back if need be
                connection.Close();

                string userDeleted = "The Time Table has been cleared."; //SImple message returned to user
                return userDeleted; //Returns the message to the user
            }
        }
        #endregion
    }
}
