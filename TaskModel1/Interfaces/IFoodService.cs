using TaskModel1.Models;

namespace TaskModel1.Interfaces;

public interface IFoodService
{
    IEnumerable<Food> GetAllFood();
    Food? GetFoodById(int id);
    void AddFood(Food food);
}