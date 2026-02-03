using Microsoft.AspNetCore.Mvc;

public class HomeController :Controller // A base class for an MVC controller with view support

{
    public IActionResult Index()
    {
        List<Dog> dogs =[new("Fido","Labrador",10),new ("bella ","colle",15)];
        return View(dogs); // Returns: The created ViewResult object for the response.
    }
    public IActionResult Dogs()
    {
        return View();
    }
}

record Dog (string Name , string Breed ,int Age);