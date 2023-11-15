using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services;

public class GameService : IGameService
{
    private readonly DataContext _context;

    public GameService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Game>> GetAllGames()
    {
        await Task.Delay(500);
        var games = await _context.Games.ToListAsync();
        return games;
    }

    public async Task<Game> AddGame(Game game)
    {
        _context.Games.Add(game);
        await _context.SaveChangesAsync();
        return game;
    }
}