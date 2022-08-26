using System.Collections.Generic;

namespace CurseForge.Models.Mods;

/// <summary>
/// <see href="https://docs.curseforge.com/#tocS_GetModsByIdsListRequestBody" />
/// </summary>
public class GetModsByIdsListRequestBody
{
    public List<long> ModIds { get; set; }
}