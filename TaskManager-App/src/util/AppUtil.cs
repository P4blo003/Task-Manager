// ---- Libs ----
using Microsoft.Data.Sqlite;
// ---- Code ----
namespace TaskManager_App.Util
{
    public class DBUtil
    {   
        // -- Class properties --

        // Default:

        private string dbPath = "";


        // -- Class methods --

        /// <summary>
        /// Creates the string format of an objet to add into a query.
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>String format.</returns>
        public string GetDBStringFormat(object obj)
        {
            return string.Concat("'",obj.ToString(),"'");
        }

        /// <summary>
        /// Create a connection with the sqlite data base.
        /// </summary>
        /// <param name="path">Dta base path.</param>
        /// <returns>Connection</returns>
        public SqliteConnection GetConnection()
        {
            string connectionString = string.Concat("Data Source=",dbPath);
            return new SqliteConnection(connectionString);
        }
    }
}