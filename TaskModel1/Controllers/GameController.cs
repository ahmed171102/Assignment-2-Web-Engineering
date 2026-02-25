using Microsoft.AspNetCore.Mvc;
using TaskModel1.Interfaces;
using TaskModel1.Models;

namespace TaskModel1.Controllers;

[Route("games")]
[ApiController]
public class GameController : ControllerBase
{
    private readonly IGameService _gameService;

    public GameController(IGameService gameService)
    {
        _gameService = gameService;
    }

    [HttpGet]
    public IActionResult GetAllGames()
    {
        return Ok(_gameService.GetAllGames());
    }

    [HttpGet("{id}")]
    public IActionResult GetGameById(int id)
    {
        var game = _gameService.GetGameById(id);
        if (game == null) return NotFound();
        return Ok(game);
    }

    [HttpPost]
    public IActionResult AddGame([FromBody] Game game)
    {
        _gameService.AddGame(game);
        return Ok(game);
    }
}