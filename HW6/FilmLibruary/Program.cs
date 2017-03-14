using System;
using System.Windows.Forms;
using FilmLibrary.Controller;
using FilmLibrary.Repositories;
using FilmLibrary.Views;

namespace FilmLibrary
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var libraryView = new LibraryView();
            var filmRepository = new FilmRepository();
            var controller = new FilmController(libraryView, filmRepository);

            Application.Run(libraryView);
        }
    }
}
