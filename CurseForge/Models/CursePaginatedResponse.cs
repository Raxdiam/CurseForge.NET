namespace CurseForge.Models;

public class CursePaginatedResponse<T> : CurseResponse<T>
{
    /// <summary>
    /// The Response pagination information
    /// </summary>
    public Pagination Pagination { get; set; }
}