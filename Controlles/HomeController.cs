using Microsoft.AspNetCore.Mvc;

public class HomeController :Controller // A base class for an MVC controller with view support

{
    public IActionResult Index()
    {
        return View(); // Returns: The created ViewResult object for the response.
    }
    public IActionResult Dogs()
    {
        return View();
    }
}