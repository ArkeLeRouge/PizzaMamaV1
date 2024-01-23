using Microsoft.AspNetCore.Mvc;
using PizzaMama.Data;
using Newtonsoft.Json;
using PizzaMama.Pages.Admin.Pizzas;
using PizzaMama.Models;
using NuGet.Protocol;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaMama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class APIController : Controller
    {
        private readonly Data.DataContext _data;

        public APIController(Data.DataContext data)
        { 
            _data = data;
        }

        // /api/GetPizzas
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            return Json(_data.Pizzas);
        }
    }
}
