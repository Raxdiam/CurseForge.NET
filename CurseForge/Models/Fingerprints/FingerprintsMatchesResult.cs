using System.Collections.Generic;

namespace CurseForge.Models.Fingerprints;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_FingerprintsMatchesResult" />
/// </summary>
public class FingerprintsMatchesResult
{
    public bool IsCacheBuilt { get; set; }
    public List<FingerprintMatch> ExactMatches { get; set; }
    public List<long> ExactFingerprints { get; set; }
    public List<FingerprintMatch> PartialMatches { get; set; }
    public object PartialMatchFingerprints { get; set; }
    public List<long> AdditionalProperties { get; set; }
    public List<long> InstalledFingerprints { get; set; }
    public List<long> UnmatchedFingerprints { get; set; }
}