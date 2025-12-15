using Microsoft.AspNetCore.Mvc;

namespace MotivateMe.Controllers;

public class PostController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}