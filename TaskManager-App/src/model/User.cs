// ---- Libs ----

// ---- Code ----
namespace TaskManager_App.Model
{
    public class User
    {
        // -- Class properties --

        public int id;              // User id.
        public bool isAdmin;            // If the user is admin, user, etc.
        public string username;     // Username.
        public string password;     // Hash of the user password.


        // -- Constructors --

        /// <summary>
        /// Empty constructor.
        /// </summary>
        public User()
        {
            // Initializes the class props.
            this.id = -1;
            this.isAdmin = false;
            this.username = "NaN";
            this.password = "NaN";
        }
        /// <summary>
        /// Param constructor
        /// </summary>
        /// <param name="id">User id.</param>
        /// <param name="level">User level.</param>
        /// <param name="username">User name.</param>
        /// <param name="hashPwd">User password hash.</param>
        public User(int id,bool isAdmin, string username, string hashPwd)
        {
            // Initializes the class props.
            this.id = id;
            this.isAdmin = isAdmin;
            this.username = username;
            this.password = hashPwd;
        }
    }
}