using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rub
{
    public static class FileReader
    {
        public static List<Item> ReadLines(string path) 
        {
            using StreamReader sr = new StreamReader(path);
            sr.ReadLine();
            var lines = new List<Item>(); 
            while (!sr.EndOfStream) 
            {
                var splitted = sr.ReadLine().Split(';');

                lines.Add(new Item
                {
                    Name = splitted[0],
                    Surname = splitted[1],
                    Address = splitted[2],
                    City = splitted[3],
                    Mobile = splitted[4],
                    Email = splitted[5],

                });
            }
            return lines;
        
        }
    }
}
