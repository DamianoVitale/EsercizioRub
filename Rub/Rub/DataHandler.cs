using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rub
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
