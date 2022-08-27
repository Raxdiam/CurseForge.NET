# CurseForge.NET

A simple C# .NET implementation of the CurseForge API

[![Nuget](https://img.shields.io/nuget/v/CurseForge.NET)](https://www.nuget.org/packages/CurseForge.NET/)

## Usage
This library closely follows the [official documentation for the API](https://docs.curseforge.com/) (https://docs.curseforge.com/).

### Example
```cs
internal class Program
{
    private static async Task Main()
    {
        var client = new CurseForge("<your_api_key>");
        var games = await client.GetGames();

        foreach (var game in games.Data) {
            Console.WriteLine(game.Name);
        }
    }
}
```
