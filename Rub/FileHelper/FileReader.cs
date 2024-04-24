using DataLibrary;

namespace IOHelper
{
    public static class FileReader
    {
        public static IEnumerable<Item> ReadLines(string path)
        {
            using var sr = new StreamReader(path);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                var splitted = sr.ReadLine().Split(';');

                yield return new Item
                {
                    Name = splitted[0],
                    Surname = splitted[1],
                    Address = splitted[2],
                    City = splitted[3],
                    Mobile = splitted[4],
                    Email = splitted[5],
                };
            }
        }
    }
}
