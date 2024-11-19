using System.Diagnostics;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICustomerService _customerService;

    public HomeController(ILogger<HomeController> logger,ICustomerService customerService)
    {
        _logger = logger;
        _customerService = customerService;
    }

    public IActionResult Index()
    {
        var data = _customerService.GetAll();
        if (data.Success)
        {
            return View(data.Data);
        }
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
