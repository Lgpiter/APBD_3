using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalController : Controller
{
    private IAnimalService _animalService;
    
    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalService.GetAnimal();

        if (animal==null)
        {
            return NotFound("Animal not found");
        }
        
        return Ok(animal);
    }
   
   
}