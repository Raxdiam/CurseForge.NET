namespace CurseForge.Models.Mods;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_ModAsset" />
/// </summary>
public class ModAsset
{
    public uint Id { get; set; }
    public uint ModId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ThumbnailUrl { get; set; }
    public string Url { get; set; }
}