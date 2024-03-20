using HotelBookingWeb.Entities;
using HotelBookingWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingWeb.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        //[Authorize(Roles = "Admin")]
        /* public async Task<IActionResult> Index()
         {
             string? username = _userManager.GetUserName(User);

             if (!await _roleManager.RoleExistsAsync("User"))
             {
                 await _roleManager.CreateAsync(new IdentityRole("User"));
             }

             await _userManager.AddToRoleAsync((await _userManager.FindByNameAsync(username!))!, "User");

             return View(model: $"Hello from products!!!, dear {username}");
         }*/
        //[AllowAnonymous]
        /*  public IActionResult Details()
          {
              string? username = _userManager.GetUserName(User);
              return View(model: $"Hello from prodcuct details, {username}");
          }*/
    }
}
