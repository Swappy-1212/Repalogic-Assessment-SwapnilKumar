using ToDoList.Models;

namespace ToDoList.Services
{
    public interface IToDoService
    {
        IEnumerable<TodoItem> GetAll(string filter);
        TodoItem? GetById(int id);
        void Add(string title);
        void Update(TodoItem item);
        void Delete(int id);
        void ToggleComplete(int id);
    }
}
