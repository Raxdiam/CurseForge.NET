using CurseForge.Models.Files;
using System.Collections.Generic;

namespace CurseForge.Models.Fingerprints;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_FingerprintMatch" />
/// </summary>
public class FingerprintMatch
{
    public uint Id { get; set; }
    public File File { get; set; }
    public List<File> LateFiles { get; set; }
}