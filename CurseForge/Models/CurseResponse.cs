namespace CurseForge.Models;

/// <summary>
/// <see href="" />
/// </summary>

public class CurseResponse<T>
{
    /// <summary>
    /// The response data
    /// </summary>
    public T Data { get; set; }
}