using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rub
{
    public class FileWriter : PrintData
    {
        protected string _path;
        public FileWriter(string path)
        {
            _path = path;
        }
        public override void Print(IEnumerable<string> value)
        {
            if (File.Exists(_path)){
                using StreamWriter sw = new StreamWriter(_path, true);
                foreach (string val in value)
                {
                    sw.WriteLine(val);
                }
            } else
            {
                using (StreamWriter sw = new StreamWriter(_path))
                {
                    foreach (string val in value)
                    {
                        sw.WriteLine(val);
                    }
                }
            }
        }
    }
}
