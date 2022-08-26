namespace CurseForge.Models;

public struct SortOrder
{
    private SortOrder(string value) => Value = value;

    internal string Value;

    public static readonly SortOrder Ascending = new("asc");
    public static readonly SortOrder Descending = new("desc");

    public override string ToString() => Value;
}