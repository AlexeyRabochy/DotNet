using System;
using FilmLibrary.Model;

namespace FilmLibrary.CustomEventArgs
{
    internal class FilmEditDescriptorEventArgs : EventArgs
    {
        public FilmEditDescriptor EditedFilm { get; private set; }

        public FilmEditDescriptorEventArgs(FilmEditDescriptor editedFilm)
        {
            EditedFilm = editedFilm;
        }
    }
}