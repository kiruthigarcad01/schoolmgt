using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using onlineschoolms.Models;

namespace onlineschoolms.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Course()
    {
        return View();
    }

    public IActionResult Batch()
    {
        return View();
    }

    public IActionResult Registration()
    {
        return View();
    }

    public new IActionResult User()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
