using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rub
{
    public class Handler
    {
 
        private readonly Context context;
        private readonly FileWriter fileWriter;
        private readonly ConsoleWriter consoleWriter;
        private readonly SearchNumber sn;
        private readonly SearchEmail se;
        private readonly SpecialSearch special;
        
        public Handler(Context _context, FileWriter _filewriter, ConsoleWriter _consolewriter, SearchNumber _sn, SearchEmail _se, SpecialSearch _special )    
        {
            context = _context;
            fileWriter = _filewriter;
            consoleWriter = _consolewriter;
            sn = _sn;
            special = _special;
            se = _se;
        
        }

        public void Add(Item item)
        {
            context.Add(item);
            context.Save();
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
            
                return sn.Search(value);
        }

        public IEnumerable<string> SearchEmail(string value)
        {
            
            return se.Search(value);
        }

        public IEnumerable<Item> SpecialSearch(string value){
            
            return special.Search(value);
        }


    }
}
