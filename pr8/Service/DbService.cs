using pr8.Models;

namespace pr8.Service
{
    public class DbService
    {
        private TrpoPr8Context _context;
        public TrpoPr8Context Context => _context;

        private static DbService instance;
        public static DbService Instance
        {
            get
            {
                if (instance == null) instance = new DbService();
                return instance;
            }
        }
        private DbService()
        {
            _context = new TrpoPr8Context();
        }
    }
}
