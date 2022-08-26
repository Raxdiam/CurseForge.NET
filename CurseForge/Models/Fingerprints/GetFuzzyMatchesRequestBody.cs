using System.Collections.Generic;

namespace CurseForge.Models.Fingerprints;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_GetFuzzyMatchesRequestBody" />
/// </summary>
public class GetFuzzyMatchesRequestBody
{
    public uint GameId { get; set; }
    public List<FolderFingerprint> Fingerprints { get; set; }
}