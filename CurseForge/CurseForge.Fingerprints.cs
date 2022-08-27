using System.Collections.Generic;
using System.Threading.Tasks;
using CurseForge.Models;
using CurseForge.Models.Fingerprints;

namespace CurseForge;

public partial class CurseForge
{
    /// <summary>
    /// Get mod files that match a list of fingerprints.
    /// </summary>
    /// <param name="body">The request body containing an array of fingerprints.</param>
    public async Task<CurseResponse<FingerprintsMatchesResult>> GetFingerprintsMatches(GetFingerprintMatchesRequestBody body) =>
        await Post<CurseResponse<FingerprintsMatchesResult>>("/v1/fingerprints", body);

    /// <summary>
    /// Get mod files that match a list of fingerprints.
    /// </summary>
    /// <param name="fingerprints">Array of fingerprints.</param>
    public async Task<CurseResponse<FingerprintsMatchesResult>> GetFingerprintsMatches(List<long> fingerprints) =>
        await GetFingerprintsMatches(new GetFingerprintMatchesRequestBody { Fingerprints = fingerprints });

    /// <summary>
    /// Get mod files that match a list of fingerprints using fuzzy matching.
    /// </summary>
    /// <param name="body">Game ID and folder fingerprints options for the fuzzy matching.</param>
    public async Task<CurseResponse<FingerprintFuzzyMatchResult>> GetFingerprintsFuzzyMatches(GetFuzzyMatchesRequestBody body) =>
        await Post<CurseResponse<FingerprintFuzzyMatchResult>>("/v1/fingerprints/fuzzy", body);

    /// <summary>
    /// Get mod files that match a list of fingerprints using fuzzy matching.
    /// </summary>
    /// <param name="gameId">Game unique ID.</param>
    /// <param name="fingerprints">Folder fingerprints options.</param>
    public async Task<CurseResponse<FingerprintFuzzyMatchResult>> GetFingerprintsFuzzyMatches(uint gameId, List<FolderFingerprint> fingerprints) =>
        await GetFingerprintsFuzzyMatches(new GetFuzzyMatchesRequestBody {
            GameId = gameId,
            Fingerprints = fingerprints
        });
}