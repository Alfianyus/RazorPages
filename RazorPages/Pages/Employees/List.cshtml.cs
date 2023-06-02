using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data;

namespace RazorPages.Pages.Employees
{
    public class ListModel : PageModel
    {
        private readonly RazorPagesDemoDbContext dbContext;

        public List<Models.Domain.Employee> Employees { get; set; }

        public ListModel(RazorPagesDemoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet()
        {
            Employees=dbContext.Employees.ToList();
        }
    }
}
