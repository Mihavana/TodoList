using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.ToDoItemDbContext;

namespace TodoList.Controllers
{
    public class TodoItemController : Controller
    {
        private readonly TodoItemDbContext _context;
        
        public TodoItemController(TodoItemDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            if(TodoItem.tri)
            {
                var AllItem = _context.items.OrderByDescending(i => i.Id).ToList();
                return View(AllItem);
            }
            else
            {
                var AllItem = _context.items.OrderBy(i => i.Id).ToList();
                return View(AllItem);
            }
        }

        public IActionResult Tri(bool isTrue)
        {
            if(isTrue)
            {
                TodoItem.tri = true;
            }
            else
            {
             TodoItem.tri = false;   
            }
            return RedirectToAction("Index");
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            _context.items.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var item = _context.items.FirstOrDefault(i => i.Id == id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(TodoItem item)
        {
            _context.items.Update(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var item = _context.items.FirstOrDefault(i => i.Id == id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(TodoItem item)
        {
            _context.items.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
