using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/animals-controller")]
// [Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet("GetListOfAnimals")]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().getListAnimals();
        return Ok(animals);
    }
    
    [HttpGet("FindAnimalById")]
    public IActionResult GetAnimalById(int id)
    {
        var animals = new MockDb().getAnimalById(id);
        return Ok(animals);
    }

    [HttpPost("AddAnimal")]
    public IActionResult AddAnimal(int id, string name, string category, double weight, string color)
    {
        new MockDb().addAnimal(id, name, category, weight, color);
        return Created();
    }
    [HttpPut("EditAnimal")]
    public IActionResult EditAnimal(int id, string name, string category, double weight, string color)
    {
        new MockDb().editAnimal(id, name, category, weight, color);
        return Ok();
    }
    [HttpDelete("RemoveAnimal")]
    public IActionResult EditAnimal(int id)
    {
        new MockDb().deleteAnimal(id);
        return Ok();
    }
    [HttpGet("GetListOfVisits")]
    public IActionResult ListOfVisits(int idAnimal)
    {
        var visits = new MockDb().getListOfVisits(idAnimal);
        return Ok(visits);
    }
    [HttpPost("AddVisit")]
    public IActionResult AddVisit(DateTime date, int idAnimal, string description, double price)
    {
        new MockDb().addVisit(date, idAnimal, description, price);
        return Created();
    }
    
}