using System.Collections.Generic;

namespace CurseForge.Models.Fingerprints;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_FolderFingerprint" />
/// </summary>
public class FolderFingerprint
{
    public string Foldername { get; set; }
    public List<long> Fingerprints { get; set; }
}