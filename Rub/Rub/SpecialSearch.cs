using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rub
{
    public class SpecialSearch : ISearch
    {
        protected Context _context;
        public SpecialSearch(Context context) 
        {
            _context = context ;
        }
        public IEnumerable<Item> Search(string value)
        {
            var enumarable = _context.GetData().Where(x => x.Name.Contains(value) || x.Surname.Contains(value) || x.City.Contains(value) || x.Address.Contains(value) || x.Mobile.Contains(value) || x.Email.Contains(value);
            
            return enumarable ;
        }
    }
}
