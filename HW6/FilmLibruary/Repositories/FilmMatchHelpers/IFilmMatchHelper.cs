using FilmLibrary.Model;

namespace FilmLibrary.Repositories.FilmMatchHelpers
{
    public interface IFilmMatchHelper
    {
        bool Match(Film film, SearchDescriptor descriptor);
    }
}
