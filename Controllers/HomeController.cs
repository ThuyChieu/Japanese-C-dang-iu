using Microsoft.AspNetCore.Mvc;
using Japanese_C_dang_iu.Models;
using Japanese_C_dang_iu.Services;

namespace Japanese_C_dang_iu.Controllers;

public class HomeController : Controller
{

  private readonly IUserService _userService;

  public HomeController(IUserService userService)
  {
    _userService = userService;
  }

  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Login()
  {
    return View();
  }
}
