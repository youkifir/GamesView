using GamesView.Data;
using GamesView.Forms;
using GamesView.Models;

namespace GamesView
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDbContext context = new AppDbContext();
            UserService userService = new UserService(context);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin(userService));
        }
    }
}