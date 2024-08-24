using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiParcialitoC.Models;

namespace MiParcialitoC.Controllers;

public class InitialController : Controller
{
    private readonly ILogger<InitialController> _logger;

    public InitialController(ILogger<InitialController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}