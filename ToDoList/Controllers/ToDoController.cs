using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoService _todoService;

        public ToDoController(IToDoService todoService)
        {
            _todoService = todoService;
        }

        public IActionResult Index(string filter = "all")
        {
            ViewBag.Filter = filter;
            var todos = _todoService.GetAll(filter);
            return View(todos);
        }

        [HttpPost]
        public IActionResult Create(string title)
        {
            _todoService.Add(title);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var todo = _todoService.GetById(id);
            return View(todo);
        }

        [HttpPost]
        public IActionResult Edit(TodoItem item)
        {
            _todoService.Update(item);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ToggleComplete(int id)
        {
            _todoService.ToggleComplete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _todoService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
