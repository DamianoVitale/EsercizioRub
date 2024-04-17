using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rub
{
    public  class ConsoleWriter : PrintData
    {
        public  override void Print(IEnumerable<string> value)
        {
            foreach (string val in value)
            {
                Console.WriteLine($"Valori trovati: {val}");
            }
        }
    }
}
