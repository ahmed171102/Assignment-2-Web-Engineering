using TaskModel1.Models;

namespace TaskModel1.Interfaces;

public interface IGameService
{
    IEnumerable<Game> GetAllGames();
    Game? GetGameById(int id);
    void AddGame(Game game);
}