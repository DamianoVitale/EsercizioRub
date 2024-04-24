using DataLibrary;

namespace Search
{
    public interface ISearch
    {
        public IEnumerable<Item> Search(string value);
    }
}
