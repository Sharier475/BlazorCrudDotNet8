using System.Net.Http.Json;
using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services;

public class ClientGameService : IGameService
{
    private readonly HttpClient _httpClient;

    public ClientGameService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Game> AddGame(Game game)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/game", game);
        return await result.Content.ReadFromJsonAsync<Game>();

    }

    public Task<List<Game>> GetAllGames()
    {
        throw new NotImplementedException();
    }
}