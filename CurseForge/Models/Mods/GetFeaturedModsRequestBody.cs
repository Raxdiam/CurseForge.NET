using System.Collections.Generic;

namespace CurseForge.Models.Mods;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_GetFeaturedModsRequestBody" />
/// </summary>
public class GetFeaturedModsRequestBody
{
    public uint GameId { get; set; }
    public List<long> ExcludedModIds { get; set; }
    public uint? GameVersionTypeId { get; set; }
}