using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaMama.Data;
using PizzaMama.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaMama.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private DataContext _dataContext;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public void OnGet()
        {
            /*Pizza pizza = new Pizza() { nom = "Pizza test", prix = 5 };
            _dataContext.Pizzas.Add(pizza);
            _dataContext.SaveChanges();*/
        }
    }

}
