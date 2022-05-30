using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeuSiteEmMVC.Models;

namespace MeuSiteEmMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        HomeModel home = new HomeModel();
        home.Nome = "Carlos";
        home.Email = "Carlos145@gmail.com";
        return View(home);
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
