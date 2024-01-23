using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaMama.Models;
using PizzaMama.Data;

namespace PizzaMama.Pages
{
    public class MenuModel : PageModel
    {
        private readonly DataContext _context;

        public MenuModel(DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
        }
    }
}
