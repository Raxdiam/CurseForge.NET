using System.Collections.Generic;

namespace CurseForge.Models.Mods;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_GetModFilesRequestBody" />
/// </summary>
public class GetModFilesRequestBody
{
    public List<long> FileIds { get; set; }
}