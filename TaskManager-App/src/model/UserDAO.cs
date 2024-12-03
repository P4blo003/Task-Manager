// ---- Libs ----
using Microsoft.Data.Sqlite;
using TaskManager_App.Util;
// ---- Code ----
namespace TaskManager_App.Model
{
    public interface UserDAO
    {
        // -- Interface methods --

        /// <summary>
        /// Save the given user into the data base.
        /// </summary>
        /// <param name="user">User to save.</param>
        public void SaveUser(User user);
        /// <summary>
        /// Update the user from the data base.
        /// </summary>
        /// <param name="user">User to update.</param>
        public void UpdateUser(User user);
        /// <summary>
        /// Delete the user from the data base.
        /// </summary>
        /// <param name="user">User to delete.</param>
        public void DeleteUser(User user);
        /// <summary>
        /// Gets the list with all the users.
        /// </summary>
        /// <returns>List with the users.</returns>
        public List<User> GetUsers();
    }

    public class UserDAOImp : UserDAO
    {
        // -- UserDAO methods --

        /// <summary>
        /// Save the given user into the data base.
        /// </summary>
        /// <param name="user">User to save.</param>
        public void SaveUser(User user)
        {
            try     // Try-catch to manage exceptions.
            {
                DBUtil dbUtil = new DBUtil();   // To help with db actions.
                SqliteConnection connection = dbUtil.GetConnection();   // Create a connection.
                connection.Open();  // Open the connection.
                try
                {
                    string query = string.Concat("INSERT INTO USER VALUES (",dbUtil.GetDBStringFormat(user.isAdmin),",",
                                    dbUtil.GetDBStringFormat(user.username),",",dbUtil.GetDBStringFormat(user.password),")");
                    SqliteCommand command = new SqliteCommand(query, connection);   // Creates the command
                }
                catch (Exception)
                {
                }
                connection.Close();
            }
            catch(Exception)
            {
            }
        }
        /// <summary>
        /// Update the user from the data base.
        /// </summary>
        /// <param name="user">User to update.</param>
        public void UpdateUser(User user)
        {
        }
        /// <summary>
        /// Delete the user from the data base.
        /// </summary>
        /// <param name="user">User to delete.</param>
        public void DeleteUser(User user)
        {
        }
        /// <summary>
        /// Gets the list with all the users.
        /// </summary>
        /// <returns>List with the users.</returns>
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();    // Creates the empty list.

            try     // Try-catch to manage exceptions.
            {
                DBUtil dbUtil = new DBUtil();   // To help with db actions.
                SqliteConnection connection = dbUtil.GetConnection();   // Create a connection.
                connection.Open();  // Open the connection.
                try
                {
                    string query = string.Concat("SELECT * FROM USERS");    // DB query.
                    SqliteCommand command = new SqliteCommand(query, connection);   // Creates the command
                    SqliteDataReader reader = command.ExecuteReader();      // Execute the command.

                    while(reader.Read())
                    {
                        User user = new User(reader.GetInt32(0),reader.GetBoolean(1),reader.GetString(2),reader.GetString(3));
                        users.Add(user);
                    }

                    return users;
                }
                catch (Exception)
                {
                }
                connection.Close();
            }
            catch(Exception)
            {
            }

            return users;
        }
    }
}