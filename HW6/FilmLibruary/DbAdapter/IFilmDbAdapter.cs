using System.Collections.Generic;
using FilmLibrary.Model;

namespace FilmLibrary.DbAdapter
{
    public interface IFilmDbAdapter
    {
        List<Film> GetAllFilms();
        bool EditFilm(FilmEditDescriptor descriptor);
        bool RemoveFilms(List<int> ids);
        List<Film> FindFilms();
        void SetConnection(string connectionString);
    }
}
