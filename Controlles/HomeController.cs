using Microsoft.AspNetCore.Mvc;

public class HomeController :Controller // A base class for an MVC controller with view support

{
    public IActionResult Index()
    {
        return View(); // Returns: The created ViewResult object for the response.
    }
    public IActionResult Dogs()
    {
        List<Dog> dogs =[new("Fido","Labrador",10),new ("Bella ","Colle",12),new("max","bulldog",5),new("rocky","poodle",3)];

        return View(dogs);
    }
    public IActionResult Cats()
    {
        List<Cat> cats = [new("Whiskers","Persian",2),new("Luna","Maine Coon",4),new("Simba","Bengal",1)];
        return View(cats);
    }
}

record Dog (string Name , string Breed ,int Age);
record Cat (string Name , string Breed ,int Age);