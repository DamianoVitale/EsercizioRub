namespace IOHelper
{
    public class FileWriter : PrintData
    {
        protected string _path;
        private readonly bool _append;

        public FileWriter(string path, bool append)
        {
            _path = path;
            _append = append;
        }

        public override void Print(IEnumerable<string> value)
        {
            using var sw = new StreamWriter(_path, _append);

            foreach (var val in value)
            {
                sw.WriteLine(val);
            }
        }

        //questa soluzione non mi convince, perchè non si può mai avere il controllo se va in append o meno, decide la classe...
        /*
        protected string _path;

        public FileWriter(string path)
        {
            _path = path;
        }

        public override void Print(IEnumerable<string> value)
        {
            if (File.Exists(_path))
            {
                using StreamWriter sw = new StreamWriter(_path, true);
                foreach (string val in value)
                {
                    sw.WriteLine(val);
                }
            }
            else
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

        */
    }
}
