using Microsoft.AspNetCore.Mvc;
using TaskModel1.Interfaces;
using TaskModel1.Models;

namespace TaskModel1.Controllers;

[Route("food")]
[ApiController]
public class FoodController : ControllerBase
{
    private readonly IFoodService _foodService;

    public FoodController(IFoodService foodService)
    {
        _foodService = foodService;
    }

    [HttpGet]
    public IActionResult GetAllFood()
    {
        return Ok(_foodService.GetAllFood());
    }

    [HttpGet("{id}")]
    public IActionResult GetFoodById(int id)
    {
        var food = _foodService.GetFoodById(id);
        if (food == null) return NotFound();
        return Ok(food);
    }

    [HttpPost]
    public IActionResult AddFood([FromBody] Food food)
    {
        _foodService.AddFood(food);
        return Ok(food);
    }
}