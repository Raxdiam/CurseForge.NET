namespace CurseForge.Models;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_Pagination" />
/// </summary>
public class Pagination
{
    /// <summary>
    /// A zero based index of the first item that is included in the response
    /// </summary>
    public uint Index { get; set; }

    /// <summary>
    /// The requested number of items to be included in the response
    /// </summary>
    public uint PageSize { get; set; }

    /// <summary>
    /// The actual number of items that were included in the response
    /// </summary>
    public uint ResultCount { get; set; }

    /// <summary>
    /// The total number of items available by the request
    /// </summary>
    public long TotalCount { get; set; }
}