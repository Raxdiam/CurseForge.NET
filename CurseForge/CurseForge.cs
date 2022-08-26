using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CurseForge.Models;
using CurseForge.Models.Games;

namespace CurseForge;

public partial class CurseForge : IDisposable
{
    private const string BaseUrl = "https://api.curseforge.com";

    private static readonly JsonSerializerOptions JsonOptions = new() {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    private readonly HttpClient _http;

    /// <summary>
    /// CurseForge API client.
    /// </summary>
    /// <param name="apiKey">CurseForge API key (retrieve from <see href="https://console.curseforge.com/?#/api-keys"/>).</param>
    /// <param name="customUserAgent">Custom API request UserAgent</param>
    public CurseForge(string apiKey, string customUserAgent = null)
    {
        _http = new HttpClient();

        _http.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
        _http.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", apiKey);
        _http.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", customUserAgent ?? $"CurseForge.NET/{Assembly.GetExecutingAssembly().GetName().Version}");
    }

    private async Task<T> Get<T>(string endpoint, params (string Key, object Value)[] queryParams)
    {
        using var res = await _http.GetAsync(BaseUrl + endpoint + BuildQueryString(queryParams));
        return await ResolveResponse<T>(res);
    }

    private async Task<T> Post<T>(string endpoint, object body)
    {
        using var res = await _http.PostAsync(BaseUrl + endpoint, new StringContent(JsonSerializer.Serialize(body, JsonOptions), Encoding.UTF8, "application/json"));
        return await ResolveResponse<T>(res);
    }

    private static async Task<T> ResolveResponse<T>(HttpResponseMessage res)
    {
        res.EnsureSuccessStatusCode();

        await using var stream = await res.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<T>(stream, JsonOptions);
    }

    private static string BuildQueryString((string Key, object Value)[] queryParams)
    {
        return queryParams.Count(kv => kv.Value != null) == 0
            ? string.Empty
            : "?" + string.Join("&",
                queryParams
                    .Where(kv => kv.Value != null)
                    .Select(kv => $"{WebUtility.UrlEncode(kv.Key)}={WebUtility.UrlEncode(kv.Value.ToString())}"));
    }

    public void Dispose()
    {
        _http?.Dispose();
    }
}