using System.Collections.Generic;

namespace CurseForge.Models.Games;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_GameVersionsByType" />
/// </summary>
public class GameVersionsByType
{
    public uint Type { get; set; }
    public List<string> Versions { get; set; }
}