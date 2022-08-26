using CurseForge.Models.Mods;

namespace CurseForge.Models.Files;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_FileIndex" />
/// </summary>
public class FileIndex
{
    public string GameVersion { get; set; }
    public uint FileId { get; set; }
    public string Filename { get; set; }
    public FileReleaseType ReleaseType { get; set; }
    public uint? GameVersionTypeId { get; set; }
    public ModLoaderType ModLoader { get; set; }
}