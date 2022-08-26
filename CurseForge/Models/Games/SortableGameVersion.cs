using System;

namespace CurseForge.Models.Games;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_SortableGameVersion" />
/// </summary>
public class SortableGameVersion
{
    /// <summary>
    /// Original version name (e.g. 1.5b)
    /// </summary>
    public string GameVersionName { get; set; }
    /// <summary>
    /// Used for sorting (e.g. 0000000001.0000000005)
    /// </summary>
    public string GameVersionPadded { get; set; }
    /// <summary>
    /// Game version clean name (e.g. 1.5)
    /// </summary>
    public string GameVersion { get; set; }
    /// <summary>
    /// Game version release date
    /// </summary>
    public DateTimeOffset GameVersionReleaseDate { get; set; }
    /// <summary>
    /// Game version type ID
    /// </summary>
    public uint? GameVersionTypeId { get; set; }
}