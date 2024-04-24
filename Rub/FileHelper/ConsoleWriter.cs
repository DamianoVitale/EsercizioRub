namespace IOHelper
{
    public class ConsoleWriter : PrintData
    {
        public override void Print(IEnumerable<string> value)
        {
            foreach (var val in value)
            {
                Console.WriteLine($"Valori trovati: {val}");
            }
        }
    }
}
