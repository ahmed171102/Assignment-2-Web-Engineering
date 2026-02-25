using TaskModel1.Interfaces;
using TaskModel1.Models;

namespace TaskModel1.Services;

public class GameService : IGameService
{
    private List<Game> _games = new List<Game>
    {
        new Game { Id = 1, Name = "World of Warships", Genre = "Naval Warfare", ReleaseDate = new DateTime(2015, 9, 17) },
        new Game { Id = 2, Name = "War Thunder", Genre = "Strategic Warfare", ReleaseDate = new DateTime(2012, 11, 10) } 
    };

    public IEnumerable<Game> GetAllGames()
    {
        return _games;
    }

    public Game? GetGameById(int id)
    {
        return _games.FirstOrDefault(g => g.Id == id);
    }

    public void AddGame(Game game)
    {
        game.Id = _games.Count > 0 ? _games.Max(g => g.Id) + 1 : 1;
        _games.Add(game);
    }
}