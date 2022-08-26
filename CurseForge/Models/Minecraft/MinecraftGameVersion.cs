using CurseForge.Models.Games;
using System;

namespace CurseForge.Models.Minecraft;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_MinecraftGameVersion" />
/// </summary>
public class MinecraftGameVersion
{
    public uint Id { get; set; }
    public uint GameVersionId { get; set; }
    public string VersionString { get; set; }
    public string JarDownloadUrl { get; set; }
    public bool Approved { get; set; }
    public DateTimeOffset DateModified { get; set; }
    public uint GameVersionTypeId { get; set; }
    public GameVersionStatus GameVersionStatus { get; set; }
    public GameVersionTypeStatus GameVersionTypeStatus { get; set; }
}