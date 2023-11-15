using BlazorCrudDotNet8.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IGameService , GameService>();

await builder.Build().RunAsync();
