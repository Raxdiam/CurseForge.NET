using System.Collections.Generic;

namespace CurseForge.Models.Mods;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_FeaturedModsResponse" />
/// </summary>
public class FeaturedModsResponse
{
    public List<Mod> Featured { get; set; }
    public List<Mod> Popular { get; set; }
    public List<Mod> RecentlyUpdated { get; set; }
}