namespace CurseForge.Models.Games;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_GameVersionType" />
/// </summary>
public class GameVersionType
{
    public uint Id { get; set; }
    public uint GameId { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
}