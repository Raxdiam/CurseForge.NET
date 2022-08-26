using System;

namespace CurseForge.Models;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_Category" />
/// </summary>
public class Category
{
    /// <summary>
    /// The category ID
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// The game ID related to the category
    /// </summary>
    public uint GameId { get; set; }

    /// <summary>
    /// Category name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The category slug as it appear in the URL
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// The category URL
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// URL for the category icon
    /// </summary>
    public string IconUrl { get; set; }

    /// <summary>
    /// Last modified date of the category
    /// </summary>
    public DateTimeOffset DateModified { get; set; }

    /// <summary>
    /// A top level category for other categories
    /// </summary>
    public bool? IsClass { get; set; }

    /// <summary>
    /// The class ID of the category, meaning - the class of which this category is under
    /// </summary>
    public uint? ClassId { get; set; }

    /// <summary>
    /// The parent category for this category
    /// </summary>
    public uint? ParentCategoryId { get; set; }

    /// <summary>
    /// The display index for this category
    /// </summary>
    public uint? DisplayIndex { get; set; }
}