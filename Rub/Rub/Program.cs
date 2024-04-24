using IOHelper;
using Retriever;
using Search;

namespace Rub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "Rub.csv";
            var destinationPath = "output.txt";
            var context = new Context(path);
            var fileWriter = new FileWriter(destinationPath,true);
            var consoleWriter = new ConsoleWriter();
            var sn = new SearchNumber(context);
            var se = new SearchEmail(context);
            var special = new SpecialSearch(context);
            context.SetList();
            var hr = new Handler(context, fileWriter, consoleWriter, sn, se, special);


            hr.FilePrint(hr.SearchEmail("Piscitelli"), destinationPath);
            hr.ConsolePrint(hr.SearchNumber("Maggi"));
        }
    }
}
