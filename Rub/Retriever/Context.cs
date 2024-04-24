using DataLibrary;
using IOHelper;

namespace Retriever
{
    public class Context
    {
        private readonly string _path;
        private IEnumerable<Item> Data;

        public Context(string path)
        {
            _path = path;
        }

        public void SetList()
        {
            Data = FileReader.ReadLines(_path);
        }

        public void Add(Item item)
        {
            if (Data == null)
                throw new DataNotInitializedException("You tried to add element before initialized the Data context");
            Save(item);
        }


        private void Save(Item item)
        {
            using var writer = new StreamWriter(_path,true);
            writer.WriteLine($"{item.Name};{item.Surname};{item.Address};{item.City};{item.Mobile};{item.Email}");
            SetList();
        }

        public IEnumerable<Item> GetData()
        {
            return Data;
        }


    }
}
