using System.Collections.Generic;
using System.Threading.Tasks;
using CurseForge.Models;
using CurseForge.Models.Files;
using CurseForge.Models.Mods;

namespace CurseForge;

public partial class CurseForge
{
    /// <summary>
    /// Get a single file of the specified mod.
    /// </summary>
    /// <param name="modId">The mod ID the file belongs to.</param>
    /// <param name="fileId">The file ID.</param>
    public async Task<CurseResponse<File>> GetModFile(uint modId, uint fileId) => await Get<CurseResponse<File>>($"/v1/mods/{modId}/files/{fileId}");

    /// <summary>
    /// Get all files of the specified mod.
    /// </summary>
    /// <param name="modId">The mod ID the files belong to.</param>
    /// <param name="gameVersion">Filter by game version string.</param>
    /// <param name="modLoaderType"><see cref="ModLoaderType"/> enumeration. Filter only files associated to a given modloader (Forge, Fabric, etc).</param>
    /// <param name="gameVersionTypeId">Filter only files that are tagged with versions of the given <paramref name="gameVersionTypeId"/>.</param>
    /// <param name="index">A zero based index of the first item to include in the response. The limit is: (index + pageSize &lt;= 10,000).</param>
    /// <param name="pageSize">The number of items to include in the response. The default/maximum value is 50.</param>
    public async Task<CursePaginatedResponse<List<File>>> GetModFiles(
        uint modId,
        string gameVersion = null,
        ModLoaderType? modLoaderType = null,
        uint? gameVersionTypeId = null,
        uint? index = null,
        uint? pageSize = null) =>
        await Get<CursePaginatedResponse<List<File>>>(
            $"/v1/mods/{modId}/files",
            (nameof(gameVersion), gameVersion),
            (nameof(modLoaderType), modLoaderType),
            (nameof(gameVersionTypeId), gameVersionTypeId),
            (nameof(index), index),
            (nameof(pageSize), pageSize)
        );

    /// <summary>
    /// Get a list of files.
    /// </summary>
    /// <param name="body">Request body containing a list of file IDs to fetch.</param>
    public async Task<CurseResponse<List<File>>> GetFiles(GetModFilesRequestBody body) => await Post<CurseResponse<List<File>>>("/v1/mods/files", body);

    /// <summary>
    /// Get a list of files.
    /// </summary>
    /// <param name="fields">List of file IDs to fetch.</param>
    public async Task<CurseResponse<List<File>>> GetFiles(List<long> fileIds) => await GetFiles(new GetModFilesRequestBody { FileIds = fileIds });

    /// <summary>
    /// Get the changelog of a file in HTML format.
    /// </summary>
    /// <param name="modId">The mod ID the file belongs to.</param>
    /// <param name="fileId">The file ID.</param>
    public async Task<CurseResponse<string>> GetModFileChangelog(uint modId, uint fileId) => await Get<CurseResponse<string>>($"/v1/mods/{modId}/files/{fileId}/changelog");

    /// <summary>
    /// Get a download url for a specific file.
    /// </summary>
    /// <param name="modId">The mod ID the file belongs to.</param>
    /// <param name="fileId">The file ID.</param>
    public async Task<CurseResponse<string>> GetModFileDownloadUrl(uint modId, uint fileId) => await Get<CurseResponse<string>>($"/v1/mods/{modId}/files/{fileId}/download-url");
}