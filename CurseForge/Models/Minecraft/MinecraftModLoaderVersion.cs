using CurseForge.Models.Games;
using System;

namespace CurseForge.Models.Minecraft;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_MinecraftModLoaderVersion" />
/// </summary>
public class MinecraftModLoaderVersion
{
    public uint Id { get; set; }
    public uint GameVersionId { get; set; }
    public uint MinecraftGameVersionId { get; set; }
    public string ForgeVersion { get; set; }
    public string Name { get; set; }
    public ModLoaderType Type { get; set; }
    public string DownloadUrl { get; set; }
    public string FileName { get; set; }
    public ModLoaderInstallMethod InstallMethod { get; set; }
    public bool Latest { get; set; }
    public bool Recommended { get; set; }
    public bool Approved { get; set; }
    public DateTimeOffset DateModified { get; set; }
    public string MavenVersionString { get; set; }
    public string VersionJson { get; set; }
    public string LibrariesInstallLocation { get; set; }
    public string MinecraftVersion { get; set; }
    public string AdditionalFilesJson { get; set; }
    public uint ModLoaderGameVersionId { get; set; }
    public uint ModLoaderGameVersionTypeId { get; set; }
    public GameVersionStatus ModLoaderGameVersionStatus { get; set; }
    public GameVersionTypeStatus ModLoaderGameVersionTypeStatus { get; set; }
    public uint McGameVersionId { get; set; }
    public uint McGameVersionTypeId { get; set; }
    public GameVersionStatus McGameVersionStatus { get; set; }
    public GameVersionTypeStatus McGameVersionTypeStatus { get; set; }
    public string InstallProfileJson { get; set; }
}