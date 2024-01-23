using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace PizzaMama.Pages.Admin
{
    public class IndexModel : PageModel
    {
        IConfiguration _configuration;
        public bool isFailedLogin { get; private set; }
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
            isFailedLogin = false;
        }
        public IActionResult OnGet()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                return Redirect("/Admin/Pizzas");
            return Page();

        }

        async public Task<IActionResult> OnPost(string username, string password, string returnUrl)
        {
            var auth = _configuration.GetSection("Auth");
            if (username == auth["AdminLogin"] && password == auth["AdminPassword"])
            {
                var claims = new List<Claim>{
                    new Claim(ClaimTypes.Name, username)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new
                ClaimsPrincipal(claimsIdentity));
                isFailedLogin = false;
                return Redirect(returnUrl == null ? "/Admin/Pizzas" : returnUrl);
            }
            isFailedLogin = true;
            return Page();
        }

        async public Task<IActionResult> OnGetLogout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Admin");
        }
    }
}
