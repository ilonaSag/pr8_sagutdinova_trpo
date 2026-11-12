using pr8.Models;
using Task = pr8.Models.Task;

namespace pr8.Service
{
    public class TaskService
    {
        private readonly TrpoPr8Context _context = DbService.Instance.Context;

        private List<Task> tasks = new();

        public List<Task> GetAll()
        {
            var _tasks = _context.Tasks.ToList();

            tasks.Clear();
            foreach (var task in _tasks)
            {
                tasks.Add(task);
            }

            return tasks;
        }

        public void Add(Task task)
        {
            _context.Tasks.Add(task);
            Commit();
        }

        public void Delete(Task task)
        {
            _context.Tasks.Remove(task);
            Commit();
        }

        public int Commit() => _context.SaveChanges();
    }
}
