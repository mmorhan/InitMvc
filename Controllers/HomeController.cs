using System.Diagnostics;
using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using start.Models;
namespace start.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    UserManager userManager = new UserManager(new EfUserRepository());
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        //     var users = new List<User>(){

        //         new User(){FirstName="mazlum",LastName="orhan",Address="Istanbul",status=false},
        //         new User(){FirstName="zeynep",LastName="ads",Address="Istanbul",status=false},
        //         new User(){FirstName="ahmet",LastName="albat",Address="Istanbul",status=false},
        //         new User(){FirstName="emre",LastName="cil",Address="Istanbul",status=false},
        //         new User(){FirstName="egemen",LastName="gunduz",Address="Istanbul",status=false},
        //         new User(){FirstName="esra",LastName="celik",Address="Istanbul",status=false},
        //    };

        // userManager.AddRange(users);

        return View();
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
