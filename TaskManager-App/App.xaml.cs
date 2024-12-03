// ---- Libs ----
using System.Windows;
using TaskManager_App.Model;

// ---- Code ----
namespace TaskManager_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // -- Static properties --

        // Default:

        public User? currentUser;    // Current user.
        

        // -- Application methods --

        /// <summary>
        /// Method called when the app starts.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }
    }
}

