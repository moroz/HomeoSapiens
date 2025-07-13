using System.Globalization;
using Markdig;

namespace HomeoSapiens.Helpers;

public class ViewHelper
{
    public static string RenderMarkdown(string md)
    {
        var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().UseSmartyPants().Build();
        return Markdown.ToHtml(md, pipeline);
    }

    public static string FormatDateTime(DateTime dt)
    {
        var tz = TimeZoneInfo.FindSystemTimeZoneById("Europe/Warsaw");
        var local = TimeZoneInfo.ConvertTimeFromUtc(dt, tz);
        var culture = CultureInfo.GetCultureInfo("pl-PL");
        var ts = local.ToString("f", culture);
        return $"{ts} ({tz.StandardName})";
    }
}