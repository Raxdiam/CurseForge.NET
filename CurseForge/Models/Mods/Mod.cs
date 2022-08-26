using CurseForge.Models.Files;
using System;
using System.Collections.Generic;

namespace CurseForge.Models.Mods;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_Mod" />
/// </summary>
public class Mod
{
    /// <summary>
    /// The mod ID
    /// </summary>
    public uint Id { get; set; }
    /// <summary>
    /// The game ID this mod is for
    /// </summary>
    public uint GameId { get; set; }
    /// <summary>
    /// The name of the mod
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The mod slug that would appear in the URL
    /// </summary>
    public string Slug { get; set; }
    /// <summary>
    /// Relevant links for the mod such as Issue tracker and Wiki
    /// </summary>
    public ModLinks Links { get; set; }
    /// <summary>
    /// Mod summary
    /// </summary>
    public string Summary { get; set; }
    /// <summary>
    /// Current mod status
    /// </summary>
    public ModStatus Status { get; set; }
    /// <summary>
    /// Number of downloads for the mod
    /// </summary>
    public long DownloadCount { get; set; }
    /// <summary>
    /// Whether the mod is included in the featured mods list
    /// </summary>
    public bool IsFeatured { get; set; }
    /// <summary>
    /// The main category of the mod as it was chosen by the mod author
    /// </summary>
    public uint PrimaryCategoryId { get; set; }
    /// <summary>
    /// List of categories that this mod is related to
    /// </summary>
    public List<Category> Categories { get; set; }
    /// <summary>
    /// The class ID this mod belongs to
    /// </summary>
    public uint? ClassId { get; set; }
    /// <summary>
    /// 	List of the mod's authors
    /// </summary>
    public List<ModAuthor> Authors { get; set; }
    /// <summary>
    /// The mod's logo asset
    /// </summary>
    public ModAsset Logo { get; set; }
    /// <summary>
    /// List of screenshots assets
    /// </summary>
    public List<ModAsset> Screnshots { get; set; }
    /// <summary>
    /// The ID of the main file of the mod
    /// </summary>
    public uint MainFileId { get; set; }
    /// <summary>
    /// List of latest files of the mod
    /// </summary>
    public List<File> LatestFiles { get; set; }
    /// <summary>
    /// List of file related details for the latest files of the mod
    /// </summary>
    public List<FileIndex> LatestFileIndexes { get; set; }
    /// <summary>
    /// The creation date of the mod
    /// </summary>
    public DateTimeOffset DateCreated { get; set; }
    /// <summary>
    /// The last time the mod was modified
    /// </summary>
    public DateTimeOffset DateModified { get; set; }
    /// <summary>
    /// The release date of the mod
    /// </summary>
    public DateTimeOffset DateReleased { get; set; }
    /// <summary>
    /// Is mod allowed to be distributed
    /// </summary>
    public bool? AllowModDistribution { get; set; }
    /// <summary>
    /// The mod popularity rank for the game
    /// </summary>
    public uint GamePopularityRank { get; set; }
    /// <summary>
    /// Is the mod available for search. This can be false when a mod is experimental, in a deleted state or has only alpha files
    /// </summary>
    public bool IsAvailable { get; set; }
    /// <summary>
    /// The mod's thumbs up count
    /// </summary>
    public uint ThumbsUpCount { get; set; }
}