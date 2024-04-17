namespace Rub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\File\\Rub.csv";
            string destinationPath = "C:\\File\\output.txt";
            Context context = new Context(path);
            FileWriter fileWriter = new FileWriter(destinationPath);
            ConsoleWriter consoleWriter = new ConsoleWriter();
            SearchNumber sn = new SearchNumber(context);
            SearchEmail se = new SearchEmail(context);
            SpecialSearch special = new SpecialSearch(context);
            context.SetList();
            Handler hr = new Handler(context, fileWriter, consoleWriter, sn, se, special);


            hr.FilePrint(hr.SearchEmail("Piscitelli"), destinationPath);
            hr.ConsolePrint(hr.SearchNumber("Maggi"));
            
            
        }
    }
}
