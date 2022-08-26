using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CurseForge.Models;
using CurseForge.Models.Games;

namespace CurseForge;

public partial class CurseForge
{
    /// <summary>
    /// Get all games that are available to the provided API key.
    /// </summary>
    /// <param name="index">A zero based index of the first item to include in the response. The limit is: (index + pageSize &lt;= 10,000).</param>
    /// <param name="pageSize">The number of items to include in the response. The default/maximum value is 50.</param>
    public async Task<CursePaginatedResponse<List<Game>>> GetGames(uint? index = null, uint? pageSize = null) =>
        await Get<CursePaginatedResponse<List<Game>>>("/v1/games", (nameof(index), index), (nameof(pageSize), pageSize));

    /// <summary>
    /// Get a single game. A private game is only accessible by its respective API key.
    /// </summary>
    /// <param name="gameId">A game unique ID.</param>
    public async Task<CurseResponse<Game>> GetGame(uint gameId) => await Get<CurseResponse<Game>>($"/v1/games/{gameId}");

    /// <summary>
    /// Get all available versions for each known version type of the specified game. A private game is only accessible to its respective API key.
    /// </summary>
    /// <param name="gameId">A game unique ID.</param>
    public async Task<CurseResponse<List<GameVersionsByType>>> GetVersions(uint gameId) => 
        await Get<CurseResponse<List<GameVersionsByType>>>($"/v1/games/{gameId}/versions");

    /// <summary>
    /// Get all available version types of the specified game.<br /><br />
    /// A private game is only accessible to its respective API key.<br /><br />
    /// Currently, when creating games via the CurseForge Core Console, you are limited to a single game version type.<br />
    /// This means that this endpoint is probably not useful in most cases and is relevant mostly when handling existing games that have multiple game versions such as World of Warcraft and Minecraft (e.g. 517 for wow_retail).
    /// </summary>
    /// <param name="gameId">A game unique ID.</param>
    public async Task<CurseResponse<List<GameVersionType>>> GetVersionTypes(uint gameId) => 
        await Get<CurseResponse<List<GameVersionType>>>($"/v1/games/{gameId}/version-types");
}