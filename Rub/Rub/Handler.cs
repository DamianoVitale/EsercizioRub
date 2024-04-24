using DataLibrary;
using IOHelper;
using Retriever;
using Search;

namespace Rub
{
    public class Handler
    {
        private readonly Context context;
        private readonly FileWriter fileWriter;
        private readonly ConsoleWriter consoleWriter;
        private readonly SearchNumber searchNumber;
        private readonly SearchEmail searchEmail;
        private readonly SpecialSearch specialSearch;

        //i nomi delle variabili deveno essere parlanti, non va bene usare nomi come "se"

        public Handler(Context _context, FileWriter _filewriter, ConsoleWriter _consolewriter, SearchNumber sear, SearchEmail searchEmail, SpecialSearch specialSearch)
        {
            context = _context;
            fileWriter = _filewriter;
            consoleWriter = _consolewriter;
            sear = sear;
            specialSearch = specialSearch;
            searchEmail = searchEmail;
        }

        public void Add(Item item)
        {
            context.Add(item);
        }


        public void ConsolePrint(IEnumerable<string> value)
        {
            consoleWriter.Print(value);
        }
        public void FilePrint(IEnumerable<string> value, string path)
        {
            fileWriter.Print(value);
        }

        public IEnumerable<string> SearchNumber(string value)
        {
            return searchNumber.Search(value);
        }

        public IEnumerable<string> SearchEmail(string value)
        {
            return searchEmail.Search(value);
        }

        public IEnumerable<Item> SpecialSearch(string value)
        {
            return specialSearch.Search(value);
        }


    }
}
