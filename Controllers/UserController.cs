using System.Diagnostics;
using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.Concrete;
using Microsoft.AspNetCore.Mvc;
using start.Models;

namespace start.Controllers;

public class UserController : Controller
{
    UserManager userManager = new UserManager(new EfUserRepository());
    private readonly ILogger<HomeController> _logger;

    public UserController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var users = userManager.GetList();
        return View(users);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
