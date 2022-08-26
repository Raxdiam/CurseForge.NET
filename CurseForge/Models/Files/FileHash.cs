namespace CurseForge.Models.Files;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_FileHash" />
/// </summary>
public class FileHash
{
    public string Value { get; set; }
    public HashAlgo Algo { get; set; }
}