using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelBookingWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [Route("/account/register/{type}")]
        public async Task<IActionResult> Register(string type)
        {
            string user = "user";
            string manager = "manager";
            string admin = "admin";

            if (type.ToLower() != user || type.ToLower() != manager || type.ToLower() != admin)
            {
                RedirectToAction("Index", "Home"); return View();
            }

            string? username = _userManager.GetUserName(User);

            await _userManager.AddToRoleAsync((await _userManager.FindByNameAsync(username!))!, type);


            return View(model: $"Hello from products!!!, dear {username}");
        }

        /* public async Task<IActionResult> Index()
        {
            string? username = _userManager.GetUserName(User);

            if (!await _roleManager.RoleExistsAsync("User"))
            {
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }

            await _userManager.AddToRoleAsync((await _userManager.FindByNameAsync(username!))!, "User");

            return View(model: $"Hello from products!!!, dear {username}");
        }
*/

    }


}


