using HtmlAgilityPack;

using Microsoft.Extensions.Logging;

using Server.Abstractions.Parser;
using Server.Models.Requests;
using Server.Models.Responses;

namespace Server.Core.Services;

public sealed class Finder : IFinder
{
    private readonly ILogger<Finder> _logger;

    public Finder(ILogger<Finder> logger)
    {
        _logger = logger;
    }

    public async Task<Response> FindValueAsync(FindValueRequest request)
    {
        _logger.LogInformation($"requested url: {request.LocatorUrl}, xPath: {request.Locator}");

        string value = await GetValueFromUrlAsync(request.LocatorUrl, request.Locator) ?? "Could not find the value";

        return new Response(Models.Enums.ResponseCode.SUCCESS, value, Guid.NewGuid());
    }

    private async Task<string?> GetValueFromUrlAsync(string url, string xPath)
    {
        HtmlNode htmlNode = await LoadHtmlNodeAsync(url);
        HtmlNode? foundedValue = htmlNode.SelectSingleNode(xPath);

        return foundedValue?.InnerText;
    }

    private async Task<HtmlNode> LoadHtmlNodeAsync(string url)
    {
        var web = new HtmlWeb();
        HtmlDocument htmlDoc = await web.LoadFromWebAsync(url);

        _logger.LogDebug($"html: {htmlDoc.DocumentNode.InnerHtml}, response status: {web.StatusCode}");

        return htmlDoc.DocumentNode;
    }
}
