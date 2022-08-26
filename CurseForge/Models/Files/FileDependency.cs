namespace CurseForge.Models.Files;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_FileDependency" />
/// </summary>
public class FileDependency
{
    public uint ModId { get; set; }
    public FileRelationType RelationType { get; set; }
}