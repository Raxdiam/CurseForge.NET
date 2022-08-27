using System;

namespace CurseForge.Models.Minecraft;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_MinecraftModLoaderIndex" />
/// </summary>
public class MinecraftModLoaderIndex
{
    public string Name { get; set; }
    public string GameVersion { get; set; }
    public bool Latest { get; set; }
    public bool Recommended { get; set; }
    public DateTimeOffset DateModified { get; set; }
    public ModLoaderType Type { get; set; }
}