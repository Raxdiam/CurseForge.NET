using System.Collections.Generic;

namespace CurseForge.Models.Fingerprints;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_GetFingerprintMatchesRequestBody" />
/// </summary>
public class GetFingerprintMatchesRequestBody
{
    public List<long> Fingerprints { get; set; }
}