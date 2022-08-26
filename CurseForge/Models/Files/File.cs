using CurseForge.Models.Games;
using System;
using System.Collections.Generic;

namespace CurseForge.Models.Files;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_File" />
/// </summary>
public class File
{
    /// <summary>
    ///	The file ID
    /// </summary>
    public uint Id { get; set; }
    /// <summary>
    /// The game ID related to the mod that this file belongs to
    /// </summary>
    public uint GameId { get; set; }
    /// <summary>
    /// The mod ID
    /// </summary>
    public uint ModId { get; set; }
    /// <summary>
    /// Whether the file is available to download
    /// </summary>
    public bool IsAvailable { get; set; }
    /// <summary>
    /// Display name of the file
    /// </summary>
    public string DisplayName { get; set; }
    /// <summary>
    /// Exact file name
    /// </summary>
    public string FileName { get; set; }
    /// <summary>
    /// The file release type
    /// </summary>
    public FileReleaseType ReleaseType { get; set; }
    /// <summary>
    /// Status of the file
    /// </summary>
    public FileStatus FileStatus { get; set; }
    /// <summary>
    /// The file hash (i.e. md5 or sha1)
    /// </summary>
    public List<FileHash> Hashes { get; set; }
    /// <summary>
    /// The file timestamp
    /// </summary>
    public DateTimeOffset FileDate { get; set; }
    /// <summary>
    /// The file length in bytes
    /// </summary>
    public long FileLength { get; set; }
    /// <summary>
    /// The number of downloads for the file
    /// </summary>
    public long DownloadCount { get; set; }
    /// <summary>
    /// The file download URL
    /// </summary>
    public string DownloadUrl { get; set; }
    /// <summary>
    /// List of game versions this file is relevant for
    /// </summary>
    public List<string> GameVersions { get; set; }
    /// <summary>
    /// Metadata used for sorting by game versions
    /// </summary>
    public List<SortableGameVersion> SortableGameVersions { get; set; }
    /// <summary>
    /// List of dependencies files
    /// </summary>
    public List<FileDependency> Dependencies { get; set; }
    public bool? ExposeAsAlternative { get; set; }
    public uint? PrentProjectFileId { get; set; }
    public uint? AlternateFileId { get; set; }
    public uint? ServerPackFileId { get; set; }
    public long FileFingerprint { get; set; }
    public List<FileModule> Modules { get; set; }
}