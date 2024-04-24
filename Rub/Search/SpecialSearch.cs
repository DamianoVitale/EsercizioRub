using DataLibrary;
using Retriever;

namespace Search
{
    public class SpecialSearch : ISearch
    {
        protected Context _context;

        public SpecialSearch(Context context)
        {
            _context = context;
        }

        public IEnumerable<Item> Search(string value)
        {
            var enumarable = _context.GetData()
                .Where(x => x.Name.Contains(value)
                            || x.Surname.Contains(value)
                            || x.City.Contains(value)
                            || x.Address.Contains(value)
                            || x.Mobile.Contains(value)
                            || x.Email.Contains(value));
            //mancava una parentesi tonda di chiusura... e quindi non compilava,
            //attenzione che questo è un errore considerato grave,
            //pushare un codice che non compila!

            return enumarable;
        }
    }
}
