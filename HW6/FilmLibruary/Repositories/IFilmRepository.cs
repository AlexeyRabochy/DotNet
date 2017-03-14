using System.Collections.Generic;
using FilmLibrary.Model;

namespace FilmLibrary.Repositories
{
    public interface IFilmRepository
    {
        List<Film> GetAllFilms();
        bool EditFilm(FilmEditDescriptor descriptor);
        bool RemoveFilms(List<int> ids);
        List<Film> FindFilms(SearchDescriptor descriptor);
        void SetConnection(string connectionString);
    }
}
