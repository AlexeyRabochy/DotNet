using System;
using FilmLibrary.Model;

namespace FilmLibrary.CustomEventArgs
{
    internal class SearchDescriptorEventArgs : EventArgs
    {
        public SearchDescriptor SearchDescriptor { get; private set; }

        public SearchDescriptorEventArgs(SearchDescriptor searchDescriptor)
        {
            SearchDescriptor = searchDescriptor;
        }
    }
}
