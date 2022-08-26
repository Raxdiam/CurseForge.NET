using System;

namespace CurseForge.Models.Games;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_Game" />
/// </summary>
public class Game
{
    public uint Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public DateTimeOffset DateModified { get; set; }
    public GameAssets Assets { get; set; }
    public CoreStatus Status { get; set; }
    public CoreApiStatus ApiStatus { get; set; }
}