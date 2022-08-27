using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurseForge.Models;
using CurseForge.Models.Mods;

namespace CurseForge;

public partial class CurseForge
{
    /// <summary>
    /// Get all mods that match the search criteria.
    /// </summary>
    /// <param name="gameId">Filter by game ID.</param>
    /// <param name="classId">Filter by section ID (discoverable via Categories).</param>
    /// <param name="categoryId">Filter by category ID.</param>
    /// <param name="gameVersion">Filter by game version string.</param>
    /// <param name="searchFilter">Filter by free text search in the mod name and author.</param>
    /// <param name="sortField">Filter by <see cref="ModsSearchSortField"/> enumeration.</param>
    /// <param name="sortOrder">Sort in ascending or descending order.</param>
    /// <param name="modLoaderType">Filter only mods associated to a given modloader (Forge, Fabric, etc). Must be coupled with <paramref name="gameVersion"/>.</param>
    /// <param name="gameVersionTypeId">Filter only mods that contain files tagged with versions of the given <paramref name="gameVersionTypeId"/>.</param>
    /// <param name="slug">Filter by slug (coupled with <paramref name="classId"/> will result in a unique result).</param>
    /// <param name="index">A zero based index of the first item to include in the response. The limit is: (index + pageSize &lt;= 10,000).</param>
    /// <param name="pageSize">The number of items to include in the response. The default/maximum value is 50.</param>
    public async Task<CursePaginatedResponse<List<Mod>>> SearchMods(
        uint gameId,
        uint? classId = null,
        uint? categoryId = null,
        string gameVersion = null,
        string searchFilter = null,
        ModsSearchSortField? sortField = null,
        SortOrder? sortOrder = null,
        ModLoaderType? modLoaderType = null,
        uint? gameVersionTypeId = null,
        string slug = null,
        uint? index = null,
        uint? pageSize = null) =>
        await Get<CursePaginatedResponse<List<Mod>>>(
            "/v1/mods/search",
            (nameof(gameId), gameId),
            (nameof(classId), classId),
            (nameof(categoryId), categoryId),
            (nameof(gameVersion), gameVersion),
            (nameof(searchFilter), searchFilter),
            (nameof(sortField), sortField),
            (nameof(sortOrder), sortOrder),
            (nameof(modLoaderType), modLoaderType),
            (nameof(gameVersionTypeId), gameVersionTypeId),
            (nameof(slug), slug),
            (nameof(index), index),
            (nameof(pageSize), pageSize)
        );

    /// <summary>
    /// Get a single mod.
    /// </summary>
    /// <param name="modId">The mod ID.</param>
    public async Task<CurseResponse<Mod>> GetMod(uint modId) => await Get<CurseResponse<Mod>>($"/v1/mods/{modId}");

    /// <summary>
    /// Get a list of mods.
    /// </summary>
    /// <param name="body">Request body containing an array of mod IDs.</param>
    public async Task<CurseResponse<List<Mod>>> GetMods(GetModsByIdsListRequestBody body) => await Post<CurseResponse<List<Mod>>>("/v1/mods", body);

    /// <summary>
    /// Get a list of mods.
    /// </summary>
    /// <param name="modIds">An array of mod IDs.</param>
    public async Task<CurseResponse<List<Mod>>> GetMods(List<long> modIds) =>
        await GetMods(new GetModsByIdsListRequestBody { ModIds = modIds });

    /// <summary>
    /// Get a list of featured, popular and recently updated mods.
    /// </summary>
    /// <param name="body">Match results for a game and exclude specific mods.</param>
    /// <returns></returns>
    public async Task<CurseResponse<FeaturedModsResponse>> GetFeaturedMods(GetFeaturedModsRequestBody body) =>
        await Post<CurseResponse<FeaturedModsResponse>>("/v1/mods/featured", body);

    /// <summary>
    /// Get a list of featured, popular and recently updated mods.
    /// </summary>
    /// <param name="gameId">A game unique ID.</param>
    /// <param name="excludedMods">Excluded mods.</param>
    /// <param name="gameVersionTypeId">Filter only mods that contain files tagged with versions of the given <paramref name="gameVersionTypeId"/>.</param>
    public async Task<CurseResponse<FeaturedModsResponse>> GetFeaturedMods(uint gameId, List<long> excludedMods = null, uint? gameVersionTypeId = null) =>
        await GetFeaturedMods(new GetFeaturedModsRequestBody {
            GameId = gameId,
            ExcludedModIds = excludedMods ?? new List<long>(),
            GameVersionTypeId = gameVersionTypeId
        });

    /// <summary>
    /// Get the full description of a mod in HTML format.
    /// </summary>
    /// <param name="modId">The mod ID.</param>
    public async Task<CurseResponse<string>> GetModDescription(uint modId) => await Get<CurseResponse<string>>($"/v1/mods/{modId}/description");
}