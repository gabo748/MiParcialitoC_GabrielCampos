using Microsoft.AspNetCore.Mvc;

namespace MiParcialitoC.Controllers;

public class BaseController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Login(string email, string password, bool remember)
    {
        // Perform login logic here (e.g., authenticate user)
        
        // Redirect to another action/controller after successful login
        return RedirectToAction("Index", "Home");
    }
}