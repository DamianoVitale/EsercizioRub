using DataLibrary;
using Retriever;

namespace Search
{
    public abstract class DataHandler
    {
        protected Context _context;

        protected DataHandler(Context context)
        {
            _context = context;
        }

        public abstract IEnumerable<string> Search(string value);

        public void AddItem(Item item)
        {
            _context.Add(item);
        }
    }
}
