using Retriever;

namespace Search
{
    public class SearchEmail : DataHandler
    {
        public SearchEmail(Context context) : base(context)
        {
        }

        public override IEnumerable<string> Search(string value)
        {
            var list = _context.GetData();
            var mail = list
                .Where(x => x.Name.Contains(value)
                            || x.Surname.Contains(value))
                .Select(x => x.Email);
            return mail;
        }
    }
}
