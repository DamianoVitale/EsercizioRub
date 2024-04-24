using Retriever;

namespace Search
{
    public class SearchNumber : DataHandler
    {

        public SearchNumber(Context context) : base(context)
        {

        }

        public override IEnumerable<string> Search(string value)
        {
            var list = _context.GetData();
            var mail = list
                .Where(x => x.Name.Contains(value) || x.Surname.Contains(value))
                .Select(x => x.Mobile);
            return mail;
        }


    }
}
