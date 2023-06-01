using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.Models;

namespace PizzaDelivery.Controllers;

public class HelloWorldController : Controller
{

    private static List<DogViewModel> dogs = new List<DogViewModel>();
    
    // GET
    public IActionResult Index()
    {
        return View(dogs);
    }

    public IActionResult Create()
    {
        var dogVm = new DogViewModel();
        
        return View(dogVm);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        // return View("Index");
        dogs.Add(dogViewModel);
        return RedirectToAction(nameof(Index));
    }

    public string Hello()
    {
        return "Who's there?";
    }
}