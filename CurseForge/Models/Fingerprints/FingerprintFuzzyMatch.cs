using CurseForge.Models.Files;
using System.Collections.Generic;

namespace CurseForge.Models.Fingerprints;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_FingerprintFuzzyMatch" />
/// </summary>
public class FingerprintFuzzyMatch
{
    public uint Id { get; set; }
    public File File { get; set; }
    public List<File> LastestFiles { get; set; }
    public List<long> Fingerprints { get; set; }
}