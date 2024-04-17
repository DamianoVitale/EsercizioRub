using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rub
{
    public class SearchEmail : DataHandler
    {
        
        public SearchEmail(Context context) : base(context) 
        {
            
        }

        public override IEnumerable<string> Search(string value)
        {
            var lista = _context.GetData();
            IEnumerable<string> mail = lista.Where(x => x.Name.Contains(value) || x.Surname.Contains(value)).Select(x => x.Email);
            return mail;
        }
    }
}
