using System.Collections.Generic;
using System.Threading.Tasks;
using CurseForge.Models;
using CurseForge.Models.Minecraft;

namespace CurseForge;

public partial class CurseForge
{
    /// <summary>
    /// Get a list of Minecraft versions.
    /// </summary>
    /// <param name="sortDescending">Sort in descending order.</param>
    public async Task<CurseResponse<List<MinecraftGameVersion>>> GetMinecraftVersions(bool? sortDescending = null) =>
        await Get<CurseResponse<List<MinecraftGameVersion>>>("/v1/minecraft/version", (nameof(sortDescending), sortDescending));

    /// <summary>
    /// Get a specific Minecraft version.
    /// </summary>
    /// <param name="gameVersionString">Game version as a <see cref="string"/>.</param>
    public async Task<CurseResponse<MinecraftGameVersion>> GetSpecificMinecraftVersion(string gameVersionString) =>
        await Get<CurseResponse<MinecraftGameVersion>>($"/v1/minecraft/version/{gameVersionString}");

    /// <summary>
    /// Get a list of Minecraft modloaders.
    /// </summary>
    /// <param name="version">Version.</param>
    /// <param name="includeAll">Include all.</param>
    public async Task<CurseResponse<List<MinecraftModLoaderIndex>>> GetMinecraftModLoaders(string version = null, bool? includeAll = null) =>
        await Get<CurseResponse<List<MinecraftModLoaderIndex>>>("/v1/minecraft/modloader", (nameof(version), version), (nameof(includeAll), includeAll));

    /// <summary>
    /// Get a specific Minecraft modloader.
    /// </summary>
    /// <param name="modLoaderName">Modloader name.</param>
    public async Task<CurseResponse<MinecraftModLoaderVersion>> GetSpecificMinecraftModLoader(string modLoaderName) =>
        await Get<CurseResponse<MinecraftModLoaderVersion>>($"/v1/minecraft/modloader/{modLoaderName}");
}