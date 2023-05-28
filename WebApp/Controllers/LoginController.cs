using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Login";

        return View();
    }
}