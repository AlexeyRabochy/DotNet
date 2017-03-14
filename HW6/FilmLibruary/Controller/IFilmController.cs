using System;
using System.Collections.Generic;
using System.ComponentModel;
using FilmLibrary.Model;

namespace FilmLibrary.Controller
{
    public interface IFilmController
    {
        bool EditFilm(FilmEditDescriptor descriptor);
        bool RemoveFilms(List<int> ids);
        BindingList<FilmViewModel> GetFilmBindingList();
        List<Film> FindFilms(SearchDescriptor descriptor);
        void StartFilmsLoad(string connectionString);
        void StartFilmsSearch(SearchDescriptor SearchDescriptor);
        event EventHandler LoadComplete;
        event EventHandler SearchComplete;
        event EventHandler ExeptionHappened;
    }
}
