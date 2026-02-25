using TaskModel1.Interfaces;
using TaskModel1.Models;

namespace TaskModel1.Services;

public class FoodService : IFoodService
{
    private List<Food> _foods = new List<Food>
    {
        new Food { Id = 1, Name = "Koshary", CuisineType = "Egyptian", Price = 35.50 },
        new Food { Id = 2, Name = "Molokhia", CuisineType = "Egyptian", Price = 45.00 }
    };

    public IEnumerable<Food> GetAllFood()
    {
        return _foods;
    }

    public Food? GetFoodById(int id)
    {
        return _foods.FirstOrDefault(f => f.Id == id);
    }

    public void AddFood(Food food)
    {
        food.Id = _foods.Count > 0 ? _foods.Max(f => f.Id) + 1 : 1;
        _foods.Add(food);
    }
}