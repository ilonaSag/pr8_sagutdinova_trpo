using pr8.Models;

namespace pr8.Service
{
    public class UserService
    {
        private readonly TrpoPr8Context _context = DbService.Instance.Context;

        private List<User> users = new();

        public List<User> GetAll()
        {
            var _users = _context.Users.ToList();

            users.Clear();
            foreach (var user in _users)
            {
                users.Add(user);
            }

            return users;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            Commit();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            Commit();
        }

        public int Commit() => _context.SaveChanges();
    }
}
