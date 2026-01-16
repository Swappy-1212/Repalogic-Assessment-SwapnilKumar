using System.Xml.Linq;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class ToDoService : IToDoService
    {
        private readonly List<TodoItem> _todos = new();
        private int _nextId = 1;

        public IEnumerable<TodoItem> GetAll(string filter)
        {
            return filter switch
            {
                "completed" => _todos.Where(t => t.IsCompleted),
                "pending" => _todos.Where(t => !t.IsCompleted),
                _ => _todos
            };
        }

        public TodoItem? GetById(int id)
        {
            return _todos.FirstOrDefault(t => t.Id == id);
        }

        public void Add(string title)
        {
            _todos.Add(new TodoItem
            {
                Id = _nextId++,
                Title = title
            });
        }

        public void Update(TodoItem item)
        {
            var todo = GetById(item.Id);
            if (todo != null)
            {
                todo.Title = item.Title;
            }
        }

        public void Delete(int id)
        {
            var todo = GetById(id);
            if (todo != null)
            {
                _todos.Remove(todo);
            }
        }

        public void ToggleComplete(int id)
        {
            var todo = GetById(id);
            if (todo != null)
            {
                todo.IsCompleted = !todo.IsCompleted;
            }
        }
    }
}
