using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDemo.Models;

namespace RazorDemo.Pages
{
    public class TodoListModel : PageModel
    {
        private readonly TodoDbContext _dbContext;
        public List<Todo> Todos { get; set; } = new List<Todo>();

        [BindProperty]
        public Todo NewTodo { get; set; }
        public TodoListModel(TodoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet()
        {
            Todos = _dbContext.Todos.ToList();
        }

        public IActionResult OnPost() 
        {
            _dbContext.Add(NewTodo);
            _dbContext.SaveChanges();
            return RedirectToPage();
        }
    }
}
