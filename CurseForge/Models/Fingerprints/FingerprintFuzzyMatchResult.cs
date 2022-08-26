using System.Collections.Generic;

namespace CurseForge.Models.Fingerprints;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_FingerprintFuzzyMatchResult" />
/// </summary>
public class FingerprintFuzzyMatchResult
{
    public List<FingerprintFuzzyMatch> FuzzyMatches { get; set; }
}