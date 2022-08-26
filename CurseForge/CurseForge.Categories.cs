using System.Collections.Generic;
using System.Threading.Tasks;
using CurseForge.Models;

namespace CurseForge;

public partial class CurseForge
{
    /// <summary>
    /// Get all available classes and categories of the specified game.<br />
    /// Specify a game id for a list of all game categories, or a class id for a list of categories under that class.
    /// </summary>
    /// <param name="gameId">A game unique ID.</param>
    /// <param name="classId">A class unique ID.</param>
    public async Task<CurseResponse<List<Category>>> GetCategories(uint gameId, uint? classId = null) =>
        await Get<CurseResponse<List<Category>>>("/v1/categories", (nameof(gameId), gameId), (nameof(classId), classId));
}