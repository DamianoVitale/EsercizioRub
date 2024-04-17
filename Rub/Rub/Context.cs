using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rub
{
    public  class Context
    {
        private readonly string _path;
        public List<Item> data = new List<Item>();

        public Context(string path)
        {
            _path = path;
        }
        public void SetList()
        {
            data = FileReader.ReadLines(_path);
        }

         public void Add(Item item)
        {
            data.Add(item);
            Save();
        }


        public void Save()
        {
            using StreamWriter writer = new StreamWriter(_path);

            foreach (Item item in data)
            {
                string line = $"{item.Name};{item.Surname};{item.Address};{item.City};{item.Mobile};{item.Email}";
                writer.WriteLine(line);
               
            }
        }

        public IEnumerable<Item> GetData()
        {
            foreach (var item in data)
            {
                yield return item;
            }

        }

        
    }
}
